using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAGlobal.Application.Responses
{
    public class MenuResponse
    {
        public int ID { get; set; }
        public string label { get; set; }
        public string routerLink { get; set; }
        public int? parentId { get; set; }
        public string icon { get; set; }
        public bool isActive { get; set; }
        public int RoleId { get; set; }
        public int Priorities { get; set; }
        public List<MenuResponse> items { get; set; }
    }
}
