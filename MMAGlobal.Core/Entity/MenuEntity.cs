using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAGlobal.Core.Entity
{
    public  class MenuEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string label { get; set; }
        public string routerLink { get; set; }
        public int? parentId { get; set; }
        public string icon { get; set; }
        public bool isActive { get; set; }
        public int RoleId { get; set; }
        public int Priorities { get; set; }
    }
}
