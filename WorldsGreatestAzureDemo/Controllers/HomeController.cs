using System.Web;
using System.Web.Mvc;

namespace WorldsGreatestAzureDemo.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      var secureCookie = new HttpCookie("SecureCookie")
      {
        Secure = true,
        Value = "This cookie is secure!"
      };
      Response.Cookies.Add(secureCookie);

      var insecureCookie = new HttpCookie("InsecureCookie")
      {
        Secure = false,
        Value = "This cookie is not secure!"
      };
      Response.Cookies.Add(insecureCookie);

      return View();
    }
  }
}