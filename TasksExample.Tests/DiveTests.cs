namespace TasksExample.Tests;

using NSubstitute;
using Diving;

public class DiveTests
{
    [Fact]
    public void RebreatherPreparationShouldPerformLeakageTest()
    {
        var rebSubstitute = Substitute.For<IUnderwaterBreathingApparatus>();

        var diveUnderTest = new Dive(rebSubstitute);
        diveUnderTest.PrepareRebreather();

        rebSubstitute.Received().PerformLeakTest();
    }
}