using System;
using System.Collections.Generic;
using System.Text;

namespace BrasilCenter.Business.Models
{
   public class Livro : BaseEntity
    {
        public string Nome { get; set; }
        public int Isbn { get; set; }
        public string Autor { get; set; }
        public decimal Preco { get; set; }
        public DateTime DtPublicacao { get; set; }
        public string Capa { get; set; }
    }
}
