using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Familia
    {
        public Familia()
        {
            Pessoas = new HashSet<Pessoa>();
        }

        public int Id { get; set; }

        public int Status { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}