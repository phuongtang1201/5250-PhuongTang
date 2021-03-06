using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mine.Models;
using NUnit.Framework;
using Mine.Helpers;

namespace UnitTests.Helpers
{
    [TestFixture]
    public class DiceHelperUnitTest
    {
        [Test]
        public void RollDice_Invalid_Roll_Zero_Should_Return_Zero()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(0, 1);

            //Reset

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void RollDice_Valid_Roll_1_Dice_6_Should_Return_Between_1_And_6()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(1, 6);

            //Reset

            //Assert
            Assert.AreEqual(true, result >= 1);
            Assert.AreEqual(true, result <= 6);
        }
        [Test]
        public void RollDice_Valid_Roll_2_Dice_6_Should_Return_Between_2_And_12()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(2, 6);

            //Reset

            //Assert
            Assert.AreEqual(true, result >= 2);
            Assert.AreEqual(true, result <= 12);
        }

        [Test]
        public void RollDice_Valid_Roll_1_Dice_6_Should_Not_Less_1_Greater_6()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(1, 6);

            //Reset

            //Assert
            Assert.IsFalse(result < 1);
            Assert.IsFalse(result > 6);
        }
        [Test]
        public void RollDice_InValid_NegRolls_6sided_Should_Fail()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(-1, 6);

            // Reset

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void RollDice_InValid_1Time_Negsided_Should_Fail()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(1, -1);

            // Reset

            // Assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void RollDice_Invalid_Roll_Force_Should_Return_1()
        {
            //Arrange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForceRandomValue = 1;

            //Act
            var result = DiceHelper.RollDice(1, 1);

            //Reset
            DiceHelper.ForceRollsToNotRandom = true;

            //Assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void RollDice_Invalid_Dice_Zero_Should_Return_Zero ()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(1, 0);

            //Reset

            //Assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void RollDice_Invalid_Roll_0_Dice_10_Should_Return_Zero()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(0, 10);

            //Reset

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void RollDice_Invalid_Dice_Zero_Roll_Zero_Should_Return_Zero()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(0, 0);

            //Reset

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void RollDice_Valid_Roll_1_Dice_6_Forced_6_Should_Pass()
        {
            // Arrange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForceRandomValue = 6;

            // Act
            var result = DiceHelper.RollDice(1, 6);

            // Reset
            DiceHelper.ForceRollsToNotRandom = false;

            // Assert
            Assert.AreEqual(6, result);
        }
        [Test]
        public void RollDice_Valid_Roll_3_Dice_10_Fixed_5_Should_Return_15 ()
        {
            // Arrange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForceRandomValue = 5;

            // Act
            var result = DiceHelper.RollDice(3, 10);

            // Reset
            DiceHelper.ForceRollsToNotRandom = false;

            // Assert
            Assert.AreEqual(15, result);
        }
    }
}
