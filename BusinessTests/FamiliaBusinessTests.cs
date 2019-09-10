using DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static DataModel.Enumeradores;

namespace Business.Tests
{
    [TestClass()]
    public class FamiliaBusinessTests
    {
        private readonly FamiliaBusiness familiaBusiness;

        public FamiliaBusinessTests()
        {
            familiaBusiness = new FamiliaBusiness();
        }

        [TestMethod()]
        public void ObterQuantidadeDependentesMenoresDeIdadeTest()
        {
            decimal retorno = familiaBusiness.ObterQuantidadeDependentesMenoresDeIdade(NovaFamilia());
            decimal resultadoEsperado = 2;

            Assert.AreEqual(resultadoEsperado, retorno);
        }

        [TestMethod()]
        public void ObterRendaFamiliarTest()
        {
            decimal retorno = familiaBusiness.ObterRendaFamiliar(NovaFamilia());
            decimal resultadoEsperado = 1950;

            Assert.AreEqual(resultadoEsperado, retorno);
        }

        [TestMethod()]
        public void ObterPretendenteTest()
        {
            var retorno = familiaBusiness.ObterPretendente(NovaFamilia());

            Assert.IsNotNull(retorno);
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
                        DataDeNascimento = new DateTime(2015, 12, 30)
                    }
                }
            };
        }
    }
}