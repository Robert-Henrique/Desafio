using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Enumeradores
    {
        public enum TipoPessoa
        {
            Pretendente,
            Conjuge,
            Dependente
        }

        public enum StatusFamilia
        {
            CadastroValido,
            PossuiUmaCasa,
            SelecionadaEmOutroProcesso,
            CadastroIncompleto
        }
    }
}
