using System;
using System.Collections.Generic;

// Pablo Martinez Arana
namespace PatronObserver
{
    /// <summary>
    /// ArchivoComprimido
    /// </summary>
    public class ArchivoComprimido : GrupoElementos
    {
        //Tamanho de la definicion de un nuevo archivo comprimido(KB)
        const int TAM_DEF = 1;
        //Factor de compresion del sistema Sparrow
        const double FACTOR_COMPRESION = 0.3;
        //Numero de archivos que contiene el elemento
        const int NUM_ARCHIVOS = 1;

        /// <summary>
        /// Inicializa la clase ArchivoComprimido
        /// con un conjunto de elemntos vacio, y le asigna
        /// un nombre.
        /// <param name="nombre">Nombre del elemento que se crea.</param>
        /// </summary>
        public ArchivoComprimido(String nombre) : base(nombre)
        {
            elementos = new HashSet<ElementoSistema>();
        }// ArchivoComprimido

        /// <summary>
        /// Propiedad TotalArchivos.
        /// </summary>
        public override int TotalArchivos
        {
            get
            {
                return NUM_ARCHIVOS;
            }// get
        }// TotalArchivos

        /// <summary>
        /// Propiedad Tamanho.
        /// </summary>
        public override double Tamanho
        {
            get
            {
                double total = 0.0;
                //Se suma el tamanho de los elementos dentro del directorio
                foreach (ElementoSistema es in elementos)
                {
                    total += es.Tamanho;
                }
                return (total * FACTOR_COMPRESION) + TAM_DEF;
            }// get
            // Post: total >=0.0

            set 
            { 
            }// set
        }// Tamanho

        /// <summary>
        /// Devuelve los elementos que tiene el archivo comprimido. 
        /// </summary>
        public override ISet<ElementoSistema> Archivos
        {
            get
            {
                return elementos;
            }// get
        }// Archivos
    }// ArchivoComprimido
}// namespace
