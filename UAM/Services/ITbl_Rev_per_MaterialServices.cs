using System.Collections.Generic;
using System.Threading.Tasks;
using UAM.Models;

namespace UAM.Services
{
    public interface ITbl_Rev_per_MaterialServices
    {         
        Task<IEnumerable<tbl_Rev_per_Material>> GetTbl_Rev_per_Material();        
    }
}
