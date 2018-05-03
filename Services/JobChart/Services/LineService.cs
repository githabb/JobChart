using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobChart.Data.ChartStorage;
using JobChart.Models;
using JobChart.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobChart.Services
{
    public class LineService : BaseService, ILineService
    {
        public LineService(ChartContext context) : base(context)
        {
        }

        public async Task<IList<LineModel>> Get()
        {
            var query = Context.LineChart;
            return await SelectQuery(query).ToListAsync();
        }
        private IQueryable<LineModel> SelectQuery(IQueryable<LineChart> query)
        {
            return query.Select(m => new LineModel()
            {
                Id = m.Id,
                Value = m.Value
            });
        }
    }
}
