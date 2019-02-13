using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronCompositeEnlaceDir;

// Pablo Martinez Arana
namespace CompositeEnlaceDirTest
{
    /// <summary>
    /// Clase de Prubas de EnlaceDirecto.
    /// </summary>
    [TestClass]
    public class EnlaceDirTest
    {
        /// <summary>
        /// No se incluye un test para comprobar que un enlace
        /// no se puede enlazar a otro enlace, ya que la 
        /// propia estructura del software impide que se pueda realizar 
        /// dicha operacion y daria un fallo durante la compilacion.
        /// </summary>

        //Enlace de prueba
        EnlaceDir enlace;
        //Archivo de prueba
        Archivo archivo;

        /// <summary>
        /// Test para comprobar que despues de renombrar un archivo
        /// el enlace tambien cambia su nombre.
        /// </summary>
        [TestMethod]
        public void RenombrarTest()
        {
            archivo = new Archivo("archivo.doc", 1);
            enlace = new EnlaceDir(archivo);
            archivo.Nombre = "renombrado.doc";

            Assert.AreEqual(enlace.Nombre, "renombrado.doc");
        }// RenombrarTest

        /// <summary>
        /// Test para comprobar que el tamanho de un enlace
        /// es correcto.
        /// Resultado: 1
        /// </summary>
        [TestMethod]
        public void TamanhoTest()
        {
            archivo = new Archivo("archivo.doc", 1);
            enlace = new EnlaceDir(archivo);

            Assert.AreEqual(enlace.Tamanho, 1);
        }// TamanhoTest

        /// <summary>
        /// Test para comprobar que el numero de archivos que
        /// contiene un enlace es correcto.
        /// Resultado: 0
        /// </summary>
        [TestMethod]
        public void NumArchivosTest()
        {
            archivo = new Archivo("archivo.doc", 1);
            enlace = new EnlaceDir(archivo);

            Assert.AreEqual(enlace.TotalArchivos, 0);
        }// NumArchivosTest
    }// EnlaceDirTest
}// namespace