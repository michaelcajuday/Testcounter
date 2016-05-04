using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.CounterExam.Business.Interfaces
{
    public interface ICounterTableService
    {
        void Increment(out string message, out bool isError);
        void Reset(out string message, out bool isError);
        int Get(out string message, out bool isError);
    }
}
