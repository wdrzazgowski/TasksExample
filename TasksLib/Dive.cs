using Diving;

public class Dive
{
    private IUnderwaterBreathingApparatus? _rebreather;

    public Dive(IUnderwaterBreathingApparatus rebreather)
    {
        _rebreather = rebreather;
    }
    
    public void DiveWithRebreather()
    {
        if(_rebreather == null)
            throw new ArgumentNullException(nameof(_rebreather));

        _rebreather.BreatheUnderwater(20);
    }

    public bool PrepareRebreather()
    {
        if(_rebreather == null)
            throw new ArgumentNullException(nameof(_rebreather));

        _rebreather.FillScrubber();
        _rebreather.FixHead();
        _rebreather.AttachOxygenTank();
        _rebreather.AttachDiluentTank();
        _rebreather.PerformLeakTest();
        _rebreather.Calibrate();

        return true;
    }
}