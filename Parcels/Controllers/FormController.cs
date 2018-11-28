using Microsoft.AspNetCore.Mvc;
using Parcels.Models;


namespace Parcels.Controllers
{
  public class FormController : Controller
  {
    [HttpGet("/form/new")]
    public ActionResult Form()
    {
      return View();
    }
    [HttpPost("/items")]
    public ActionResult Form(string height, string length, string width, string weight)
    {
      Parcel yourParcel = new Parcel(height, length, width, weight);
      return RedirectToAction("Index");
    }
    [HttpGet("/items")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
