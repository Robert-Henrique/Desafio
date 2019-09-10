using DataModel;

namespace Business.CriteriosAvaliacao
{
    public class RendaFamiliar : ICriterioAvaliacao
    {
        private const int CincoPontos = 5;
        private const int TresPontos = 3;
        private const int UmPonto = 1;
        private const int Zero = 0;
        private readonly FamiliaBusiness familiaBusiness;

        public RendaFamiliar()
        {
            familiaBusiness = new FamiliaBusiness();
        }

        public int ObterPontuacao(Familia familia)
        {
            decimal rendaFamiliar = familiaBusiness.ObterRendaFamiliar(familia);

            if (rendaFamiliar <= 900)
                return CincoPontos;

            else if (rendaFamiliar <= 1500)
                return TresPontos;

            else if (rendaFamiliar <= 2000)
                return UmPonto;

            return Zero;
        }
    }
}