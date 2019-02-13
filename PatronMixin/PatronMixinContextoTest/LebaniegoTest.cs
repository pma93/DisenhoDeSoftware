using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronMixinContexto; 

namespace PatronMixinTest
{
    /// <summary>
    /// Clase de pruebas para un lebaniego.
    /// </summary>
    [TestClass]
    public class LebaniegoTest
    {
        /// <summary>
        /// Test para el metodo hacerCocido.
        /// </summary>
        [TestMethod]
        public void hacerCocidoTest()
        {
            Lebaniego lebaniego = new Lebaniego();
            Assert.AreEqual("Haciendo Cocido Lebaniego", lebaniego.hacerCocido());
        } //hacerCocidoTest

        /// <summary>
        /// Test para el metodo hacerOrujo.
        /// </summary>
        [TestMethod]
        public void hacerOrujoTest()
        {
            Lebaniego lebaniego = new Lebaniego();
            Assert.AreEqual("Haciendo Orujo", lebaniego.hacerOrujo());
        } //hacerOrujoTest
    } //LebaniegoTest
} //namespace
