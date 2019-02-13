using System;
namespace PatronMixin
{
    /// <summary>
    /// Interfaz IPasiego.
    /// Contiene los metodos para preparar las 
    /// comidas de un pasiego.
    /// </summary>
    public class Pasiego : IPasiego
    {
        /// <summary>
        /// Metodo para hacer una quesada.
        /// </summary>
        /// <returns>String indicando que la quesada se esta haciendo.</returns>
        public string hacerQuesada()
        {
            return "Haciendo Quesada";
        } //hacerQuesada

        /// <summary>
        /// Metodo para hacer unos sobaos.
        /// </summary>
        /// <returns>String indicando que los sobaos se estan haciendo.</returns>
        public string hacerSobaos()
        {
            return "Haciendo Sobaos";
        } //hacerSobaos
    } //Pasiego
} //namespace
