using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityPID;
using UtilityLowpassFilter;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        double Kp = 0.5, Ki = 0.5, Kd = 0.1, SetPoint = 10, dt = 0.1;
        double dt_sum;
        Pen pen = new Pen(Color.Black);
        ArrayList list = new ArrayList();

        PID pid = new PID();
        LowpassFilter system_LP = new LowpassFilter();


        public Form1()
        {
            InitializeComponent();

            list.Add(new Point(10, pictureBox1.Height - 10));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // using pid 
            double output = pid.Start(double.Parse(Output_label.Text));

            // using lowpass filter to simulate system
            output = system_LP.firstOrder_lowpassFilter(output, 0.3);



            // drawing image if you need
            Output_label.Text = output.ToString();

            dt_sum += dt * 5;
            list.Add(new Point((int)dt_sum + 10, pictureBox1.Height - (int)(output * 15)));

            pictureBox1.Refresh();

            if (dt_sum > 400)
                timer1.Stop();
        }

        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // draw x, y axle
            e.Graphics.DrawLine(pen, 0, pictureBox1.Height - 10, pictureBox1.Width, pictureBox1.Height - 10);
            e.Graphics.DrawLine(pen, 10, 0, 10, pictureBox1.Height);

            // draw set point
            e.Graphics.DrawLine(pen, 0, pictureBox1.Height - (int)SetPoint*15, pictureBox1.Width, pictureBox1.Height - (int)SetPoint*15);

            // draw lines
            Point lastPoint = new Point(10, pictureBox1.Height - 10);
            foreach (Point point in list)
            {
                e.Graphics.DrawLine(pen, lastPoint, point);
                lastPoint = point;
            }
        }

        

        

        private void SetBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                Kp = double.Parse(Kp_textBox.Text);
                Ki = double.Parse(Ki_textBox.Text);
                Kd = double.Parse(Kd_textBox.Text);
                SetPoint = double.Parse(SetPoint_textBox.Text);
                dt = double.Parse(dt_textBox.Text);
            }
            catch
            {
                Output_label.Text = "Invalid value!\nPlease enter a double number, and try it again.";
            }

            // set pid
            pid.Set(Kp, Ki, Kd, SetPoint, dt);
            pid.Clear();

            // clear image
            list.Clear();
            list.Add(new Point(10, pictureBox1.Height - 10));
            dt_sum = 0;
            Output_label.Text = "0";
            system_LP.Clear();

            // start timer and refresh image
            timer1.Start();
            pictureBox1.Refresh();
        }

    }
}
