using System;

// Pablo Martinez Arana
namespace PatronStrategy
{
    /// <summary>
    /// Programa de pruebas.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un directorio de prueba
            Directorio directorio1 = new Directorio("Lasaña áéíóú");

            // Creamos una impresora compacta de prueba
            ImpresoraCompacta comp = new ImpresoraCompacta();

            // Creamos varios strings para poder realizar el reemplazo
            String[] castellano = { "ñ", "á", "é", "í", "ó", "ú" };
            String[] gallego = { "nh", "á", "é", "í", "ó", "ú" };
            String[] catalan = { "ny", "á", "é", "í", "ó", "ú" };
            String[] internacionalGallego = { "nh", "a", "e", "i", "o", "u" };
            String[] internacionalCatalan = { "ny", "a", "e", "i", "o", "u" };

            // Reemplazamos la letra y las vocales atendiendo a la estrategia
            // que queremos visualizar pasando la funcion como parametro
            String result1 = comp.ImprimirDirectorio(directorio1, (str) =>{
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });

            String result2 = comp.ImprimirDirectorio(directorio1, (str) => {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], gallego[i]);
                }
                return str;
            });

            String result3 = comp.ImprimirDirectorio(directorio1, (str) => {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });

            String result4 = comp.ImprimirDirectorio(directorio1, (str) => {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });

            String result5 = comp.ImprimirDirectorio(directorio1, (str) => {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });

            // Visualizamos cada resultado
            Console.Out.WriteLine("-------- Impresora Compacta --------\n");
            Console.Out.WriteLine("Castellano: \n" + result1);
            Console.Out.WriteLine("Gallego: \n" + result2);
            Console.Out.WriteLine("Catalan: \n" + result3);
            Console.Out.WriteLine("Internacional Gallego: \n" + result4);
            Console.Out.WriteLine("Internacional Catalan: \n" + result5);
            Console.Out.WriteLine("------------------------------------\n");
        }// Main
    }// Program
}// namespace
