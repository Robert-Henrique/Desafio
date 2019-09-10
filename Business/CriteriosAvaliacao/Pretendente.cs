using DataModel;

namespace Business.CriteriosAvaliacao
{
    public class Pretendente : ICriterioAvaliacao
    {
        private const int UmPonto = 1;
        private const int DoisPontos = 2;
        private const int TresPontos = 3;
        private readonly FamiliaBusiness familiaBusiness;
        private readonly PessoaBusiness pessoaBusiness;

        public Pretendente()
        {
            familiaBusiness = new FamiliaBusiness();
            pessoaBusiness = new PessoaBusiness();
        }

        public int ObterPontuacao(Familia familia)
        {
            var pretendente = familiaBusiness.ObterPretendente(familia);
            int idadeDoPretendente = pessoaBusiness.ObterIdade(pretendente.DataDeNascimento);

            if (idadeDoPretendente < 30)
                return UmPonto;

            else if (idadeDoPretendente <= 44)
                return DoisPontos;

            return TresPontos;
        }
    }
}