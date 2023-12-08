using System.ComponentModel.DataAnnotations;

namespace GreenThumb.Models
{
    public class PlantModel
    {
        [Key]
        public int PlantId { get; set; }
        public string PlantName { get; set; } = null!;

        public List<InstructionModel> Instructions { get; set; }

    }
}
