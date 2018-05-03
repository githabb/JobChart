using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobChart.Data.ChartStorage;
using JobChart.Models;
using JobChart.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobChart.Services
{
    public class PieService : BaseService, IPieService
    {
        public PieService(ChartContext context) : base(context)
        {
        }

        public async Task<IList<PieModel>> Get()
        {
            var query = Context.PieChart;
            return await SelectQuery(query).ToListAsync();
        }
        private IQueryable<PieModel> SelectQuery(IQueryable<PieChart> query)
        {
            return query.Select(m => new PieModel()
            {
                Id = m.Id,
                Month = m.Month,
                Percent = m.Percent
            });
        }
    }
}
