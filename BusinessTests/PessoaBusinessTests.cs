using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Business.Tests
{
    [TestClass()]
    public class PessoaBusinessTests
    {
        private readonly PessoaBusiness pessoaBusiness;

        public PessoaBusinessTests()
        {
            pessoaBusiness = new PessoaBusiness();
        }

        [TestMethod()]
        public void EhMenorDeIdadeTest()
        {
            DateTime dataNascimento = new DateTime(2001, 9, 9);
            bool retorno = pessoaBusiness.EhMenorDeIdade(dataNascimento);

            Assert.AreEqual(false, retorno);
        }

        [TestMethod()]
        public void ObterIdadeTest()
        {
            DateTime dataNascimento = new DateTime(1992, 1, 7);
            int retorno = pessoaBusiness.ObterIdade(dataNascimento);

            Assert.AreEqual(27, retorno);
        }
    }
}