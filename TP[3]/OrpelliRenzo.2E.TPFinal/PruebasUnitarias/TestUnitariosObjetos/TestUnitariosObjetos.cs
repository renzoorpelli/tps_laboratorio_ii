using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace PruebasUnitarias
{
    [TestClass]
    public class TestUnitariosObjetos
    {
        [TestMethod]
        public void AlAgregarUnClienteALaLista_DeberiaDevolverTrueSiLoAgregoCorrectamente()
        {
            #region Arrange
            AdministracionEmpresa administracion = new AdministracionEmpresa(20);
            Cliente empresa = new ClienteEmpresa(Cliente.categoriaCliente.Premium, "Andreani", "123123123123", "lobos 123");

            bool expected = true;
            bool result = false;
            #endregion

            #region Act
            result = administracion + empresa;
            #endregion
            #region Assert

            Assert.AreEqual(expected, result);

            #endregion
        }

        [TestMethod]
        public void AlAgregarUnServicioAUnCliente_DeberiaDevolverTrueSiLoAgregoCorrectamente()
        {
            #region Arrange
            Cliente empresa = new ClienteEmpresa(Cliente.categoriaCliente.Premium, "Andreani", "123123123123", "lobos 123");
            Servicio servico = new Servicio(20000, Servicio.dificultadVirus.Dificil, Servicio.tipoVirus.Adware, new System.DateTime(2020, 03, 23));
            bool expected = true;
            bool result = false;
            #endregion

            #region Act
            result = empresa + servico;
            #endregion
            #region Assert

            Assert.AreEqual(expected, result);

            #endregion

        }



        [TestMethod]
        public void AlAgregarUnServicioAUnClienteConCategoriaPremium_DeberiaAplicarleUnDescuentoAlServicio()
        {
            #region Arrange
            Cliente empresa = new ClienteEmpresa(Cliente.categoriaCliente.Premium, "Andreani", "123123123123", "lobos 123");
            Servicio servico = new Servicio(20000, Servicio.dificultadVirus.Dificil, Servicio.tipoVirus.Adware, new System.DateTime(2020, 03, 23));
            double result = 0;
            double expected = 18000;
            #endregion

            #region Act
            if (empresa + servico)
            {
                result = servico.CostoServicio;
            }

            #endregion
            #region Assert

            Assert.AreEqual(expected, result);

            #endregion
        }

        [TestMethod]
        public void AlAgregarUnServicioALaLista_LaPropiedadCountDeLaMismaDeberaSerDisntintoDeCero()
        {
            #region Arrange
            Cliente empresa = new ClienteEmpresa(Cliente.categoriaCliente.Premium, "Andreani", "123123123123", "lobos 123");
            Servicio servico = new Servicio(20000, Servicio.dificultadVirus.Dificil, Servicio.tipoVirus.Adware, new System.DateTime(2020, 03, 23));
            double result = 0;
            double expected = 1;
            #endregion

            #region Act
            if (empresa + servico)
            {
                result = empresa.ListaServiciosCliente.Count;
            }

            #endregion
            #region Assert

            Assert.AreEqual(expected, result);

            #endregion
        }


    }
}
