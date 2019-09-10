using System;

namespace Business
{
    public class PessoaBusiness
    {
        private const int Maioridade = 18;

        public bool EhMenorDeIdade(DateTime dataDeNascimento)
        {
            return ObterIdade(dataDeNascimento) < Maioridade;
        }

        public int ObterIdade(DateTime dataDeNascimento)
        {
            var hoje = DateTime.Today;
            var idade = hoje.Year - dataDeNascimento.Year;
            bool fezAniversarioEsteAno = dataDeNascimento.Date <= hoje.AddYears(-idade);

            if (fezAniversarioEsteAno == false)
                idade--;

            return idade;
        }
    }
}