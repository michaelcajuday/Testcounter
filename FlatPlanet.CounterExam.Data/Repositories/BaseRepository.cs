using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.CounterExam.Data.Repositories
{
    public class BaseRepository
    {
        protected string ConnectionStr
        {
            get
            {
                var s = ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString;
                return s;
            }
        }
    }
}
