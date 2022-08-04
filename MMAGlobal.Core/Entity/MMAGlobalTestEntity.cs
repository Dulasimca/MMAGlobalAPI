using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAGlobal.Core.Entity
{
    public class MMAGlobalTestEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int slno { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
