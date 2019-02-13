using System;

//Pablo Martinez Arana
namespace PatronComposite
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
            set;get;
        }//Nombre

        /// <summary>
        /// Propiedad tamanho
        /// </summary>
        double Tamanho
        {
            set; get;
        }//Tamanho

        /// <summary>
        /// Propiedad totalArchivos
        /// </summary>
        int TotalArchivos
        {
            get;
        }//TotalArchivos
    }//IElementoSistema
}//namespace
