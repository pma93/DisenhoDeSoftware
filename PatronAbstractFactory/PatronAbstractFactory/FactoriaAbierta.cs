using System;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Factoria concreta para la opcion de visualizacion personalizada
    /// Utiliza una impresora extendida junto con la 
    /// estrategia personalizada establecida por el usuario
    /// </summary>
    public class FactoriaAbierta : IFactoriaAbiertaEstrategia
    {
        // Instancia de la factoria
        static FactoriaAbierta instancia;
        static Estrategia estrategia;

        /// <summary>
        /// Metodo protegido para la creacion de la factoria
        /// </summary>
        protected FactoriaAbierta() 
        {
            estrategia = new YourOcre();
        }

        /// <summary>
        /// Metodo estatico que permite obtener la instancia de la factoria
        /// </summary>
        /// <returns> instancia de la factoria </returns>
        public static FactoriaAbierta GetInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoriaAbierta();
            }
            return instancia;
        }// GetInstance

        /// <summary>
        /// Propiedad estrategia
        /// </summary>
        public Estrategia Estrategia
        {
            // Pre: value != null
            set
            {
                estrategia = value;
            }// set
            // Post: estrategia == vale
        }// Estrategia
       
        /// <summary>
        /// Crea la estrategia de visualizacion a utilizar en esta factoria
        /// </summary>
        /// <returns> estrategia a utilizar </returns>
        public Estrategia CrearVisualizacionEstrategia()
        {
            return (Estrategia)estrategia.Clone();
        }// CrearVisualizacionEstrategia

        /// <summary>
        /// Crea la impresora a utilizar en esta factoria
        /// </summary>
        /// <param name="estrategia"> estrategia de visualizacion a utilizar </param>
        /// <returns> impresora creada </returns>
        ///
        public Impresora CrearImpresora(Estrategia estrategia)
        {
            return new ImpresoraExtendida(estrategia);
        }// CrearImpresora
    }// FactoriaAbierta
}// namespace
