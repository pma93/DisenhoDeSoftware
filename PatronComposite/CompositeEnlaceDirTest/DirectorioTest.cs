using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronCompositeEnlaceDir;

// Pablo Martinez Arana
namespace CompositeEnlaceDirTest
{
    /// <summary>
    /// Test para comprobar que las propiedades de un directorio son correctas.
    /// </summary>
    [TestClass]
    public class DirectorioTest
    {
        //ArchivoComprimido de prueba
        ArchivoComprimido archivoComprimido;
        //Archivo de prueba
        Archivo archivo;
        //Directorio de prueba
        Directorio directorio;

        /// <summary>
        /// Test para comprobar que el tamanho de un directorio vacio es correcto.
        /// Resultado: 1
        /// </summary>
        [TestMethod]
        public void TamanhoVacioTest()
        {
            directorio = new Directorio("Carpeta");

            Assert.AreEqual(directorio.Tamanho, 1);
        }// TamanhoVacioTest

        /// <summary>
        /// Test para comprobar que el numero de archivos que 
        /// contiene un directorio vacio es correcto.
        /// Resultado: 0
        /// </summary>
        [TestMethod]
        public void NumArchivosVacioTest()
        {
            directorio = new Directorio("Carpeta");
           
            Assert.AreEqual(directorio.TotalArchivos, 0);
        }// NumArchivosVacioTest

        /// <summary>
        /// Test para comprobar que el tamanho de un directorio con 1 
        /// elemento es correcto.
        /// Resultado: 30 + 1
        /// </summary>
        [TestMethod]
        public void Tamanho1ElementoTest()
        {
            directorio = new Directorio("Carpeta");
            directorio.Nombre = "Carpeta";
            archivo = new Archivo("Archivo.doc", 30);
           
            directorio.AnhadeElemento(archivo);

            Assert.AreEqual(directorio.Tamanho, 31);
        }// Tamanho1ElementoTest

        /// <summary>
        /// Test para comprobar que el numero de archivos que 
        /// contiene un directorio con 1 elemento es correcto.
        /// Resultado: 1
        /// </summary>
        [TestMethod]
        public void NumArchivos1ElementoTest()
        {
            directorio = new Directorio("Carpeta");
            directorio.Nombre = "Carpeta";
            archivo = new Archivo("Archivo.doc", 30);

            directorio.AnhadeElemento(archivo);

            Assert.AreEqual(directorio.TotalArchivos, 1);
        }// NumArchivos1ElementoTest

        /// <summary>
        /// Test para comprobar que el tamanho de un directorio 
        /// con dos o mas elementos es correcto.
        /// Resultado: 30 + 1 + 1 + 30 * 0.3
        /// </summary>
        [TestMethod]
        public void Tamanho2oMasElementosTest()
        {
            archivoComprimido = new ArchivoComprimido("Comprimido1.zip");
            directorio = new Directorio("Carpeta");
            archivo = new Archivo("Archivo.doc", 30);
           
            directorio.AnhadeElemento(archivo);
            directorio.AnhadeElemento(archivoComprimido);
            archivoComprimido.AnhadeElemento(archivo);

            Assert.AreEqual(directorio.Tamanho, 41);
        }// Tamanho2oMasElementosTest

        /// <summary>
        /// Test para comprobar que el numero de archivos que 
        /// contiene un directorio con dos o mas elementos es correcto.
        /// Resultado: 2
        /// </summary>
        [TestMethod]
        public void NumArchivos2oMasElementosTest()
        {
            archivoComprimido = new ArchivoComprimido("Comprimido1.zip");
            directorio = new Directorio("Carpeta");
            archivo = new Archivo("Archivo.doc", 30);

            directorio.AnhadeElemento(archivo);
            directorio.AnhadeElemento(archivoComprimido);

            Assert.AreEqual(directorio.TotalArchivos, 2);
        }// NumArchivos2oMasElementosTest
    }// DirectorioTest
}// namespace
