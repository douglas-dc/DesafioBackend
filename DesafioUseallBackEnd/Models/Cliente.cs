using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioUseallBackEnd.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string nome { get; set; }

        public string cnpj { get; set; }

        public DateTime datacadastro { get; set; }

        public string endereco { get; set; }

        public string telefone { get; set; }
    }

}
