using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronObserver
{
    static class Program
    {
        static ElementoSistema CrearSistemaEjemplo()
        {
            Directorio dRaiz = new Directorio("Raiz");

            Directorio dVacio = new Directorio("Directorio Vacio");

            dRaiz.AnhadeElemento(dVacio);

            Directorio dUnico = new Directorio("Directorio Con Archivo Unico");
            Archivo f01 = new Archivo("foto001.jpg", 200);
            dUnico.AnhadeElemento(f01);

            dRaiz.AnhadeElemento(dUnico);

            Directorio d01 = new Directorio("Directorio Vacio En Archivo Comprimido");
            Archivo f02 = new Archivo("foto003.jpg", 200);
            EnlaceDir e01 = new EnlaceDir(f01);

            ArchivoComprimido ccSimple = new ArchivoComprimido("ccSimple.zip");
            ccSimple.AnhadeElemento(f02);
            ccSimple.AnhadeElemento(e01);
            ccSimple.AnhadeElemento(d01);

            Directorio dComprimido = new Directorio("Directorio Con Archivo Comprimido Simple");

            Archivo f03 = new Archivo("foto002.jpg", 200);
            EnlaceDir e02 = new EnlaceDir(f01);

            dComprimido.AnhadeElemento(f03);
            dComprimido.AnhadeElemento(e02);
            dComprimido.AnhadeElemento(ccSimple);

            dRaiz.AnhadeElemento(dComprimido);

            Archivo f04 = new Archivo("foto007.jpg", 200);
            ArchivoComprimido ccAnidada = new ArchivoComprimido("ccAnidada.zip");
            Archivo f05 = new Archivo("foto008.jpg", 200);

            ArchivoComprimido ccCompuesto = new ArchivoComprimido("ccComplejo.zip");
            ccCompuesto.AnhadeElemento(f05);

            Archivo f06 = new Archivo("foto005", 200);
            Archivo f07 = new Archivo("foto006", 200);

            Directorio dComprimidoCompuesto = new Directorio("Directorio con Archivo Comprimido Complejo");
            dComprimidoCompuesto.AnhadeElemento(f06);
            dComprimidoCompuesto.AnhadeElemento(f07);
            dComprimidoCompuesto.AnhadeElemento(ccCompuesto);

            Archivo f08 = new Archivo("foto004.jpg", 200);
            EnlaceDir e03 = new EnlaceDir(ccSimple);
            EnlaceDir e04 = new EnlaceDir(dVacio);

            Directorio dMultinivel = new Directorio("Directorio con Directorio Anidado");

            dMultinivel.AnhadeElemento(f08);
            dMultinivel.AnhadeElemento(e03);
            dMultinivel.AnhadeElemento(e04);
            dMultinivel.AnhadeElemento(dComprimidoCompuesto);

            dRaiz.AnhadeElemento(dMultinivel);

            return dRaiz;
        } // crearSistemaEjemplo

        /// <summary>
        ///     Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializamos los aspectos básicos del sistema 
            // de ventanas
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creamos un nuevo gestor de multiformularios
            MultiWindowRunner runner = new MultiWindowRunner();

            // Creamos un sistema de ficheros ejemplo
            ElementoSistema fs = CrearSistemaEjemplo();

            // Creamos un nuevo visor de sistema de archivos Sparrow
            FileExplorerView fev = new FileExplorerView(runner);
            fev.SparrowFileSystem = fs;

            // Creamos un nuevo editor de nombres para los 
            // elementos del sistema de archivos Sparrow anterior
            FileNameEditor fne = new FileNameEditor(runner);
            fne.SparrowFileSystem = fs;

            // Registramos ambos formularios en el gestor de formularios
            runner.registerForm(fne);
            runner.registerForm(fev);

            // Ejecutamos los formularios
            runner.run();
        } // main
    } // Program
}
