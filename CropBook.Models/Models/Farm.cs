using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropBookModels.Models
{
    public class Farm
    {
        [Key]
        public Guid FarmId { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }

    }
}
