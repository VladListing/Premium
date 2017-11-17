using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WorkerBonus.Test
{
    public class WorkerBonusTests
    {

        [Fact] 
        void ElementTest()
        {
            Accauntant accauntant = new Accauntant();
               
            //Assert
            Assert.Equal( 100  , accauntant.GetHours(Position.Junior));

        }

        [Fact]
        void ResultTest()
        {
            Accauntant accauntant = new Accauntant();

            //Assert
            Assert.False(accauntant.AskForBonus(Position.Junior, 120 ));

        }
    }
}
