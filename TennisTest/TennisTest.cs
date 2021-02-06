using NUnit.Framework;

namespace Tennis.UnitTests
{
    public class TennisTest
    {
        private Tennis _tennis;

        [SetUp]
        public void Setup()
        {
            _tennis = new Tennis("Joey", "Tom");
        }

        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void Score_NoInput_ReturnLoveAll()
        {
            Assert.That(_tennis.Score(), Is.EqualTo("love all"));
        }

        [Test]
        [TestCase(1, "fifteen love")]
        [TestCase(2, "thirty love")]
        [TestCase(3, "forty love")]
        public void Score_GivenFirstPlayerScore_ReturnExceptResult(int addScore, string exceptResult)
        {
            GivenFirstPlayerScore(addScore);

            Assert.That(_tennis.Score(), Is.EqualTo(exceptResult));
        }

        [Test]
        [TestCase(1, "love fifteen")]
        [TestCase(2, "love thirty")]
        [TestCase(3, "love forty")]
        public void Score_GivenSecondPlayerScore_ReturnExceptResult(int addScore, string exceptResult)
        {
            GivenSecondPlayerScore(addScore);

            Assert.That(_tennis.Score(), Is.EqualTo(exceptResult));
        }

        [Test]
        [TestCase(1, 1, "fifteen all")]
        [TestCase(2, 2, "thirty all")]
        public void Score_GivenPlayersScore_ReturnExceptResult(int addFirstPlayerScore,
                                                       int addSecondPlayerScore,
                                                       string exceptResult)
        {
            GivenFirstPlayerScore(addFirstPlayerScore);
            GivenSecondPlayerScore(addSecondPlayerScore);

            Assert.That(_tennis.Score(), Is.EqualTo(exceptResult));
        }

        [Test]
        public void Score_GivenDeuce_ReturnDeuce()
        {
            GivenDeuce();
            
            Assert.That(_tennis.Score(), Is.EqualTo("deuce"));
        }

        [Test]
        [TestCase(1, 0, "Joey adv")]
        [TestCase(2, 0, "Joey win")]
        [TestCase(0, 1, "Tom adv")]
        [TestCase(0, 2, "Tom win")]
        public void Score_GivenDeuceAndPlayersScore_ReturnAdvOrWin(int addFirstPlayerScore, int addSecondPlayerScore, string exceptResult)
        {
            GivenDeuce();
            GivenFirstPlayerScore(addFirstPlayerScore);
            GivenSecondPlayerScore(addSecondPlayerScore);

            Assert.That(_tennis.Score(), Is.EqualTo(exceptResult));
        }

        private void GivenDeuce()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(3);
        }

        private void GivenSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.secondPlayerScore();
            }
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.firstPlayerScore();
            }
        }
    }
}