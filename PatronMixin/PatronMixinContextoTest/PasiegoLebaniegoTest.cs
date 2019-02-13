using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronMixinContexto;

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
        public void hacerQuesadaLiebanaTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.LIEBANA);
            Assert.AreEqual("Haciendo Quesada", p.hacerQuesada());
        } //hacerQuesadaTest

        /// <summary>
        /// Test para el metodo hacerSobaos.
        /// </summary>
        [TestMethod]
        public void hacerSobaosLiebanaTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.LIEBANA);
            Assert.AreEqual("Haciendo Sobaos", p.hacerSobaos());
        } //hacerSobaosTest

        /// <summary>
        /// Test para el metodo hacerCocido.
        /// </summary>
        [TestMethod]
        public void hacerCocidoLiebanaTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.LIEBANA);
            Assert.AreEqual("Haciendo Cocido Lebaniego", p.hacerCocido());
        } //hacerCocidoTest

        /// <summary>
        /// Test para el metodo hacerOrujo.
        /// </summary>
        [TestMethod]
        public void hacerOrujoLiebanaTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.LIEBANA);
            Assert.AreEqual("Haciendo Orujo", p.hacerOrujo());
        } //hacerOrujoTest

        /// <summary>
        /// Test para el metodo hacerQuesada.
        /// </summary>
        [TestMethod]
        public void hacerQuesadaPasTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.PAS);
            Assert.AreEqual("Haciendo Quesada", p.hacerQuesada());
        } //hacerQuesadaTest

        /// <summary>
        /// Test para el metodo hacerSobaos.
        /// </summary>
        [TestMethod]
        public void hacerSobaosPasTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.PAS);
            Assert.AreEqual("Haciendo Sobaos", p.hacerSobaos());
        } //hacerSobaosTest

        /// <summary>
        /// Test para el metodo hacerCocido.
        /// </summary>
        [TestMethod]
        public void hacerCocidoPasTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.PAS);
            Assert.AreEqual("Haciendo Cocido Montañes", p.hacerCocido());
        } //hacerCocidoTest

        /// <summary>
        /// Test para el metodo hacerOrujo.
        /// </summary>
        [TestMethod]
        public void hacerOrujoPasTest()
        {
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.PAS);
            Assert.AreEqual("Haciendo Orujo", p.hacerOrujo());
        } //hacerOrujoTest
    } //PasiegoLebaniegoTest
} //namespace
