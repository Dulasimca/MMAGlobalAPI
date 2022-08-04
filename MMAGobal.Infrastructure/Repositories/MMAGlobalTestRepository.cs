using MMAGlobal.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMAGlobal.Core.Entity;
using MMAGlobal.Core.Repositories;
using Microsoft.EntityFrameworkCore;
 

namespace MMAGlobal.Infrastructure.Repositories
{
    public  class MMAGlobalTestRepository  : Repository<MMAGlobalTestEntity>, IMMAGlobalTestRepository
    {
        public MMAGlobalTestRepository(MMAGlobal.Infrastructure.Data.MMAGlobalTestContext globalTestContext) : base(globalTestContext)
        {

        }
        public async Task<IEnumerable<MMAGlobalTestEntity>> GetEmployeeByLastName(string lastname)
        {
            return await _MMAGlobalTestContext.MMAGlobalTest
                .Where(m => m.Name == lastname)
                .ToListAsync();
        }
    }
}
