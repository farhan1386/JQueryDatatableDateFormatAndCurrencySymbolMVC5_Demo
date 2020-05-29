using JQueryDatatableDateFormatAndCurrencySymbolMvc_Demo.Data;
using System.Linq;
using System.Web.Mvc;

namespace JQueryDatatableDateFormatAndCurrencySymbolMvc_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            var employee = db.Employees.ToList();
            return Json(new { data = employee }, JsonRequestBehavior.AllowGet);
        }


    }
}