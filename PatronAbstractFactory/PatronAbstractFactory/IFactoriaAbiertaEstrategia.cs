using System;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Interfaz concreta para la factoria abierta.
    /// </summary>
    public interface IFactoriaAbiertaEstrategia : IFactoriaEstrategia
    {
        /// <summary>
        /// Propiedad estrategia
        /// </summary>
        Estrategia Estrategia
        { 
            set; 
        }// Estrategia
    }// IFactoriaAbiertaVisualizacion
}// namespace
