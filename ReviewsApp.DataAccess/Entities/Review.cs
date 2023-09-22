using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewsApp.DataAccess.Entities
{
    [Table("Reviews", Schema = "app")]
    public class Review
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Имя пользователя обязательно")]
        [MaxLength(256)]
        public string UserName { get; set; } = null!;
        [Required(ErrorMessage = "Название организации обязательно")]
        [MaxLength(256)]
        public string OrganisationName { get; set; } = null!;
        [MaxLength(256)]
        public string? OrganisationAddress { get; set; }
        [Required(ErrorMessage = "Что понравилось обязательно")]
        [MaxLength(1000)]
        public string Advantages { get; set; } = null!;
        [MaxLength(1000)]
        public string? Disadvantages { get; set; }
        [MaxLength(1000)]
        public string? Comments { get; set; }
        [Required]
        [Range(1,5, ErrorMessage = "Оценка обязательна")]
        public int Evaluation { get; set; }
    }
}
