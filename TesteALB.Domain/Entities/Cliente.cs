using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesteALB.Domain.Entities
{
    public class Cliente : Audit
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }
        
        [Required]
        public int Idade { get; set; }

        public Cliente()
        {

        }

        public Cliente(Guid id, string nome, int idade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
        }
    }
}
