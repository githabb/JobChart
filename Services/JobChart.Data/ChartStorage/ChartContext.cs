using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobChart.Data.ChartStorage
{
    public partial class ChartContext : DbContext
    {
        public virtual DbSet<ChartType> ChartType { get; set; }
        public virtual DbSet<LineChart> LineChart { get; set; }
        public virtual DbSet<PieChart> PieChart { get; set; }
        public virtual DbSet<PolarChart> PolarChart { get; set; }
        public virtual DbSet<SplineChart> SplineChart { get; set; }

        public ChartContext(DbContextOptions<ChartContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChartType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UX_ChartType_Name")
                    .IsUnique();
            });
        }
    }
}
