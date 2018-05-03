using JobChart.Data.ChartStorage;

namespace JobChart
{
    public class BaseService
    {
        public BaseService(ChartContext context)
        {
            Context = context;
        }

        public ChartContext Context { get; }
    }
}
