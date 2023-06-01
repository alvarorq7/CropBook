using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropBookModels.Models
{
    public class GreenHouse
    {
        [Key]
        public Guid GHId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Plot")]
        public Guid PlotId { get; set; }
        [ForeignKey("Crop")]
        public Guid CropId { get; set; }
    }
}
