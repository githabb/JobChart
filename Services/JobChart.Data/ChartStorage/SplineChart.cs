using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobChart.Data.ChartStorage
{
    public partial class SplineChart
    {
        public int Id { get; set; }
        [Required]
        [StringLength(5)]
        public string Letter { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
