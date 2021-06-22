
using System;
using Xunit;
using FirstResponsiveWebAppRyberg.Models;

namespace FirstResponsiveWebAppUnitTestsRyberg
{
    public class UnitTest1
    {
        public object FirstResponsiveWepAppRyberg { get; private set; }

        [Fact]
        public void TestPass()
        {
            //Arrange
            int testYear = 1997;
            int expected = 24;
            DateTime today = System.DateTime.Now;
            AgeCalculator ac = new AgeCalculator();
            ac.DOB = testYear;

            int? actual;

            //Act
            actual = ac.AgeThisYear();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTrue()
        {
            //Arrange
            int testYear = 1997;
            int expected = 24;
            DateTime today = System.DateTime.Now;
            AgeCalculator ac = new AgeCalculator();
            ac.DOB = testYear;

            int? actual;

            //Act
            actual = ac.AgeThisYear();

            //Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void TestFalse()
        {
            //Arrange
            int testYear = 1997;
            int expected = 25;
            DateTime today = System.DateTime.Now;
            AgeCalculator ac = new AgeCalculator();
            ac.DOB = testYear;

            int? actual;

            //Act
            actual = ac.AgeThisYear();

            //Assert
            Assert.False(expected == actual);
        }
    }
}
