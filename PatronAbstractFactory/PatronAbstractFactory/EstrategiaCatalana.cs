using System;

//Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Estrategia: Estrategia Catalana
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
        }// ReemplazoString

        /// <summary>
        /// Metodo que permite obtener una copia de la estretegia
        /// </summary>
        /// <returns> clon de la estrategia de visualizacion</returns>
        public override object Clone()
        {
            return MemberwiseClone();
        }// Clone
    }// VisualizacionCatalana
}// namespace
