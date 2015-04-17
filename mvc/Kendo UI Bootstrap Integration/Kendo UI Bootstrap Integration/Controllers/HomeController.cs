using Kendo_UI_Bootstrap_Integration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kendo_UI_Bootstrap_Integration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            var data = new ChartViewModel[] 
            {
                new ChartViewModel("Oct1", 1903, 5000),
                new ChartViewModel("Oct 2", 2398, 5250),
            new ChartViewModel("Oct 3",1893, 5500),
            new ChartViewModel("Oct 4", 3452, 5750),
            new ChartViewModel("Oct 5", 6567, 6000),
            new ChartViewModel("Oct 6",5892, 6250),
            new ChartViewModel("Oct 7", 2354, 6500),
            new ChartViewModel("Oct 8", 7238, 6750),
            new ChartViewModel("Oct 9", 11574, 7000),
            new ChartViewModel("Oct 10",6392, 7250),
            new ChartViewModel("Oct 11",8932, 7500),
            new ChartViewModel("Oct 12",9320, 7750),
            new ChartViewModel("Oct 13", 7894, 8000),
            new ChartViewModel("Oct 14", 9456, 8250),
            new ChartViewModel("Oct 15", 12745, 8500),
            new ChartViewModel("Oct 16", 16705, 8750),
            new ChartViewModel("Oct 17", 19802, 9000),
            new ChartViewModel("Oct 18",15076, 9250),
            new ChartViewModel("Oct 19",17892, 9500),
            new ChartViewModel("Oct 20",12983, 9750),
            new ChartViewModel("Oct 21",9034, 10000),
            new ChartViewModel("Oct 22", 8902, 10250),
            new ChartViewModel("Oct 23",7893, 10500),
            new ChartViewModel("Oct 24",14562, 10750),
            new ChartViewModel("Oct 25",10235, 11000),
            new ChartViewModel("Oct 26", 23901, 11250),
            new ChartViewModel("Oct 27", 17892, 11500),
            new ChartViewModel("Oct 28",11982, 11750),
            new ChartViewModel("Oct 29", 1093, 12000),
            new ChartViewModel("Oct 30",4598, 12250),
            new ChartViewModel("Oct 31",3457, 12500),
            new ChartViewModel("Nov 1",6092, 12750),
            new ChartViewModel("Nov 2", 7892, 13000),
            new ChartViewModel("Nov 3",14562, 13250),
            new ChartViewModel("Nov 4", 13200, 13500),
            new ChartViewModel("Nov 5", 16502, 13750),
            new ChartViewModel("Nov 6",18902, 14000),
            new ChartViewModel("Nov 7", 16702, 14250),
            new ChartViewModel("Nov 8",10946, 14500),
            new ChartViewModel("Nov 9", 12093, 14750),
            new ChartViewModel("Nov 10", 19704, 15000),
            new ChartViewModel("Nov 11",17903, 15250),
            new ChartViewModel("Nov 12",17892, 15500),
            new ChartViewModel("Nov 13",16783, 15750),
            new ChartViewModel("Nov 14",9845, 16000),
            new ChartViewModel("Nov 15", 22904, 16250),
            new ChartViewModel("Nov 16",8934, 16500),
            new ChartViewModel("Nov 17", 12983, 16750),
            new ChartViewModel("Nov 18",22876, 17000),
            new ChartViewModel("Nov 19",20981, 17250),
            new ChartViewModel("Nov 20", 21873, 17500),
            new ChartViewModel("Nov 21", 24981, 17750),
            new ChartViewModel("Nov 22",23873, 18000),
            new ChartViewModel("Nov 23",18376, 18000),
            new ChartViewModel("Nov 24",21783, 18000),
            new ChartViewModel("Nov 25", 15672, 18000),
            new ChartViewModel("Nov 26",19456, 18000),
            new ChartViewModel("Nov 27",17998, 18000),
            new ChartViewModel("Nov 28", 21673, 18000),
            new ChartViewModel("Nov 29",18234, 18000),
            new ChartViewModel("Nov 30",26932, 18000)
            };
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
