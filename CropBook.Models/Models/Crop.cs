using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropBookModels.Models
{
    public class Crop
    {
        [Key] 
        public Guid CropId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Vegetable")] 
        public Guid VegetableId { get; set; }
        [ForeignKey("Variety")] 
        public Guid VarietyId { get; set; }
    }
}
