using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobChart.Data.ChartStorage;
using JobChart.Models;
using JobChart.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobChart.Services
{
    public class PolarService : BaseService, IPolarService
    {
        public PolarService(ChartContext context) : base(context)
        {
        }

        public async Task<IList<PolarModel>> Get()
        {
            var query = Context.PolarChart;
            return await SelectQuery(query).ToListAsync();
        }
        private IQueryable<PolarModel> SelectQuery(IQueryable<PolarChart> query)
        {
            return query.Select(m => new PolarModel()
            {
                Id = m.Id,
                Year = m.Year,
                Car = m.Car,
                Bus = m.Bus,
                Tractors = m.Tractors
            });
        }
    }
}
