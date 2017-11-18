using Xunit;

namespace WorkerBonus.Tests
{
    public class WorkerBonusTests
    {
        [Fact]
        private void ElementTest()
        {
            var accauntant = new Accauntant();

            //Assert
            Assert.Equal(100, accauntant.GetHours(Position.Junior));
        }

        [Fact]
        private void ResultTest()
        {
            var accauntant = new Accauntant();

            //Assert
            Assert.False(accauntant.AskForBonus(Position.Junior, 120));
        }
    }
}
