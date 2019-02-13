using System;
namespace PatronMixinContexto
{
    /// <summary>
    /// Interfaz IPasiego.
    /// Contiene los metodos para preparar las 
    /// comidas de un pasiego.
    /// </summary>
    public interface IPasiego
    {
        /// <summary>
        /// Metodo para hacer unos sobaos.
        /// </summary>
        /// <returns>String indicando que los sobaos se estan haciendo.</returns>
        String hacerSobaos();

        /// <summary>
        /// Metodo para hacer una quesada.
        /// </summary>
        /// <returns>String indicando que la quesada se esta haciendo.</returns>
        String hacerQuesada();

        /// <summary>
        /// Metodo para hacer un cocido.
        /// </summary>
        /// <returns>String indicando que el cocido se esta haciendo.</returns>
        String hacerCocido();
    } //IPasiego
} //namespace
