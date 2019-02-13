using System;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Factoria concreta para la opcion de visualizacion basica
    /// Utiliza una impresora compacta junto con la 
    /// estrategia internacional gallega
    /// </summary>
    public class FactoriaBasica : IFactoriaEstrategia
    {
        // Instancia de la factoria
        static FactoriaBasica instancia;

        /// <summary>
        /// Metodo protegido para la creacion de la factoria
        /// </summary>
        protected FactoriaBasica() {}

        /// <summary>
        /// Metodo estatico que permite obtener la instancia de la factoria
        /// </summary>
        /// <returns> instancia de la factoria </returns>
        public static FactoriaBasica GetInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoriaBasica();
            }
            return instancia;
        }// GetInstance

        /// <summary>
        /// Crea la estrategia de visualizacion a utilizar en esta factoria
        /// </summary>
        /// <returns> estrategia a utilizar </returns>
        public Estrategia CrearVisualizacionEstrategia()
        {
            return new EstrategiaInternacionalGallega();
        }// CrearVisualizacionEstrategia

        /// <summary>
        /// Crea la impresora a utilizar en esta factoria
        /// </summary>
        /// <param name="estrategia"> estrategia de visualizacion a utilizar </param>
        /// <returns> impresora creada </returns>
        ///
        /// Pre: estrategia instaceof EstrategiaInternacionalGallega
        ///
        public Impresora CrearImpresora(Estrategia estrategia)
        {
            return new ImpresoraCompacta(estrategia);
        }// CrearImpresora
    }// FactoriaBasica
}// namespace
