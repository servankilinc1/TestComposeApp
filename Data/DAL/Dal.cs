using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class Dal : IDal
    {
        public Value GetValue()
        {
            return new Value()
            {
                Id = 191,
                Name = "Temp Valuye Name"
            };
        }
    }
}
