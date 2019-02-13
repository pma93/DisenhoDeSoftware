using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronCompositeEnlaceDir;

// Pablo Martinez Arana
namespace CompositeEnlaceDirTest
{
    /// <summary>
    /// Test para comprobar que las propiedades de un archivo
    /// comprimido son correctas.
    /// </summary>
    [TestClass]
    public class ArchivoComprimidoTest
    {
        //ArchivoComprimido de prueba
        ArchivoComprimido archivoComprimido;
        //Archivo de prueba
        Archivo archivo;
        //Directorio de prueba
        Directorio directorio;

        /// <summary>
        /// Test para comprobar que el tamanho de un archivo
        /// comprimido vacio es correcto.
        /// Resultado: 1
        /// </summary>
        [TestMethod]
        public void TamanhoVacioTest()
        {
            archivoComprimido = new ArchivoComprimido("Comprimido1.zip");

            Assert.AreEqual(archivoComprimido.Tamanho, 1);
        }// TamanhoVacioTest

        /// <summary>
        /// Test para comprobar que el numero de archivos de un archivo
        /// comprimido vacio es correcto.
        /// Resultado: 1
        /// </summary>
        [TestMethod]
        public void NumArchivosVacioTest()
        {
            archivoComprimido = new ArchivoComprimido("Comprimido1.zip");

            Assert.AreEqual(archivoComprimido.TotalArchivos, 1);
        }// NumArchivosVacioTest

        /// <summary>
        /// Test para comprobar que el tamanho de un archivo
        /// comprimido con 1 elemento es correcto.
        /// Resultado: 1 + 0.5*0.3
        /// </summary>
        [TestMethod]
        public void Tamanho1ElementoTest()
        {
            archivoComprimido = new ArchivoComprimido("Comprimido1.zip");
            archivo = new Archivo("Archivo.doc", 0.5);

            archivoComprimido.AnhadeElemento(archivo);

            Assert.AreEqual(archivoComprimido.Tamanho, 1.15);
        }// Tamanho1ElementoTest

        /// <summary>
        /// Test para comprobar que el numero de archivos de un archivo
        /// comprimido con 1 elemento es correcto.
        /// Resultado: 1
        /// </summary>
        [TestMethod]
        public void NumArchivos1ElementoTest()
        {
            archivoComprimido = new ArchivoComprimido("Comprimido1.zip");
            archivoComprimido.Nombre = "Comprimido1.zip";
            archivo = new Archivo("Archivo.doc", 0.5);

            archivoComprimido.AnhadeElemento(archivo);

            Assert.AreEqual(archivoComprimido.TotalArchivos, 1);
        }// NumArchivos1ElementoTest

        /// <summary>
        /// Test para comprobar que el tamanho de un archivo
        /// comprimido con 2 o mas elementos es correcto.
        /// Resultado: (0.5 + 1)*0.3 + 1  
        /// </summary>
        [TestMethod]
        public void Tamanho2oMasElementosTest()
        {
            archivoComprimido = new ArchivoComprimido("Comprimido1.zip");
            directorio = new Directorio("Carpeta");
            archivo = new Archivo("Archivo.doc", 0.5);

            archivoComprimido.AnhadeElemento(archivo);
            archivoComprimido.AnhadeElemento(directorio);

            Assert.AreEqual(archivoComprimido.Tamanho, 1.45);
        }// Tamanho2oMasElementosTest

        /// <summary>
        /// Test para comprobar que el numero de archivos de un archivo
        /// comprimido cos 2 o mas elementos es correcto.
        /// Resultado: 1
        /// </summary>
        [TestMethod]
        public void NumArchivos2oMasElementosTest()
        {
            archivoComprimido = new ArchivoComprimido("Comprimido1.zip");
            directorio = new Directorio("Carpeta");
            archivo = new Archivo("Archivo.doc", 0.5);

            directorio.AnhadeElemento(archivo);
            archivoComprimido.AnhadeElemento(archivo);
            archivoComprimido.AnhadeElemento(directorio);

            Assert.AreEqual(archivoComprimido.TotalArchivos, 1);
        }// NumArchivos2oMasElementosTest
    }// ArchivoComprimidoTest
}// namespace
