using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Excepciones;
using Entidades;
using Entidades.GestorDeArchivos;
namespace PruebasUnitarias
{
    [TestClass]
    public class TestUnitariosExcepciones
    {
       [TestMethod]
       [ExpectedException(typeof(ArchivoNullException))]
       public void ValidarExtensionXML_DeberiaDevolverArchivosNullException()
       {
            #region Arrange
            Serializador<ClienteEmpresa> serializador = new Serializador<ClienteEmpresa>(GestorDeArchivo.ETipo.ClienteXML);
            #endregion

            #region Assert
            serializador.ValidarExtensionXml("index.js");


            #endregion

        }

    }
}
