using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Pessoa
    {
        public Pessoa()
        {
            Rendas = new List<Renda>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public int Tipo { get; set; }

        public int FamiliaId { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public virtual List<Renda> Rendas { get; set; }

        public virtual Familia Familia { get; set; }
    }
}