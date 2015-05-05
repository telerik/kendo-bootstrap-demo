using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kendo_UI_Bootstrap_Integration.Models
{
    public class SalesPerDayViewModel
    {
        public SalesPerDayViewModel(string date, double value, double target) 
        {
            Date = date;
            Value = value;
            Target = target;
        }

        public string Date
        {
            get;
            set;
        }

        public double Value
        {
            get;
            set;
        }

        public double Target
        {
            get;
            set;
        }
    }
}