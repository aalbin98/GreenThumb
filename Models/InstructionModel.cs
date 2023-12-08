using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumb.Models
{
    public class InstructionModel
    {
        [Key]
        public int InstructionId { get; set; }
        public string Instruction { get; set; }
        public int PlantId { get; set; }

        [ForeignKey("PlantId")]
        public PlantModel PlantModel { get; set; }
    }
}
