using System;

//Pablo Martinez Arana
namespace PatronStrategy
{
    /// <summary>
    /// Visualizacion: Estrategia Catalana
    /// </summary>
    public class EstrategiaCatalana : Estrategia
    {
        // String de reemplazo para la estrategia catalana
        const String stringDeReemplazo = "ny";

        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para 
        /// la estrategia catalana
        /// </summary>
        /// <param name="str"> string que contiene el sistema de ficheros 
        /// a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia 
        /// catalana </returns>
        public override String ReemplazoString(String str)
        {
            return str.Replace("ñ", stringDeReemplazo);
        }// visualizacion
    }// VisualizacionCatalana
}// namespace
