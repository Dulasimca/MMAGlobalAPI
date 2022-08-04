using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MMAGlobal.Core.Repositories;
using MMAGlobal.Application.Queries;

namespace MMAGlobal.Application.Handlers.QueryHandlers
{
    public class GetAllMMAGlobalTestHandler : IRequestHandler<GetAllMMAGlobalTestQuery, List<MMAGlobal.Core.Entity.MMAGlobalTestEntity>>
    {
        private readonly IMMAGlobalTestRepository _employeeRepo;

        public GetAllMMAGlobalTestHandler(IMMAGlobalTestRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<List<MMAGlobal.Core.Entity.MMAGlobalTestEntity>> Handle(GetAllMMAGlobalTestQuery request, CancellationToken cancellationToken)
        {
            return (List<MMAGlobal.Core.Entity.MMAGlobalTestEntity>)await _employeeRepo.GetAllAsync();
        }
    }
}
