using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMAGlobal.Application.Responses;
using MMAGlobal.Application.Mapper;
using System.Threading;

namespace MMAGlobal.Application.Handlers.CommandHandlers
{
    public class CreateMMAGlobalTestHandler : IRequestHandler<MMAGlobal.Application.Commands.CreateMMAGlobalTestCommands, MMAGlobalTestResponse>
    {

        private readonly MMAGlobal.Core.Repositories.IMMAGlobalTestRepository _MMAGlobalTest;

        public CreateMMAGlobalTestHandler(MMAGlobal.Core.Repositories.IMMAGlobalTestRepository employeeRepository)
        {
            _MMAGlobalTest = employeeRepository;
        }
        public async Task<MMAGlobalTestResponse> Handle(MMAGlobal.Application.Commands.CreateMMAGlobalTestCommands request, CancellationToken cancellationToken)
        {
            var employeeEntitiy = MMAGlobalTestMapper.Mapper.Map<MMAGlobal.Core.Entity.MMAGlobalTestEntity>(request);
            if (employeeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _MMAGlobalTest.AddAsync(employeeEntitiy);
            var employeeResponse = MMAGlobalTestMapper.Mapper.Map<MMAGlobal.Application.Responses.MMAGlobalTestResponse>(newEmployee);
            return employeeResponse;
        }
    }
}
