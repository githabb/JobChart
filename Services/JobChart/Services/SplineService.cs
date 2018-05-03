using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobChart.Data.ChartStorage;
using JobChart.Models;
using JobChart.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobChart.Services
{
    public class SplineService : BaseService, ISplineService
    {
        public SplineService(ChartContext context) : base(context)
        {
        }

        public async Task<IList<SplineModel>> Get()
        {
            var query = Context.SplineChart;
            return await SelectQuery(query).ToListAsync();
        }
        private IQueryable<SplineModel> SelectQuery(IQueryable<SplineChart> query)
        {
            return query.Select(m => new SplineModel()
            {
                Id = m.Id,
                Letter = m.Letter,
                X = m.X,
                Y = m.Y
            });
        }
    }
}

