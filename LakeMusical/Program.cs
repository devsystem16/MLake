using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakeMusical
{
    class Program
    {
        static void Main(string[] args)
        {
             
            string sonidoareproducir = "";
            Console.WriteLine("Ingrese el sonido que desea buscar");
            sonidoareproducir = Console.ReadLine().ToLower();
            Console.WriteLine("Cancion");
            foreach (string a in Cancionescogida(sonidoareproducir))
            {
               
                Console.WriteLine(a);
            }

            Console.ReadKey();

            }
        public static Boolean Verificarsiexiste(string []arreglo,string valor)
        {
            return arreglo.Contains(valor);
        
        }

        public static string[] Arregloseleccionado(string valoracomparar)
        {
            string[] song1 = { "brr", "fiu", "cric-cric", "brah" };
            string[] song2 = { "pep", "birip", "trri-trri", "croac" };
            string[] song3 = { "bri-bri", "plop", "cric-cric", "brrah" };
            string[] arregloatrabajar = new string[4];

            if(Verificarsiexiste(song1, valoracomparar) == true)
                arregloatrabajar = song1;
            else if (Verificarsiexiste(song2, valoracomparar) == true)
                arregloatrabajar = song2;
            else if (Verificarsiexiste(song3, valoracomparar) == true)
                arregloatrabajar = song3;
            
          
            return arregloatrabajar;
        }
        public static List<string> Cancionescogida(string palabras)
        { 
            List<string>cancionfinal= new List<string>();       
            for (int i = 0; i < Arregloseleccionado(palabras).Length; i++)
                if (Arregloseleccionado(palabras)[i] == palabras)
                for (int j = i; j < Arregloseleccionado(palabras).Length; j++)
                        cancionfinal.Add(Arregloseleccionado(palabras)[j]);
            return cancionfinal;
        }

    }
}



  
    

