using MMAGlobal.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAGlobal.Core.Repositories
{
    public interface IMMAGlobalTestRepository : IRepository<MMAGlobal.Core.Entity.MMAGlobalTestEntity>
    {
        //custom operations here
        Task<IEnumerable<MMAGlobal.Core.Entity.MMAGlobalTestEntity>> GetEmployeeByLastName(string lastname);
    }
}
