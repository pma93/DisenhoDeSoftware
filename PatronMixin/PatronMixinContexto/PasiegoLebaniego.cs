using System;
namespace PatronMixinContexto
{
    /// <summary>
    /// Clase PasiegoLebaniego.
    /// Raza formada por la union de los pasiegos
    /// y los lebaniegos.
    /// </summary>
    public class PasiegoLebaniego : IPasiego, ILebaniego
    {
        ILebaniego lebaniegoMixed = new Lebaniego();
        IPasiego pasiegoMixed = new Pasiego();
        //Indica el contexto del PasiegoLebaniego
        TipoContexto contexto;

        /// <summary>
        /// Propiedad del contexto.
        /// </summary>
        public TipoContexto Contexto { 
            get
            {
                return contexto;
            } 
            set
            {
                contexto = value;
            } 
        }

        /// <summary>
        /// Asigna un contexto al PasiegoLebaniego.
        /// </summary>
        /// <param name="tipoContexto">Tipo contexto.</param>
        public PasiegoLebaniego(TipoContexto tipoContexto)
        {
            this.contexto = tipoContexto;
        }

        /// <summary>
        /// Metodo para hacer un cocido.
        /// </summary>
        /// <returns>String indicando que el cocido se esta haciendo.</returns>
        public string hacerCocido()
        {
            if(contexto == TipoContexto.LIEBANA) {
                return lebaniegoMixed.hacerCocido();
            }
            else {
                return pasiegoMixed.hacerCocido();
            }
        } //hacerCocido

        /// <summary>
        /// Metodo para hacer un orujo.
        /// </summary>
        /// <returns>String indicando que el orujo se esta haciendo.</returns>
        public string hacerOrujo()
        {
            return lebaniegoMixed.hacerOrujo();
        } //hacerOrujo

        /// <summary>
        /// Metodo para hacer una quesada.
        /// </summary>
        /// <returns>String indicando que la quesada se esta haciendo.</returns>
        public string hacerQuesada()
        {
            return pasiegoMixed.hacerQuesada();
        } //hacerQuesada

        /// <summary>
        /// Metodo para hacer unos sobaos.
        /// </summary>
        /// <returns>String indicando que los sobaos se estan haciendo.</returns>
        public string hacerSobaos()
        {
            return pasiegoMixed.hacerSobaos();
        } //hacerSobaos
    } //PasiegoLebaniego
} //namespace
