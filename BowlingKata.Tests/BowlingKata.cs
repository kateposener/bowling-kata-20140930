using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingKata
    {
        [Test]
        public void Number_of_frames_reduces_after_two_rolls()
        {
            var frames = 10;
            int[] rollScore = {1};

            for (int rolls = 1; rolls <= 2; rolls++)
            {
                var totalScore = AddRollScoreToTotalScore(rollScore);
            }

            frames -= 1;

            Assert.That(frames,Is.EqualTo(9));
        }

        [Test]
        public void Score_added_after_first_roll()
        {
            int[] rollScore = {1};
            var totalScore = AddRollScoreToTotalScore(rollScore);

            Assert.That(totalScore, Is.EqualTo(1));
        }

        [Test]
        public void Scores_from_two_rolls_added_together_for_total()
        {
            int[] rollScores = {1,2};
            var totalScore = AddRollScoreToTotalScore(rollScores);

            Assert.That(totalScore, Is.EqualTo(3));
        }

        public int AddRollScoreToTotalScore(int[] rollScores)
        {
            var totalScore = 0;
            for (int i = 0; i < rollScores.Length; i++)
            {
                totalScore += rollScores[i];
            }

            return totalScore;
        }
    }
}
