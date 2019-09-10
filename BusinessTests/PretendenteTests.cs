using System;
using System.Collections.Generic;
using Business.CriteriosAvaliacao;
using DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DataModel.Enumeradores;

namespace BusinessTests
{
    [TestClass]
    public class PretendenteTests
    {
        private readonly Pretendente pretendente;

        public PretendenteTests()
        {
            pretendente = new Pretendente();
        }

        [TestMethod()]
        public void PontuarTest()
        {
            int pontuacao = pretendente.ObterPontuacao(NovaFamilia());
            int resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, pontuacao);
        }

        private static Familia NovaFamilia()
        {
            return new Familia
            {
                Status = (int)StatusFamilia.CadastroValido,
                Pessoas = new List<Pessoa>
                {
                    new Pessoa
                    {
                        Nome = "João",
                        Tipo = (int)TipoPessoa.Pretendente,
                        DataDeNascimento = new DateTime(1989, 12, 30),
                        Rendas = new List<Renda>
                        {
                            new Renda
                            {
                                Valor = 1000
                            }
                        }
                    },
                    new Pessoa
                    {
                        Nome = "Maria",
                        Tipo = (int)TipoPessoa.Conjuge,
                        DataDeNascimento = new DateTime(1989, 12, 30),
                        Rendas = new List<Renda>
                        {
                            new Renda
                            {
                                Valor = 950
                            }
                        }
                    },
                    new Pessoa
                    {
                        Nome = "José",
                        Tipo = (int)TipoPessoa.Dependente,
                        DataDeNascimento = new DateTime(2015, 12, 30)
                    },
                    new Pessoa
                    {
                        Nome = "Angela",
                        Tipo = (int)TipoPessoa.Dependente,
                        DataDeNascimento = new DateTime(2015, 9, 8)
                    }
                }
            };
        }
    }
}