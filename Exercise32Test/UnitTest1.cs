using System;
using Xunit;
using Exercise32;
namespace Exercise32Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            LastLetter lt = new LastLetter("The quick brown fox jumps over the lazy dog.");

            //Act
            var actual = lt.LastFourLetters();
            //Assert
            Assert.Equal("dog.dog.dog.dog.",actual);

        }
    }
}
