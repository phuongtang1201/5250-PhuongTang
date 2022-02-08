﻿using NUnit.Framework;
using Mine.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class HomeMenuItemTests
    {
        [Test]
        public void HomeMenuItem_Constructor_Valid()
        {
            //Arange

            //Act
            var result = new HomeMenuItem();

            //Reset

            //Assert
            Assert.IsNotNull(result);
        }
        [Test]
        public void HomeMenuItem_Set_Get_Valid_Default_Should_Pass()
        {
            //Arange


            //Act
            var result = new HomeMenuItem();
            result.Id = MenuItemType.About;
            result.Title = "Title";
           

            //Reset

            //Assert
            Assert.AreEqual(MenuItemType.About, result.Id);
            Assert.AreEqual("Title", result.Title);

        }

    }
}
