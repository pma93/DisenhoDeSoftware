using System;
using System.Collections.Generic;

// Pablo Martinez Arana
namespace PatronObserver
{
    /// <summary>
    /// ElementoSistema. Representa el comportamiento de todos
    /// los elementos del sistema sparrow.
    /// </summary>
    public abstract class ElementoSistema
    {
        //Lista de observadores
        protected IList<IElementoSistemaObserver> observers;

        /// <summary>
        /// Propiedad nombre
        /// </summary>
        public virtual string Nombre
        {
            set; get;
        }// Nombre

        /// <summary>
        /// Propiedad tamanho
        /// </summary>
        public virtual double Tamanho
        {
            set; get;
        }// Tamanho

        /// <summary>
        /// Propiedad totalArchivos
        /// </summary>
        public virtual int TotalArchivos
        {
            get;
        }// TotalArchivos

        /// <summary>
        /// Devuelve los elementos que contiene un elemento del sistema sparrow.
        /// </summary>
        public virtual ISet<ElementoSistema> Archivos
        {
            get;
        }// Archivos 

        /// <summary>
        /// Notifica el cambio de informacion de un elemento.
        /// </summary>
        protected void Notify()
        {
            foreach (IElementoSistemaObserver elementoSistemaObserver in observers)
            {
                elementoSistemaObserver.Update(this);
            }
        }// Notify

        /// <summary>
        /// Anhade un observador a la lista
        /// </summary>
        /// <param name="elementoSistemaObserver">Elemento sistema observer.</param>
        public void AnhadeObserver(IElementoSistemaObserver elementoSistemaObserver) 
        {
            observers.Add(elementoSistemaObserver);
        }// AnhadeObserver

        /// <summary>
        /// Elimina un observador de la lista.
        /// </summary>
        /// <param name="elementoSistemaObserver">Elemento sistema observer.</param>
        public void EliminaObserver(IElementoSistemaObserver elementoSistemaObserver) 
        {
            observers.Remove(elementoSistemaObserver);
        }// EliminaObserver
    }// ElementoSistema
}// namespace
