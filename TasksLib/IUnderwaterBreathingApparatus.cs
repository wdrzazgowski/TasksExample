namespace Diving;

public interface IUnderwaterBreathingApparatus
{
    public void FillScrubber();
    public void FixHead();
    public void AttachOxygenTank();
    public void AttachDiluentTank();
    public bool PerformLeakTest();
    public bool Calibrate();
    /// <summary>
    /// Allows the user to breathe underwater.
    /// </summary>
    public void BreatheUnderwater();
    public void AddOxygen(int amount);
    public float OxygenPartialPressure { get; }
}