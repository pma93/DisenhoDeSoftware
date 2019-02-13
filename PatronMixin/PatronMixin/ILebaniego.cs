using System;
namespace PatronMixin
{
    /// <summary>
    /// Interfaz ILebaniego
    /// Contiene los metodos para preparar las comidas
    /// de un Lebaniego.
    /// </summary>
    public interface ILebaniego
    {
        /// <summary>
        /// Metodo para hacer un cocido.
        /// </summary>
        /// <returns>String indicando que el cocido se esta haciendo.</returns>
        String hacerCocido();

        /// <summary>
        /// Metodo para hacer un orujo.
        /// </summary>
        /// <returns>String indicando que el orujo se esta haciendo.</returns>
        String hacerOrujo();
    } //ILebaniego
} //namespace
