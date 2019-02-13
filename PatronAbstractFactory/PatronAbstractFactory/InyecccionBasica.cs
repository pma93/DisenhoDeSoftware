using System;
using Ninject.Modules;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Inyeccion de dependencias para la opcion basica
    /// </summary>
    public class InyecccionBasica : NinjectModule
    {
        public override void Load()
        {
            Bind<Estrategia>().To<EstrategiaInternacionalGallega>();
            Bind<Impresora>().To<ImpresoraCompacta>();
        }// Load
    }// InyeccionBasica
}// namespace
