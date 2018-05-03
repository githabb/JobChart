using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobChart.Data.ChartStorage
{
    public partial class PieChart
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Month { get; set; }
        public int Percent { get; set; }
    }
}
