using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void ShouldAccelerate()
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
        public void ShouldConsumeFuel()
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
        public void ShouldRefuel()
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
        public void ShouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            var car = new Car();

            // Act
            car.Accelerate();
            car.Brake();
            //car.Brake();

            // Assert
            Assert.Equal(0, car.Speed);
        }

        [Fact]
        public void ShouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            var car = new Car();

            // Act
            car.ToggleEngine();

            // Assert
            Assert.True(car.CarStarted);
        }

        [Fact]
        public void ShouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            var car = new Car();

            // Act
            car.ToggleEngine();
            car.ToggleEngine();

            // Assert
            Assert.False(car.CarStarted);
        }
    }
}
