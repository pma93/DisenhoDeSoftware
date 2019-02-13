using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronComposite;

// Pablo Martinez Arana
namespace CompositeTest
{
    /// <summary>
    /// Test para comprobar que las propiedades de un archivo son correctas.
    /// </summary>
    [TestClass]
    public class ArchivoTest
    {
        //Archivo de prueba
        Archivo archivo;

        /// <summary>
        /// Test para comprobar que el tamanho de un archivo es correcto.
        /// Resultado: 0.5
        /// </summary>
        [TestMethod]
        public void TamanhoTest()
        {
            archivo = new Archivo("Archivo.doc", 0.5);

            Assert.AreEqual(archivo.Tamanho, 0.5);
        }// TamanhoTest

        /// <summary>
        /// Test para comprobar que el numero de archivos que 
        /// contiene archivo es correcto.
        /// Resultado: 1
        /// </summary>
        [TestMethod]
        public void NumArchivosTest()
        {
            archivo = new Archivo("Archivo.doc", 0.5);

            Assert.AreEqual(archivo.TotalArchivos, 1);
        }// NumArchivosTest
    }// ArchivoTest
}// namespace
