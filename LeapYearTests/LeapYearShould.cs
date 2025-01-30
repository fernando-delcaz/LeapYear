namespace LeapYearTests;

public class LeapYearShould
{
    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(5)]
    public void return_false_if_not_divisible_by_four(int year)
    {
        Assert.False(LeapYear.IsLeapYear(year));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(4)]
    public void be_divisible_by_four(int year)
    {
        Assert.True(LeapYear.IsLeapYear(year));
    }
    
    [Theory]
    [InlineData(300)]
    [InlineData(500)]
    [InlineData(600)]
    public void return_false_if_divisible_by_100_but_not_by_400(int year)
    {
        Assert.False(LeapYear.IsLeapYear(year));
    }

    [Fact]
    public void return_true_if_divisible_by_100_and_by_400()
    {
        int year = 400;
        Assert.True(LeapYear.IsLeapYear(year));
    }
    
    
}

public static class LeapYear
{
    public static bool IsLeapYear(int year)
    {
        if (year % 100 == 0 && year % 400 != 0) return false;
        
        return year % 4 == 0;
    }
}