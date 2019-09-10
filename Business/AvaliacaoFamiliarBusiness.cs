using Business.CriteriosAvaliacao;
using DataModel;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class AvaliacaoFamiliarBusiness
    {
        private readonly FamiliaBusiness familiaBusiness;

        public AvaliacaoFamiliarBusiness()
        {
            familiaBusiness = new FamiliaBusiness();
        }
        
        public List<AvaliacaoFamiliar> ClassificarFamilias(List<Familia> familias)
        {
            List<AvaliacaoFamiliar> avaliacoesFamiliares = new List<AvaliacaoFamiliar>();
            
            foreach (Familia familia in familias)
            {
                int pontuacao = Pontuar(familia, new RendaFamiliar());
                pontuacao += Pontuar(familia, new Pretendente());
                pontuacao += Pontuar(familia, new Dependente());

                avaliacoesFamiliares.Add(new AvaliacaoFamiliar
                {
                    Familia = familia,
                    Pontuacao = pontuacao
                });
            }

            return avaliacoesFamiliares.OrderByDescending(a => a.Pontuacao).ToList();
        }

        public int Pontuar(Familia familia, ICriterioAvaliacao criterioAvaliacao)
        {
            return criterioAvaliacao.ObterPontuacao(familia);
        }
    }
}