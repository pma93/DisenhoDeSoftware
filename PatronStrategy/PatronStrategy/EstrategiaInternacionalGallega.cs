using System;

//Pablo Martinez Arana
namespace PatronStrategy
{
    /// <summary>
    /// Visualizacion: Estrategia Internacional Gallega
    /// </summary>
    public class EstrategiaInternacionalGallega : Estrategia
    {
        // String de reemplazo para la estrategia internacional gallega
        const String stringDeReemplazo = "nh";

        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para 
        /// la estrategia internacional gallega
        /// </summary>
        /// <param name="str"> string conteniendo el sistema de ficheros a 
        /// utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia 
        /// internacional gallega </returns>
        public override String ReemplazoString(String str)
        {
            str = str.Replace("ñ", stringDeReemplazo);
            str = str.Replace("á", "a");
            str = str.Replace("ú", "u");
            str = str.Replace("í", "i");
            str = str.Replace("ó", "o");
            str = str.Replace("é", "e");

            return str;
        }// visualizacion
    }// VisualizacionInternacionalGallega
}// namespace
