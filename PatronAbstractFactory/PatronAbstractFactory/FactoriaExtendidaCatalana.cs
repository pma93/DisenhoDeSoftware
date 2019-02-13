using System;

//Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Factoria concreta para la opcion de visualizacion estandar
    /// Utiliza una impresora extendida junto con la 
    /// estrategia internacional catalana
    /// </summary>
    public class FactoriaExtendidaCatalana : IFactoriaEstrategia
    {
        // Instancia de la factoria
        static FactoriaExtendidaCatalana instancia;

        /// <summary>
        /// Metodo protegido para la creacion de la factoria
        /// </summary>
        protected FactoriaExtendidaCatalana() {}

        /// <summary>
        /// Metodo estatico que permite obtener la instancia de la factoria
        /// </summary>
        /// <returns> instancia de la factoria </returns>
        public static FactoriaExtendidaCatalana GetInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoriaExtendidaCatalana();
            }
            return instancia;
        }// GetInstance

        /// <summary>
        /// Crea la estrategia de visualizacion a utilizar en esta factoria
        /// </summary>
        /// <returns> estrategia a utilizar </returns>
        public Estrategia CrearVisualizacionEstrategia()
        {
            return new EstrategiaInternacionalCatalana();
        }// CrearVisualizacionEstrategia

        /// <summary>
        /// Crea la impresora a utilizar en esta factoria
        /// </summary>
        /// <param name="estrategia"> estrategia de visualizacion 
        /// a utilizar </param>
        /// <returns> impresora creada </returns>
        ///
        /// Pre: estrategia instaceof EstrategiaInternacionalCatalana
        public Impresora CrearImpresora(Estrategia estrategia)
        {
            return new ImpresoraExtendida(estrategia);
        }// CrearImpresora
    }// FactoriaExtendidaCatalana
}// namespace
