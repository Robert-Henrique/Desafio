using DataModel;

namespace Business.CriteriosAvaliacao
{
    public class Dependente : ICriterioAvaliacao
    {
        private const int ZeroPonto = 0;
        private const int DoisPontos = 2;
        private const int TresPontos = 3;
        private readonly FamiliaBusiness familiaBusiness;

        public Dependente()
        {
            familiaBusiness = new FamiliaBusiness();
        }

        public int ObterPontuacao(Familia familia)
        {
            int quantidadeDependentesMenoresDeIdade = familiaBusiness.ObterQuantidadeDependentesMenoresDeIdade(familia);

            if (quantidadeDependentesMenoresDeIdade == 0)
                return ZeroPonto;

            if (quantidadeDependentesMenoresDeIdade <= 2)
                return DoisPontos;

            return TresPontos;
        }
    }
}