using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq_learning;

namespace Moq_learningTeste
{
    [TestClass]
    public class ClubeOperacoesTesteMoq
    {
        private Clube _target;

        private Mock<ISocio> _mock;

        [TestMethod]
        public void CalcularFreteTeste()
        {
            _mock = new Mock<ISocio>();
            _target = new Clube(_mock.Object);

            Socio _socio = new Socio()
            {
                SocioID = 1,
                Nome = "André",
                Sobrenome = "Macena",
                Idade = 21,
                Limite = 5,
            };

            _mock.Setup(x => x.GetSocio(It.IsAny<int>())).Returns(_socio);

            double esperado = 14;

            double obtido = _target.CalcularFrete(_socio.SocioID);
            Assert.AreEqual(esperado, obtido);
        }
    }
}