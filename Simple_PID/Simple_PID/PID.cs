using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UtilityPID
{
    public class PID
    {
        double Kp = 0.5, Ki = 0.5, Kd = 0.1, SetPoint = 10, dt = 0.1, integral, pre_err;

        public double Start(double measured_value)
        {
            double err, output, derivative;

            err = SetPoint - measured_value;
            integral += err * dt;
            derivative = (err - pre_err) / dt;
            output = (Kp * err + Ki * integral + Kd * derivative);// * 0.3;


            pre_err = err;

            return output;
        }

        public void Set(double kp, double ki, double kd, double setPoint, double _dt)
        {
            Kp = kp;
            Ki = ki;
            Kd = kd;
            SetPoint = setPoint;
            dt = _dt;
        }

        public void Clear()
        {
            integral = 0;
            pre_err = 0;
        }

    }
}
