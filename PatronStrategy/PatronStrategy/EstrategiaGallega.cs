using System;

//Pablo Martinez Arana
namespace PatronStrategy
{
    /// <summary>
    /// Visualizacion: Estrategia Gallega
    /// </summary>
    public class EstrategiaGallega : Estrategia
    {
        // String de reemplazo para la estrategia gallega
        const String stringDeReemplazo = "nh";

        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para 
        /// la estrategia gallega
        /// </summary>
        /// <param name="str"> string que contiene el sistema de ficheros 
        /// a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia 
        /// gallega </returns>
        public override String ReemplazoString(String str)
        {
            return str.Replace("ñ", stringDeReemplazo);
        }// visualizacion
    }// VisualizacionGallega
}// namespace
