using System;

//Pablo Martinez Arana
namespace PatronObserver
{
    /// <summary>
    /// IElementoSistemaObserver. Representa el comportamiento de los elementos
    /// que son observadores
    /// </summary>
    public interface IElementoSistemaObserver
    {
        /// <summary>
        /// Actualiza la informacion del elemento con la nueva 
        /// informacion.
        /// </summary>
        void Update(ElementoSistema e);
    }// IElementoSistemaObserver
}// namespace
