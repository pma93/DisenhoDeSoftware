using System;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Interfaz que soporta la creación de visitantes y 
    /// estrategias concretas
    /// </summary>
    public interface IFactoriaEstrategia
    {
        /// <summary>
        /// Crea la visualizacion con la estrategia indicada
        /// </summary>
        /// <returns> visualizacion con la estrategia creada </returns>
         Estrategia CrearVisualizacionEstrategia();

        /// <summary>
        /// Crea la impresora
        /// </summary>
        /// <param name="estrategia"> Estrategia a utilizar para la 
        /// visualizacion del sistema de ficheros </param>
        /// <returns> impresora creada </returns>
         Impresora CrearImpresora(Estrategia estrategia);
    }// FactoriaAbstractaVisualizacion
}// namespace
