using Kendo.Mvc.UI;
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
            
            return View();
        }

        public ActionResult SalesPerDay([DataSourceRequest]DataSourceRequest request) 
        {
            var data = new SalesPerDayViewModel[] 
            {
                new SalesPerDayViewModel("Oct1", 1903, 5000),
                new SalesPerDayViewModel("Oct 2", 2398, 5250),
                new SalesPerDayViewModel("Oct 3",1893, 5500),
                new SalesPerDayViewModel("Oct 4", 3452, 5750),
                new SalesPerDayViewModel("Oct 5", 6567, 6000),
                new SalesPerDayViewModel("Oct 6",5892, 6250),
                new SalesPerDayViewModel("Oct 7", 2354, 6500),
                new SalesPerDayViewModel("Oct 8", 7238, 6750),
                new SalesPerDayViewModel("Oct 9", 11574, 7000),
                new SalesPerDayViewModel("Oct 10",6392, 7250),
                new SalesPerDayViewModel("Oct 11",8932, 7500),
                new SalesPerDayViewModel("Oct 12",9320, 7750),
                new SalesPerDayViewModel("Oct 13", 7894, 8000),
                new SalesPerDayViewModel("Oct 14", 9456, 8250),
                new SalesPerDayViewModel("Oct 15", 12745, 8500),
                new SalesPerDayViewModel("Oct 16", 16705, 8750),
                new SalesPerDayViewModel("Oct 17", 19802, 9000),
                new SalesPerDayViewModel("Oct 18",15076, 9250),
                new SalesPerDayViewModel("Oct 19",17892, 9500),
                new SalesPerDayViewModel("Oct 20",12983, 9750),
                new SalesPerDayViewModel("Oct 21",9034, 10000),
                new SalesPerDayViewModel("Oct 22", 8902, 10250),
                new SalesPerDayViewModel("Oct 23",7893, 10500),
                new SalesPerDayViewModel("Oct 24",14562, 10750),
                new SalesPerDayViewModel("Oct 25",10235, 11000),
                new SalesPerDayViewModel("Oct 26", 23901, 11250),
                new SalesPerDayViewModel("Oct 27", 17892, 11500),
                new SalesPerDayViewModel("Oct 28",11982, 11750),
                new SalesPerDayViewModel("Oct 29", 1093, 12000),
                new SalesPerDayViewModel("Oct 30",4598, 12250),
                new SalesPerDayViewModel("Oct 31",3457, 12500),
                new SalesPerDayViewModel("Nov 1",6092, 12750),
                new SalesPerDayViewModel("Nov 2", 7892, 13000),
                new SalesPerDayViewModel("Nov 3",14562, 13250),
                new SalesPerDayViewModel("Nov 4", 13200, 13500),
                new SalesPerDayViewModel("Nov 5", 16502, 13750),
                new SalesPerDayViewModel("Nov 6",18902, 14000),
                new SalesPerDayViewModel("Nov 7", 16702, 14250),
                new SalesPerDayViewModel("Nov 8",10946, 14500),
                new SalesPerDayViewModel("Nov 9", 12093, 14750),
                new SalesPerDayViewModel("Nov 10", 19704, 15000),
                new SalesPerDayViewModel("Nov 11",17903, 15250),
                new SalesPerDayViewModel("Nov 12",17892, 15500),
                new SalesPerDayViewModel("Nov 13",16783, 15750),
                new SalesPerDayViewModel("Nov 14",9845, 16000),
                new SalesPerDayViewModel("Nov 15", 22904, 16250),
                new SalesPerDayViewModel("Nov 16",8934, 16500),
                new SalesPerDayViewModel("Nov 17", 12983, 16750),
                new SalesPerDayViewModel("Nov 18",22876, 17000),
                new SalesPerDayViewModel("Nov 19",20981, 17250),
                new SalesPerDayViewModel("Nov 20", 21873, 17500),
                new SalesPerDayViewModel("Nov 21", 24981, 17750),
                new SalesPerDayViewModel("Nov 22",23873, 18000),
                new SalesPerDayViewModel("Nov 23",18376, 18000),
                new SalesPerDayViewModel("Nov 24",21783, 18000),
                new SalesPerDayViewModel("Nov 25", 15672, 18000),
                new SalesPerDayViewModel("Nov 26",19456, 18000),
                new SalesPerDayViewModel("Nov 27",17998, 18000),
                new SalesPerDayViewModel("Nov 28", 21673, 18000),
                new SalesPerDayViewModel("Nov 29",18234, 18000),
                new SalesPerDayViewModel("Nov 30",26932, 18000)
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SalesPerRegion() 
        {
            var data = new SalesPerRegionViewModel[] 
            {
                new SalesPerRegionViewModel("Oct1", 345, 524, 1034),
                new SalesPerRegionViewModel("Oct 2", 823, 782, 793), 
                new SalesPerRegionViewModel("Oct 3", 672, 891, 330),
                new SalesPerRegionViewModel("Oct 4", 1200, 901, 1351),
                new SalesPerRegionViewModel("Oct 5", 3456, 2123, 988),
                new SalesPerRegionViewModel("Oct 6", 2901, 278, 2713),
                new SalesPerRegionViewModel("Oct 7", 800, 892, 662),
                new SalesPerRegionViewModel("Oct 8", 4562, 872, 1804), 
                new SalesPerRegionViewModel("Oct 9", 6721, 2003, 2850),
                new SalesPerRegionViewModel("Oct 10", 2453, 2010, 1929), 
                new SalesPerRegionViewModel("Oct 11", 4521, 2831, 1580),
                new SalesPerRegionViewModel("Oct 12", 6712, 809, 1799), 
                new SalesPerRegionViewModel("Oct 13", 2891, 1093, 3910), 
                new SalesPerRegionViewModel("Oct 14", 2932, 2003, 4521),
                new SalesPerRegionViewModel("Oct 15", 6721, 3007, 3017),
                new SalesPerRegionViewModel("Oct 16", 7812, 5009, 3884),
                new SalesPerRegionViewModel("Oct 17", 3742, 4006, 12054),
                new SalesPerRegionViewModel("Oct 18", 7812, 3005, 4259),
                new SalesPerRegionViewModel("Oct 19", 7892, 5002, 4998),
                new SalesPerRegionViewModel("Oct 20", 8912, 2032, 2039),
                new SalesPerRegionViewModel("Oct 21", 4525, 3094, 1415),
                new SalesPerRegionViewModel("Oct 22", 5682, 2893, 327), 
                new SalesPerRegionViewModel("Oct 23", 2453, 3456, 1984), 
                new SalesPerRegionViewModel("Oct 24", 7562, 4213, 2787),
                new SalesPerRegionViewModel("Oct 25", 2435, 4567, 3233),
                new SalesPerRegionViewModel("Oct 26", 6781, 6538, 10582),
                new SalesPerRegionViewModel("Oct 27", 7891, 4652, 5349),
                new SalesPerRegionViewModel("Oct 28", 8991, 1234, 1757),
                new SalesPerRegionViewModel("Oct 29", 200, 234, 659),
                new SalesPerRegionViewModel("Oct 30", 2000, 756, 1842), 
                new SalesPerRegionViewModel("Oct 31", 1892, 234, 1331),
                new SalesPerRegionViewModel("Nov 1", 4891, 432, 769), 
                new SalesPerRegionViewModel("Nov 2", 4352, 678, 2862),
                new SalesPerRegionViewModel("Nov 3", 1234, 4567, 8761), 
                new SalesPerRegionViewModel("Nov 4", 7891, 2347, 2962),
                new SalesPerRegionViewModel("Nov 5", 3921, 4623, 7958), 
                new SalesPerRegionViewModel("Nov 6", 8912, 6578, 3412), 
                new SalesPerRegionViewModel("Nov 7", 6781, 4662, 5259), 
                new SalesPerRegionViewModel("Nov 8", 8787, 1040, 1119), 
                new SalesPerRegionViewModel("Nov 9", 8991, 1909, 1193), 
                new SalesPerRegionViewModel("Nov 10", 5782, 3495, 10427),
                new SalesPerRegionViewModel("Nov 11", 10982, 2398, 4523),
                new SalesPerRegionViewModel("Nov 12", 12634, 2654, 2604), 
                new SalesPerRegionViewModel("Nov 13", 6891, 5842, 4050),
                new SalesPerRegionViewModel("Nov 14", 1892, 3556, 4397),
                new SalesPerRegionViewModel("Nov 15", 14512, 6233, 2159), 
                new SalesPerRegionViewModel("Nov 16", 4561, 2613, 1760),
                new SalesPerRegionViewModel("Nov 17", 2573, 3452, 6958), 
                new SalesPerRegionViewModel("Nov 18", 9347, 6772, 6757),
                new SalesPerRegionViewModel("Nov 19", 7792, 2553, 10636),
                new SalesPerRegionViewModel("Nov 20", 8826, 4772, 8275), 
                new SalesPerRegionViewModel("Nov 21", 7935, 7889, 9157), 
                new SalesPerRegionViewModel("Nov 22", 19234, 2374, 2265), 
                new SalesPerRegionViewModel("Nov 23", 7724, 7856, 2796),
                new SalesPerRegionViewModel("Nov 24", 9001, 2345, 10437),
                new SalesPerRegionViewModel("Nov 25", 8764, 4563, 2345),
                new SalesPerRegionViewModel("Nov 26", 13562, 3456, 2438),
                new SalesPerRegionViewModel("Nov 27", 15671, 1436, 891),
                new SalesPerRegionViewModel("Nov 28", 18924, 1123, 1626),
                new SalesPerRegionViewModel("Nov 29", 10992, 3445, 3797),
                new SalesPerRegionViewModel("Nov 30", 3646,  3456, 19830)
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Revenue() 
        {
            var data = new RevenueViewModel[] 
            {
                new RevenueViewModel("Oct1",   686.55,  1199.96,   1540.66), 
                new RevenueViewModel("Oct 2",  1637.77, 1790.78,   1181.57),
                new RevenueViewModel("Oct 3",  1337.28, 2040.39,   491.7), 
                new RevenueViewModel("Oct 4",  2388,    2063.29,   2012.99), 
                new RevenueViewModel("Oct 5",  6877.44, 4861.67,   1472.12), 
                new RevenueViewModel("Oct 6",  5772.99, 636.62,    4042.37), 
                new RevenueViewModel("Oct 7",  1592,    2042.68,   986.38), 
                new RevenueViewModel("Oct 8",  9078.38, 1996.88,   2687.96),
                new RevenueViewModel("Oct 9",  13374.79, 4586.87,  4246.5),
                new RevenueViewModel("Oct 10", 4881.47, 4602.9,    2874.21), 
                new RevenueViewModel("Oct 11", 8996.79, 6482.99,   2354.2), 
                new RevenueViewModel("Oct 12", 13356.88, 1852.61,  2680.51),
                new RevenueViewModel("Oct 13", 5753.09, 2502.97,   5825.9), 
                new RevenueViewModel("Oct 14", 5834.68, 4586.87,   6736.29),
                new RevenueViewModel("Oct 15", 13374.79, 6886.03,  4495.33), 
                new RevenueViewModel("Oct 16", 15545.88, 11470.61, 5787.16), 
                new RevenueViewModel("Oct 17", 7446.58, 9173.74,   17960.46),
                new RevenueViewModel("Oct 18", 15545.88, 6881.45,  6345.91),
                new RevenueViewModel("Oct 19", 15705.08, 11454.58, 7447.02), 
                new RevenueViewModel("Oct 20", 17734.88, 4653.28,  3038.11), 
                new RevenueViewModel("Oct 21", 9004.75, 7085.26,   2108.35), 
                new RevenueViewModel("Oct 22", 11307.18, 6624.97,  487.23), 
                new RevenueViewModel("Oct 23", 4881.47, 7914.24,   2956.16), 
                new RevenueViewModel("Oct 24", 15048.38, 9647.77,  4152.63),
                new RevenueViewModel("Oct 25", 4845.65, 10458.43,  4817.17),
                new RevenueViewModel("Oct 26", 13494.19, 14972.02, 15767.18),
                new RevenueViewModel("Oct 27", 15703.09, 10653.08, 7970.01), 
                new RevenueViewModel("Oct 28", 17892.09, 2825.86,  2617.93), 
                new RevenueViewModel("Oct 29", 398,     535.86,    981.91),
                new RevenueViewModel("Oct 30", 3980,    1731.24,   2744.58), 
                new RevenueViewModel("Oct 31", 3765.08, 535.86,    1983.19), 
                new RevenueViewModel("Nov 1",  9733.09, 989.28,    1145.81), 
                new RevenueViewModel("Nov 2",  8660.48, 1552.62,   4264.38),
                new RevenueViewModel("Nov 3",  2455.66, 10458.43,  13053.89),
                new RevenueViewModel("Nov 4",  15703.09, 5374.63,  4413.38), 
                new RevenueViewModel("Nov 5",  7802.79, 10586.67,  11857.42),
                new RevenueViewModel("Nov 6",  17734.88, 15063.62, 5083.88), 
                new RevenueViewModel("Nov 7",  13494.19, 10675.98, 7835.91), 
                new RevenueViewModel("Nov 8",  17486.13, 2381.6,   1667.31), 
                new RevenueViewModel("Nov 9",  17892.09, 4371.61,  1777.57), 
                new RevenueViewModel("Nov 10", 11506.18, 8003.55,  15536.23),
                new RevenueViewModel("Nov 11", 21854.18, 5491.42,  6739.27), 
                new RevenueViewModel("Nov 12", 25141.66, 6077.66,  3879.96),
                new RevenueViewModel("Nov 13", 13713.09, 13378.18, 6034.5), 
                new RevenueViewModel("Nov 14", 3765.08, 8143.24,   6551.53),
                new RevenueViewModel("Nov 15", 28878.88, 14273.57, 3216.91), 
                new RevenueViewModel("Nov 16", 9076.39, 5983.77,   2622.4), 
                new RevenueViewModel("Nov 17", 5120.27, 7905.08,   10367.42),
                new RevenueViewModel("Nov 18", 18600.53, 15507.88, 10067.93),
                new RevenueViewModel("Nov 19", 15506.08, 5846.37,  15847.64),
                new RevenueViewModel("Nov 20", 17563.74, 10927.88, 12329.75),
                new RevenueViewModel("Nov 21", 15790.65, 18065.81, 13643.93),
                new RevenueViewModel("Nov 22", 38275.66, 5436.46,  3374.85),
                new RevenueViewModel("Nov 23", 15370.76, 17990.24, 4166.04), 
                new RevenueViewModel("Nov 24", 17911.99, 5370.05,  15551.13),
                new RevenueViewModel("Nov 25", 17440.36, 10449.27, 3494.05), 
                new RevenueViewModel("Nov 26", 26988.38, 7914.24,  3632.62),
                new RevenueViewModel("Nov 27", 31185.29, 3288.44,  1327.59), 
                new RevenueViewModel("Nov 28", 37658.76, 2571.67,  2422.74), 
                new RevenueViewModel("Nov 29", 21874.08, 7889.05,  5657.53),
                new RevenueViewModel("Nov 30", 7255.54, 7914.24, 29546.7)
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AliceMutton()
        {
            List<DonutChartViewModel> data = new List<DonutChartViewModel>() 
            {
                new DonutChartViewModel("2011", "Canterbury", 30),
                new DonutChartViewModel("2011", "Manchester", 45),
                new DonutChartViewModel("2011", "Rochester", 25),
                new DonutChartViewModel("2012", "Canterbury", 64),
                new DonutChartViewModel("2012", "Manchester", 12),
                new DonutChartViewModel("2012", "Rochester", 24)
            };

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Gravad()
        {
            List<DonutChartViewModel> data = new List<DonutChartViewModel>() 
            {
                new DonutChartViewModel("2011", "Canterbury", 22),
                new DonutChartViewModel("2011", "Manchester", 18),
                new DonutChartViewModel("2011", "Rochester", 60),
                new DonutChartViewModel("2012", "Canterbury", 35),
                new DonutChartViewModel("2012", "Manchester", 20),
                new DonutChartViewModel("2012", "Rochester", 45)
            };

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Inlagd()
        {
            List<DonutChartViewModel> data = new List<DonutChartViewModel>() 
            {
                new DonutChartViewModel("2011", "Canterbury", 30),
                new DonutChartViewModel("2011", "Manchester", 21),
                new DonutChartViewModel("2011", "Rochester", 49),
                new DonutChartViewModel("2012", "Canterbury", 32),
                new DonutChartViewModel("2012", "Manchester", 25),
                new DonutChartViewModel("2012", "Rochester", 43)
            };

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Spegesild()
        {
            List<DonutChartViewModel> data = new List<DonutChartViewModel>() 
            {
                new DonutChartViewModel("2011", "Canterbury", 37),
                new DonutChartViewModel("2011", "Manchester", 42),
                new DonutChartViewModel("2011", "Rochester", 21),
                new DonutChartViewModel("2012", "Canterbury", 32),
                new DonutChartViewModel("2012", "Manchester", 30),
                new DonutChartViewModel("2012", "Rochester", 38)
            };

            return Json(data, JsonRequestBehavior.AllowGet);
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
