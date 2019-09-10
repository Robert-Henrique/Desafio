using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Renda
    {
        public int Id { get; set; }

        public int PessoaId { get; set; }

        public decimal Valor { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}