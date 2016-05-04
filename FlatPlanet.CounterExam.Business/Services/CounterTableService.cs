using FlatPlanet.CounterExam.Business.Interfaces;
using FlatPlanet.CounterExam.Data.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.CounterExam.Business.Services
{
    public class CounterTableService : BaseService, ICounterTableService
    {
        [Dependency]
        public ICounterTableRepository CounterTableRepository { get; set; }

        public void Increment(out string message, out bool isError)
        {
            message = "";
            isError = false;

            CounterTableRepository.Increment(out message, out isError);
        }

        public void Reset(out string message, out bool isError)
        {
            message = "";
            isError = false;

            CounterTableRepository.Reset(out message, out isError);
        }

        public int Get(out string message, out bool isError)
        {
            message = "";
            isError = false;
            var counterfield = 1;

            counterfield = CounterTableRepository.Get(out message, out isError);

            return counterfield;
        }
    }
}
