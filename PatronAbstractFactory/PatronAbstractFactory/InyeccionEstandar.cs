using System;
using Ninject.Modules;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Inyeccion de dependencias para la opcion estandar
    /// </summary>
    public class InyeccionEstandar : NinjectModule
    {
        public override void Load()
        {
            Bind<Estrategia>().To<EstrategiaCastellana>();
            Bind<Impresora>().To<ImpresoraExtendida>();
        }// Load
    }// InyeccionEstandar
}// namespace
