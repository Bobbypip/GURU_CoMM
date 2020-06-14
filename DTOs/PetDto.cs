using System.ComponentModel.DataAnnotations;

namespace GURU_CoMM.DTOs
{
    public class PetDto
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
