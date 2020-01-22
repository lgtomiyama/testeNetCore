
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace testeNetCore.Models{
    public class Cidade{
        [Key]
        public int Id{get;set;}
        [Required(ErrorMessage = "O nome da cidade é obrigatório")]
        [MaxLength( 60, ErrorMessage = "O nome da cidade deve conter no máximo 15 caracteres")]
        [MinLength( 3, ErrorMessage = "O nome da cidade deve conter no mínimo 3 caracteres")]
        public string Nome{get;set;}
        public  IList<Cidade> Fronteiras { get; set; } = new List<Cidade>();
    }
}