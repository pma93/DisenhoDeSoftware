using System;
namespace PatronMixin
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
        public string hacerCocido()
        {
            return "Haciendo Cocido";
        } //hacerCocido

        /// <summary>
        /// Metodo para hacer un orujo.
        /// </summary>
        /// <returns>String indicando que el orujo se esta haciendo.</returns>
        public string hacerOrujo()
        {
            return "Haciendo Orujo";
        } //hacerOrujo
    } //Lebaniego
} //namespace
