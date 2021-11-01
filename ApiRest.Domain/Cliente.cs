using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest.Domain
{
    public class Cliente
    {
        [Key]
        [Required(ErrorMessage = "o campo {0} é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres!")]
        public Guid id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }
    }
}
