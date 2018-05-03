using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobChart.Data.ChartStorage
{
    public partial class PolarChart
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Car { get; set; }
        public int Bus { get; set; }
        public int Tractors { get; set; }
    }
}
