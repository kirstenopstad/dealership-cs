namespace Dealership.Models
{
  public class Car 
  {
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    public Car(string year, string make, string model)
    {
      Year = year;
      Make = make;
      Model = model;
    }
  }
}