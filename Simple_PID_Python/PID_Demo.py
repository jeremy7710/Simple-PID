
class PID:

    def __init__(self, Kp = 0.5, Ki = 0.5, Kd = 0.1, SetPoint = 1, dt = 0.1):

        self.Kp = Kp
        self.Ki = Ki
        self.Kd = Kd
        
        self.SetPoint = SetPoint
        self.dt = dt
        
        self.clear()

    def clear(self):
        
        self.integral = 0.0
        self.pre_err = 0.0
        self.feedback_value = 0.0
        
        self.Yp = 0.0
        
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
    
    
    # if you don't need lowpassFilter, you can delete the code below
    def lowpassFilter(self, X, beta):
    
        Y = beta * X + (1 - beta) * self.Yp
        self.Yp = Y

        return Y


# all you need is set the kp, ki, kd, it's really simple.
# you can set your setpoint and sample time too.
pid = PID(0.7, 6, 0.01, SetPoint=1, dt = 0.1)


y_list = []
x = 0

for i in range(30):
    
    # throw your feadback signal to pid
    x=pid.compute(x)
    
    # your system here, in this demo I use a lowpass filter to simulate a system.
    x=pid.lowpassFilter(x,0.5)
    
    # make a list to draw picture
    y_list.append(x)



import matplotlib.pyplot as plt

plt.plot(range(30),y_list)

pid.clear()

