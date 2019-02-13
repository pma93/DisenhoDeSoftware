using System;
namespace PatronMixin
{
    /// <summary>
    /// Clase PasiegoLebaniego.
    /// Raza formada por la union de los pasiegos
    /// y los lebaniegos.
    /// </summary>
    public class PasiegoLebaniego : IPasiego, ILebaniego
    {
        ILebaniego lebaniegoMixed = new Lebaniego();
        IPasiego pasiegoMixed = new Pasiego();

        /// <summary>
        /// Metodo para hacer un cocido.
        /// </summary>
        /// <returns>String indicando que el cocido se esta haciendo.</returns>
        public virtual string hacerCocido()
        {
            return lebaniegoMixed.hacerCocido();
        } //hacerCocido

        /// <summary>
        /// Metodo para hacer un orujo.
        /// </summary>
        /// <returns>String indicando que el orujo se esta haciendo.</returns>
        public virtual string hacerOrujo()
        {
            return lebaniegoMixed.hacerOrujo();
        } //hacerOrujo

        /// <summary>
        /// Metodo para hacer una quesada.
        /// </summary>
        /// <returns>String indicando que la quesada se esta haciendo.</returns>
        public virtual string hacerQuesada()
        {
            return pasiegoMixed.hacerQuesada();
        } //hacerQuesada

        /// <summary>
        /// Metodo para hacer unos sobaos.
        /// </summary>
        /// <returns>String indicando que los sobaos se estan haciendo.</returns>
        public virtual string hacerSobaos()
        {
            return pasiegoMixed.hacerSobaos();
        } //hacerSobaos
    } //PasiegoLebaniego
} //namespace
