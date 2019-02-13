using System;

//Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Estrategia: Estrategia Castellano
    /// </summary>
    public class EstrategiaCastellana : Estrategia
    {
        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros 
        /// para la estrategia castellano
        /// </summary>
        /// <param name="str"> string que contiene el sistema de ficheros 
        /// a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la 
        /// estrategia castellano </returns>
        public override String ReemplazoString(String str)
        {
            return str;
        }// ReemplazoString

        /// <summary>
        /// Metodo que permite obtener una copia de la estretegia
        /// </summary>
        /// <returns> clon de la estrategia de visualizacion</returns>
        public override object Clone()
        {
            return MemberwiseClone();
        }// Clone
    }// VisualizacionCastellano
}// namespace
