using System;
using System.Collections.Generic;

// Pablo Martinez Arana
namespace PatronObserver
{
    /// <summary>
    /// Directorio del sistema de ficheros
    /// </summary>
    public class Directorio : GrupoElementos
    {
        //Tamanho de la definicion de un nuevo directorio(KB)
        const int TAM_DEF = 1;

        /// <summary>
        /// Inicializa la clase directorio con un
        /// conjunto de elementos vacio, y le asigna un nombre.
        /// <param name="nombre">Nombre del elemento que se crea.</param>
        /// </summary>
        public Directorio(String nombre) : base(nombre)
        {
            elementos = new HashSet<ElementoSistema>();
        }// Directorio

        /// <summary>
        /// Propiedad TotalArchivos.
        /// </summary>
        public override int TotalArchivos
        {
            get
            {
                int total = 0;
                //Se suma el numero de ficheros contenidos en el directorio
                foreach (ElementoSistema es in elementos)
                {
                    total += es.TotalArchivos;
                }
                return total;
            }// get
            // Post: total >=0
        }// TotalArchivos

        /// <summary>
        /// Propiedad Tamanho.
        /// </summary>
        public override double Tamanho
        {
            get
            {
                double total = TAM_DEF;
                //Se suma el tamanho de los elementos dentro del directorio
                foreach (ElementoSistema es in elementos)
                {
                    total += es.Tamanho;
                }
                return total;
            }// get
            // Post: total >=1.0

            set 
            { 
            }// set
        }// Tamanho

        /// <summary>
        /// Devuelve los elementos que tiene el directorio.
        /// </summary>
        public override ISet<ElementoSistema> Archivos
        {
            get
            {
                return elementos;
            }// get
        }// Archivos
    }// Directorio
}// namespace
