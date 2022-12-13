using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car 
  {
    private static List<Car> _inventory = new List<Car> {};

    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    public Car(string year, string make, string model)
    {
      Year = year;
      Make = make;
      Model = model;
      _inventory.Add(this);
    }

    public static List<Car> GetInventory()
    {
      return _inventory;
    }

    public static void ClearAll() {
      _inventory.Clear();
    }
  }
}