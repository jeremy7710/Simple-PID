# Simple-PID
It's a simple PID simulator.</br>

You can set kp, ki, kd, setpoint, dt, and the function will return a value.</br></br>


The pid formula should be: </br></br>
![image](https://wikimedia.org/api/rest_v1/media/math/render/svg/242b6798586d4fc1aedf7e4f92bf77416e4fc76c)

</br></br>
It looks like:

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
    
# How to use:
1.You can copy the method above.
2.Use .dll in library folder.
3.Download the project and add in to your project.

# Example
You can open project in example folder.</br>
It's a simple pid demo. Just set kp, ki, kd, dt, setpoint, and click set button.


# Reference:
https://en.wikipedia.org/wiki/PID_controller
