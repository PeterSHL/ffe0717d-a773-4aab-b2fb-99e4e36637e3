using CodingChallenge.Server;

namespace CodingChallenge.Tests;

public class StreamServiceTests
{
    [Theory]
    [InlineData(TestData.Input1, TestData.Output1)]
    [InlineData(TestData.Input2, TestData.Output2)]
    [InlineData(TestData.Input3, TestData.Output3)]
    [InlineData(TestData.Input4, TestData.Output4)]
    [InlineData(TestData.Input5, TestData.Output5)]
    [InlineData(TestData.Input6, TestData.Output6)]
    [InlineData(TestData.Input7, TestData.Output7)]
    [InlineData(TestData.Input8, TestData.Output8)]
    [InlineData(TestData.Input9, TestData.Output9)]
    [InlineData(TestData.Input10, TestData.Output10)]
    [InlineData(TestData.Input11, TestData.Output11)]
    [InlineData(TestData.Input12, TestData.Output12)]
    [InlineData(TestData.Input13, TestData.Output13)]
    [InlineData(TestData.Input14, TestData.Output14)]
    public void FindLongestIncreasingSequence_GivenStreamOfNumbers_ReturnsCorrectSequence(string input,
        string expectedOutput)
    {
        var result = StreamService.FindLongestIncreasingSequence(input);

        Assert.Equal(expectedOutput, string.Join(' ', result));
    }
}
