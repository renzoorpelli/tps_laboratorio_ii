using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.MetodosExtension;
namespace PruebasUnitarias.TestUnitariosMetodos
{
    [TestClass]
    public class TestUnitariosMetodosExtension
    {
        [TestMethod]
        public void CalcularPorcentaje_DeberiaDevolverElPorcentajePasadoComoParametroDelNumeroInstaciado()
        {
            #region Arrange
            double numero = 10000;
            double expected = 1000;
            double result = 0;
            #endregion

            #region ACT
            result = numero.CalcularPorcentaje(10);
            #endregion
            #region Assert
            Assert.AreEqual(expected, result);


            #endregion

        }
    }
}
