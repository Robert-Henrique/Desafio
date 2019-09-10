using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class AvaliacaoFamiliar
    {
        public int Pontuacao { get; set; }

        public virtual Familia Familia { get; set; }
    }
}