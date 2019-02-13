using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronMixin;

namespace PatronMixinTest
{
    /// <summary>
    /// Clase de pruebas para un PasiegoLebaniego.
    /// </summary>
    [TestClass]
    public class PasiegoLebaniegoTest
    {
        /// <summary>
        /// Test para el metodo hacerQuesada.
        /// </summary>
        [TestMethod]
        public void hacerQuesadaTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego();
            Assert.AreEqual("Haciendo Quesada", p.hacerQuesada());
        } //hacerQuesadaTest

        /// <summary>
        /// Test para el metodo hacerSobaos.
        /// </summary>
        [TestMethod]
        public void hacerSobaosTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego();
            Assert.AreEqual("Haciendo Sobaos", p.hacerSobaos());
        } //hacerSobaosTest

        /// <summary>
        /// Test para el metodo hacerCocido.
        /// </summary>
        [TestMethod]
        public void hacerCocidoTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego();
            Assert.AreEqual("Haciendo Cocido", p.hacerCocido());
        } //hacerCocidoTest

        /// <summary>
        /// Test para el metodo hacerOrujo.
        /// </summary>
        [TestMethod]
        public void hacerOrujoTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego();
            Assert.AreEqual("Haciendo Orujo", p.hacerOrujo());
        } //hacerOrujoTest
    } //PasiegoLebaniegoTest
} //namespace
