using System;
using Ninject.Modules;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Inyeccion de dependencias para la opcion extendida catalana
    /// </summary>
    public class InyeccionExtendidaCatalana : NinjectModule
    {
        public override void Load()
        {
            Bind<Estrategia>().To<EstrategiaInternacionalCatalana>();
            Bind<Impresora>().To<ImpresoraExtendida>();
        }// Load
    }// InyeccionExtendidaCatalana
}// namespace
