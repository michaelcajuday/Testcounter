using FlatPlanet.CounterExam.Business.Interfaces;
using FlatPlanet.CounterExam.Business.Services;
using FlatPlanet.CounterExam.Data.Interfaces;
using FlatPlanet.CounterExam.Data.Repositories;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.CounterExam.Infra.IoC
{
    public class DependencyConfig
    {
        public static void Configure(IUnityContainer container)
        {
            container.RegisterType<ICounterTableService,  CounterTableService>();
            container.RegisterType<ICounterTableRepository, CounterTableRepository>();
        }
    }
}
