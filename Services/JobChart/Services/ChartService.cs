using JobChart.Data.ChartStorage;
using JobChart.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobChart.Services.Interface;

namespace JobChart.Services
{
    public class ChartService : BaseService, IChartService
    {
        public ChartService(ChartContext context) : base(context)
        {
        }

        public async Task<IList<ChartModel>> Get()
        {
            var query = Context.ChartType;
            return await SelectQuery(query).ToListAsync();
        }

        private IQueryable<ChartModel> SelectQuery(IQueryable<ChartType> query)
        {
            return query.Select(m => new ChartModel()
            {
                Id = m.Id,
                Name = m.Name
            });
        }
    }
}
