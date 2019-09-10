using DataModel;

namespace Business.CriteriosAvaliacao
{
    public interface ICriterioAvaliacao
    {
        int ObterPontuacao(Familia familia);
    }
}