using NUnit.Framework;
using Mine.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class ItemModelTests
    {
        [Test]
        public void ItemModel_Constructor_Valid()
        {
            //Arange

            //Act
            var result = new ItemModelTests();

            //Reset

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
