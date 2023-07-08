using System.Threading.Tasks;

namespace Standard.AI.Data.EntityIntelligence.Brokers.Storages
{
    internal interface IStorageBroker 
    {
        ValueTask<dynamic> Execute(string query); 
    }
}
