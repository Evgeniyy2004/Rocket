using System;

namespace func_rocket;

public class ControlTask
{
    public static Turn ControlRocket(Rocket rocket, Vector target)
    {
        
        var c = target - rocket.Location;
        var angle11 = c.Angle - rocket.Velocity.Angle;
        var angle2 = c.Angle - rocket.Direction;
        double resultangle;
        if (Math.Abs(angle11) > 0.6 && Math.Abs(angle2) > 0.6)
        {
            resultangle = angle2;
        }
        else resultangle = angle11 + angle2;

        if (resultangle > 0) return Turn.Right;
        if (resultangle < 0) return Turn.Left;
        return Turn.None;

    }
}