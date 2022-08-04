using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MMAGlobal.Application.Responses;

namespace MMAGlobal.Application.Commands
{
    public class CreateMMAGlobalTestCommands : IRequest<MMAGlobalTestResponse>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
