using Business;
using System;
using System.Linq;
using static DataModel.Enumeradores;

namespace DesafioDigix
{
    class Program
    {
        private static readonly AvaliacaoFamiliarBusiness avaliacaoFamiliarBusiness = new AvaliacaoFamiliarBusiness();
        private static readonly FamiliaBusiness familiaBusiness = new FamiliaBusiness();

        static void Main(string[] args)
        {
            var familias = familiaBusiness.Obter().Where(f => f.Status == (int)StatusFamilia.CadastroValido).ToList();
            var avaliacoesFamiliares = avaliacaoFamiliarBusiness.ClassificarFamilias(familias);
            Console.WriteLine("Classificação das familias:");

            foreach (var avaliacaoFamiliar in avaliacoesFamiliares)
            {
                var pretendente = familiaBusiness.ObterPretendente(avaliacaoFamiliar.Familia);
                Console.WriteLine($"Família: {avaliacaoFamiliar.Familia.Id} - Pretendente: {pretendente.Nome} - Pontuação: {avaliacaoFamiliar.Pontuacao}");
            }

            Console.ReadLine();
        }
    }
}