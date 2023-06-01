using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropBookModels.Models
{
    public class Variety
    {
        [Key]
        public Guid VarietyId { get; set; }
        public string VarietyName { get; set; }
        [ForeignKey("Vegetable")]
        public Guid VegetableId { get; set; }
    }
}
