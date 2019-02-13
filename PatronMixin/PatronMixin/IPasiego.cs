using System;
namespace PatronMixin
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
    } //IPasiego
} //namespace
