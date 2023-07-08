using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard.AI.Data.EntityIntelligence.Brokers.Storages
{
    internal interface IStorageBroker 
    {
        ValueTask<IEnumerable<dynamic>> Execute(string query); 
    }
}
