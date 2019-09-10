using DataContext;
using DataModel;
using System.Linq;
using static DataModel.Enumeradores;

namespace Business
{
    public class FamiliaBusiness
    {
        private readonly PessoaBusiness pessoaBusiness;
        private readonly DefaultContext defaultContext;

        public FamiliaBusiness()
        {
            pessoaBusiness = new PessoaBusiness();
            defaultContext = new DefaultContext();
        }

        public IQueryable<Familia> Obter()
        {
            return defaultContext.Familia;
        }

        public decimal ObterRendaFamiliar(Familia familia)
        {
            return familia.Pessoas.Sum(p => p.Rendas.Sum(r => r.Valor));
        }

        public Pessoa ObterPretendente(Familia familia)
        {
            return familia.Pessoas.Where(p => p.Tipo == (int)TipoPessoa.Pretendente).FirstOrDefault();
        }
        
        public int ObterQuantidadeDependentesMenoresDeIdade(Familia familia)
        {
            return familia.Pessoas.Count(p => p.Tipo == (int)TipoPessoa.Dependente && pessoaBusiness.EhMenorDeIdade(p.DataDeNascimento));
        }
    }
}
