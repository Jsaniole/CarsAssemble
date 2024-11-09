using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0) { return 0; }
        else if (speed > 0 && speed < 5) { return 1; }
        else if (speed > 4 && speed < 9) { return 0.9; }
        else if (speed == 9) { return 0.8; }
        else if (speed == 10) { return 0.77; }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }

    public static double ProductionRatePerHour(int speed)
    {
        if (speed == 0) { return 0; }
        else if (speed > 0 && speed < 5) { return 1 * 221 * speed; }
        else if (speed > 4 && speed < 9) { return 0.9 * 221 * speed; }
        else if (speed == 9) { return 0.8 * 221 * speed; }
        else if (speed == 10) { return 0.77 * 221 * speed; }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        if (speed == 0) { return 0; }
        else if (speed > 0 && speed < 5) { return (int)(1 * 221 * speed) / 60; }
        else if (speed > 4 && speed < 9) { return (int)(0.9 * 221 * speed) / 60; }
        else if (speed == 9) { return (int)(0.8 * 221 * speed) / 60; }
        else if (speed == 10) { return (int)(0.77 * 221 * speed) / 60; }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }

}
