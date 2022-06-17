using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Excepciones;
using Entidades;
using Entidades.GestorDeArchivos;
namespace PruebasUnitarias
{
    [TestClass]
    public class TestUnitariosMetodosExtension
    {
       [TestMethod]
       [ExpectedException(typeof(ArchivoNullException))]
       public void ValidarExtensionXML_DeberiaDevolverArchivosNullException()
       {
            #region Arrange
            Serializador<ClienteEmpresa> serializador = new Serializador<ClienteEmpresa>(GestorDeArchivo.ETipo.ClienteXML);
            #endregion

            #region Assert
            serializador.ValidarExtension("index.js");


            #endregion

        }

    }
}
