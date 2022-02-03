using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("never odd or even", true)]
        [InlineData("was it a cat I saw", true)]

        public void PalindromeTester( string word, bool expected)
        {
            //Arange
            var wordSmith = new WordSmith();

            // act
            var actual = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
