using System;
using Xunit;

namespace fizzbuzz
{
    public class UnitTest1
    {

        FizzBuzz fizzBuzz = new FizzBuzz();
        [Fact]
        public void When_Input_1_Should_Be_Display_1()
        {
            // Arrange
            int input = 1;
            string expected = "1";

            // Action
            string result = fizzBuzz.Said(input);

            // Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void When_Input_2_Should_Be_Display_2()
        {
            // Arrange
            int input = 2;
            string expected = "2";

            // Action
            string result = fizzBuzz.Said(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Input_3_Should_Be_Display_Fizz()
        {
            // Arrange
            int input = 3;
            string expected = "Fizz";

            // Action
            string result = fizzBuzz.Said(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Input_4_Should_Be_Display_4()
        {
            // Arrange
            int input = 4;
            string expected = "4";

            // Action
            string result = fizzBuzz.Said(input);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void When_Input_5_Should_Be_Display_Buzz()
        {
            // Arrange
            int input = 5;
            string expected = "Buzz";

            // Action
            string result = fizzBuzz.Said(input);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void When_Input_6_Should_Be_Display_Fizz()
        {
            // Arrange
            int input = 6;
            string expected = "Fizz";

            // Action
            string result = fizzBuzz.Said(input);
            // Assert
            Assert.Equal(expected, result);
        }

        
        [Fact]
        public void When_Input_7_Should_Be_Display_7()
        {
            // Arrange
            int input = 7;
            string expected = "7";

            // Action
            string result = fizzBuzz.Said(input);
            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void When_Input_8_Should_Be_Display_8()
        {
            // Arrange
            int input = 8;
            string expected = "8";

            // Action
            string result = fizzBuzz.Said(input);
            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void When_Input_9_Should_Be_Display_Fizz()
        {
            // Arrange
            int input = 9;
            string expected = "Fizz";

            // Action
            string result = fizzBuzz.Said(input);
            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void When_Input_10_Should_Be_Display_Buzz()
        {
            // Arrange
            int input = 10;
            string expected = "Buzz";

            // Action
            string result = fizzBuzz.Said(input);
            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void When_Input_12_Should_Be_Display_Fizz()
        {
            // Arrange
            int input =12;
            string expected = "Fizz";

            // Action
            string result = fizzBuzz.Said(input);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Input_15_Should_Be_Display_FizzBuzz()
        {
            // Arrange
            int input =15;
            string expected = "FizzBuzz";

            // Action
            string result = fizzBuzz.Said(input);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Input_30_Should_Be_Display_FizzBuzz()
        {
            // Arrange
            int input =30;
            string expected = "FizzBuzz";

            // Action
            string result = fizzBuzz.Said(input);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Input_40_Should_Be_Display_Buzz()
        {
            // Arrange
            int input = 40;
            string expected = "Buzz";

            // Action
            string result = fizzBuzz.Said(input);
            // Assert
            Assert.Equal(expected, result);
        }


        

        




    }

}
