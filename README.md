# Simple-PID
It's a simple PID simulator in C# and Python.</br>

You can set kp, ki, kd, setpoint, dt, and the function will return a value.</br></br>


The pid formula should be: </br></br>
![image](https://wikimedia.org/api/rest_v1/media/math/render/svg/242b6798586d4fc1aedf7e4f92bf77416e4fc76c)

</br></br>
What it looks like in C#:

    double Kp = 0.5, Ki = 0.5, Kd = 0.1, SetPoint = 10, dt = 0.1, integral, pre_err;

    public double Start(double measured_value)
    {
        double err, output, derivative;

        err = SetPoint - measured_value;
        integral += err * dt;
        derivative = (err - pre_err) / dt;
        output = (Kp * err + Ki * integral + Kd * derivative);


        pre_err = err;

        return output;
    }

And what it looks like in Python:

    def compute(self, feedback_value = None):

        err, output, derivative = 0, 0, 0
        
        if(feedback_value is not None):
            self.feedback_value = feedback_value
            
        err = self.SetPoint - self.feedback_value
        self.integral += err * self.dt
        derivative = (err - self.pre_err) / self.dt
        output = (self.Kp * err + self.Ki * self.integral + self.Kd * derivative)


        self.pre_err = err
        self.feedback_value = output

        return output
        
# How to use:
In C#:</br>
1.You can copy the method above.</br>
2.Use .dll in library folder.</br>
3.Download the project and add in to your project.</br>

In Python:</br>
0.Download the file Simple_PID_Python/PID_Demo.py, and see how to use.</br>
1.Download the file Simple_PID_Python/PID.py</br>
2.import PID</br>
3.Set kp,ki,kd</br>
    pid = PID(1, 10, 0.001, SetPoint=1, dt = 0.1)</br>
4.Use it.</br>
    output = pid.compute(feedback_signal)</br>
5.If you want to start at 0</br>
    pid.clear()</br>

# Example
In C#:</br>
You can open project in example folder.</br>
It's a simple pid demo. 
I use a lowpass filter which I write before to simulate a system.(https://github.com/jeremy7710/LowpassFilter)</br>
Just set kp, ki, kd, dt, setpoint, and click set button.
And image will be plotted.


In Python:
1.You just run the code at Simple_PID_Python/PID_Demo.py, and you will see a beautiful output.

cd YourPath
python PID_Demo.py

# Reference:
https://en.wikipedia.org/wiki/PID_controller
