using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kendo_UI_Bootstrap_Integration.Models
{
    public class DonutChartViewModel
    {
        public DonutChartViewModel(string series, string category, double value) 
        {
            Series = series;
            Category = category;
            Value = value;
        }

        public string Series
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public double Value
        {
            get;
            set;
        }
    }
}