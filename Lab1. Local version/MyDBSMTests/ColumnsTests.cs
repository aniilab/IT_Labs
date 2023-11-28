using MyDBSM.Models;

namespace MyDBSMTests
{
    public class ColumnsTests
    {
        private Column column;

        [Fact]
        public void TestColorColumnValidation()
        {
            //Arrange
            column = new ColorColumn("FavoriteColor", false);

            //Act
            bool result = column.Validate("#FFFFFF");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestColorIntervalColumnValidation()
        {
            //Arrange
            column = new ColorInvlColumn("Colors", false);

            //Act
            bool result = column.Validate("#567890-#456728");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void TestRealColumnValidation()
        {
            //Arrange
            column = new RealColumn("Weight", true);

            //Act
            bool result = column.Validate(null);

            //Assert
            Assert.False(result);
        }
    }
}
