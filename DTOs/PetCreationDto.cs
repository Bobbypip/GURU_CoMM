using System.ComponentModel.DataAnnotations;

namespace GURU_CoMM.DTOs
{
    public class PetCreationDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
