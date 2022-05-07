using Xunit;
using ProjectName;

namespace tests;

public class UnitTest1
{
    [Fact]
    public void SampleTestWorks()
    {
        var testClass = new Class1();
        var result = testClass.TestMethod();

        Assert.Equal("Example string", result);
    }
}