using Microsoft.AspNetCore.Mvc;
using Dealership.Models;

namespace Dealership.Controllers
{
  public class CarController : Controller
  {
    // Routes
    [HttpGet("/add-cars")]
    public ActionResult CreateCar() { return View(); }

    // Adds car to inventory, rediects to index
    [HttpPost("/inventory")]
    public ActionResult Create(string year, string make, string model)
    {
      Car newCar = new Car(year, make, model);
      return RedirectToAction("Index");
    }

    [HttpGet("/inventory")]
    public ActionResult Index()
    {
      // pass a list of instances to the view
      return View();
    }
  }
}