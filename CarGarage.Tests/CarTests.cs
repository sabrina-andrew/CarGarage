using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            var car = new Car();

            // Act
            car.Accelerate();

            // Assert
            Assert.Equal(10, car.Speed);

        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            // Arrange
            var car = new Car();

            // Act
            car.Accelerate();

            // Assert
            Assert.Equal(90, car.GasLevel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            var car = new Car(50);

            // Act
            car.AddFuel();

            // Assert
            Assert.Equal(100, car.GasLevel);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            var car = new Car();

            // Act
            car.shouldSlowDown();

            // Assert
            Assert.Equal(50, car.Speed);
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            // Act
            // Assert
            
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            // Act
            // Assert
        }
    }
}