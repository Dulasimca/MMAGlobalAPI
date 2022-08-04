using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MMAGlobal.Core.Entity;

namespace MMAGlobal.Application.Queries
{
    public class GetAllMMAGlobalTestQuery : IRequest<List<MMAGlobalTestEntity>>
    {
    }
}
