using Autofac;
using JobChart.Services;
using JobChart.Services.Interface;

namespace JobChart
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ChartService>().As<IChartService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PieService>().As<IPieService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<LineService>().As<ILineService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SplineService>().As<ISplineService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PolarService>().As<IPolarService>()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}