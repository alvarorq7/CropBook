using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropBookModels.Models
{
    public class Plot
    {
        [Key] 
        public Guid PlotId { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        [ForeignKey("Farm")] 
        public Guid FarmId { get; set; }
    }
}
