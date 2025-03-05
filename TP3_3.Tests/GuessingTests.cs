using Xunit;
using Guessing;

namespace Guessing.UnitTests
{
    public class GuessingTests
    {
        [Fact]
        public void isGeneratedNumberInBounds()
        {
            GuessingCore guess = new();
            Assert.InRange(guess.num, 1, 100);
        }

        [Fact]
        public void checkHighNumber()
        {
            GuessingCore guess = new();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                guess.guess(101);
            });
        }

        [Fact]
        public void checkLowNumber()
        {
            GuessingCore guess = new();
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                guess.guess(0);
            });
        }

        [Fact]
        public void checkGuess1()
        {
            GuessingCore guess = new();
            guess.num = 33;
            Assert.Equal(0, guess.guess(33));
            Assert.Equal(1, guess.attempts);
        }

        [Fact]
        public void checkGuess3()
        {
            GuessingCore guess = new();
            guess.num = 65;
            Assert.Equal(1, guess.guess(40));
            Assert.Equal(-1, guess.guess(80));
            Assert.Equal(0, guess.guess(65));
            Assert.Equal(3, guess.attempts);
        }

        [Fact]
        public void checkGuess6()
        {
            GuessingCore guess = new();
            guess.num = 32;
            Assert.Equal(1, guess.guess(20));
            Assert.Equal(-1, guess.guess(75));
            Assert.Equal(-1, guess.guess(50));
            Assert.Equal(1, guess.guess(30));
            Assert.Equal(-1, guess.guess(33));
            Assert.Equal(0, guess.guess(32));
            Assert.Equal(6, guess.attempts);
        }
    }
}
