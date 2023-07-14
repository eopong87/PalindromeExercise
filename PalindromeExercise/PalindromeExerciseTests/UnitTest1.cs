using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah",true)]
        [InlineData("hector", false)]
        
        public void IsPalindromeTest( string someword, bool expected)
        {
            //arrange
            var instance = new WordSmith();
            //act
           var actual = instance.IsPalindrome(someword);
            //assert
            Assert.Equal(expected, actual);
        }
    }  
}
