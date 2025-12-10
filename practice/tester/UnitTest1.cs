namespace tester;

public class UnitTest1
{
    [Theory]
	[InlineData(2,2,4)]
	[InlineData(5,-1,4)]
	[InlineData(9,4,13)]
    public void Test1(int x, int y, int result)
    {
		Assert.Equal(result, x + y);
    }
}
