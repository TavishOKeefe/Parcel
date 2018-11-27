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
  }
}
