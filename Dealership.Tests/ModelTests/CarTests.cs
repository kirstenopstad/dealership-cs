using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dealership.Models;

namespace Dealership.Tests
{
  [TestClass]
  public class CarTests
  {
    [TestMethod]
    public void CreateInstance_CreatesInstanceOfCar_Car()
    {
      //Arrange
      //Act
      Car car = new Car("test", "test", "test");
      //Assert
      Assert.AreEqual(typeof(Car), car.GetType());
    }

    [TestMethod]
    public void AddCar_AddsYearMakeModelToCarObject_strings()
    {
      // Arrange
      string userInput = "1991";
      string userInput2 = "Honda";
      string userInput3 = "Civic";

      // Act
      Car testCar = new Car(userInput, userInput2, userInput3);

      // Assert
      Assert.AreEqual("1991", testCar.Year);
      Assert.AreEqual("Honda", testCar.Make);
      Assert.AreEqual("Civic", testCar.Model);
    }
  }
}