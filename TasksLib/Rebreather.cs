namespace Diving;

public class Rebreather : IUnderwaterBreathingApparatus
{
    public void FillScrubber()
    {
        Console.WriteLine("Filling scrubber...");
    }

    public void FixHead()
    {
        Console.WriteLine("Fixing head...");
    }

    public void AttachOxygenTank()
    {
        Console.WriteLine("Attaching oxygen tank...");
    }

    public void AttachDiluentTank()
    {
        Console.WriteLine("Attaching diluent tank...");
    }

    public bool PerformLeakTest()
    {
        Console.WriteLine("Performing leak test...");
        return true;
    }

    public bool Calibrate()
    {
        Console.WriteLine("Calibrating...");
        return true;
    }

    public void BreatheUnderwater(int timeInMinutes)
    {
        Console.WriteLine($"Breathing underwater...for {timeInMinutes} minutes");
    }
}
