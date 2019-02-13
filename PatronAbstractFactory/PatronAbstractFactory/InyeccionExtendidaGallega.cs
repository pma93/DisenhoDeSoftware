using System;
using Ninject.Modules;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Inyeccion de dependencias para la opcion extendida gallega
    /// </summary>
    public class InyeccionExtendidaGallega : NinjectModule
    {
        public override void Load()
        {
            Bind<Estrategia>().To<EstrategiaInternacionalGallega>();
            Bind<Impresora>().To<ImpresoraExtendida>();
        }// Load
    }// InyeccionExtendidaGallega
}// namespace
