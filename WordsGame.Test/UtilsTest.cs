using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace WordsGame.Test;

public class UtilsTest
{
    /*[Fact]
    public void TestNothing()
    {
        Assert.True(false);
    }*/

    [Fact]
    public void EmptyString()
    {
        Assert.Equal("", Utils.Scramble(""));
    }

    [Fact]
    public void OneLetter() 
    {
        Assert.Equal("X", Utils.Scramble("X"));
    }

    [Fact]
    public void TwoLetters()
    {
        Assert.Equal("XY", Utils.Scramble("XY"));
    }

    [Fact]
    public void ThreeLetters()
    {
        //Arrange

        //Act

        //Assert
    }
}