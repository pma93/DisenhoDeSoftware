using System;
namespace PatronMixinContexto
{
    /// <summary>
    /// Clase Lebaniego.
    /// Contiene los metodos para preparar las comidas
    /// de un Lebaniego.
    /// </summary>
    public class Lebaniego : ILebaniego
    {
        /// <summary>
        /// Metodo para hacer un cocido.
        /// </summary>
        /// <returns>String indicando que el cocido se esta haciendo.</returns>
        public virtual string hacerCocido()
        {
            return "Haciendo Cocido Lebaniego";
        } //hacerCocido

        /// <summary>
        /// Metodo para hacer un orujo.
        /// </summary>
        /// <returns>String indicando que el orujo se esta haciendo.</returns>
        public virtual string hacerOrujo()
        {
            return "Haciendo Orujo";
        } //hacerOrujo
    } //Lebaniego
} //namespace
