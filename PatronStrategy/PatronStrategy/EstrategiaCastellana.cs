using System;

//Pablo Martinez Arana
namespace PatronStrategy
{
    /// <summary>
    /// Visualizacion: Estrategia Castellano
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
        }// visualizacion
    }// VisualizacionCastellano
}// namespace
