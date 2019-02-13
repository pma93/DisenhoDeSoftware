using System;

// Pablo Martinez Arana
namespace PatronStrategy
{
    /// <summary>
    /// Interfaz IElementoSistema. Representa el comportamiento de todos
    /// los elementos del sistema sparrow.
    /// </summary>
    public interface IElementoSistema
    {
        /// <summary>
        /// Propiedad nombre
        /// </summary>
        string Nombre
        {
            set; get;
        }// Nombre

        /// <summary>
        /// Propiedad tamanho
        /// </summary>
        double Tamanho
        {
            set; get;
        }// Tamanho

        /// <summary>
        /// Propiedad totalArchivos
        /// </summary>
        int TotalArchivos
        {
            get;
        }// TotalArchivos

        /// <summary>
        /// Metodo que retorna el string que contiene la impresion del elemento
        /// </summary>
        /// <param name="impresora"> impresora concreta para imprimir el elemento </param>
        /// <returns> impresion del elemento </returns>
        string Accept(Impresora impresora);
    }// IElementoSistema
}// namespace
