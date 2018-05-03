using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobChart.Data.ChartStorage
{
    public partial class LineChart
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
    }
}
