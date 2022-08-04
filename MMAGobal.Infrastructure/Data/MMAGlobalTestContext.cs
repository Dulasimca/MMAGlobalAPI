using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAGlobal.Infrastructure.Data
{
    public class MMAGlobalTestContext : DbContext
    {
        public MMAGlobalTestContext(DbContextOptions<MMAGlobalTestContext> options) : base(options)
        {

        }

        public DbSet<MMAGlobal.Core.Entity.MMAGlobalTestEntity> MMAGlobalTest { get; set; }
    }
}
