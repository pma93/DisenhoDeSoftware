using System;

//Pablo Martinez Arana
namespace PatronStrategy
{
    /// <summary>
    /// Visualizacion
    /// </summary>
    public abstract class Estrategia
    {
        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros 
        /// dependiendo de la estrategia
        /// </summary>
        /// <param name="str"> string que contiene el sistema de 
        /// ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para 
        /// la estrategia </returns>
        public abstract String ReemplazoString(String str);
    }// Visualizacion
}// namespace
