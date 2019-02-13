using System;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Factoria concreta para la opcion de visualizacion extendida gallega
    /// Utiliza una impresora extendida junto con la 
    /// estrategia internacional gallega
    /// </summary>
    public class FactoriaExtendidaGallega : IFactoriaEstrategia
    {
        // Instancia de la factoria
        static FactoriaExtendidaGallega instancia;

        /// <summary>
        /// Metodo protegido para la creacion de la factoria
        /// </summary>
        protected FactoriaExtendidaGallega() {}

        /// <summary>
        /// Metodo estatico que permite obtener la instancia de la factoria
        /// </summary>
        /// <returns> instancia de la factoria </returns>
        public static FactoriaExtendidaGallega GetInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoriaExtendidaGallega();
            }
            return instancia;
        }// FactoriaExtendidaGallega

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
        /// <param name="estrategia"> estrategia de visualizacion 
        /// a utilizar </param>
        /// <returns> impresora creada </returns>
        ///
        /// Pre: estrategia instaceof EstrategiaInternacionalGallega
        public Impresora CrearImpresora(Estrategia estrategia)
        {
            return new ImpresoraExtendida(estrategia);
        }// CrearImpresora
    }// FactoriaExtendidaGallega
}// namespace
