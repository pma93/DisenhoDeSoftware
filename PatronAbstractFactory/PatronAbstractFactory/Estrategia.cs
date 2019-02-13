using System;

//Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Visualizacion
    /// </summary>
    public abstract class Estrategia : ICloneable
    {
        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros 
        /// dependiendo de la estrategia
        /// </summary>
        /// <param name="str"> string que contiene el sistema de 
        /// ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para 
        /// la estrategia escogida </returns>
        public abstract String ReemplazoString(String str);

        /// <summary>
        /// Metodo que permite obtener una copia de la estretegia
        /// </summary>
        /// <returns> clon de la estrategia de visualizacion</returns>
        public abstract object Clone();
    }// Visualizacion
}// namespace
