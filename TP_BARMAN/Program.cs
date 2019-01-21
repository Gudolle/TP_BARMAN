using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP_BARMAN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation des barman
            Barman BarmanAlcoolique = new Barman("Cocktail malibu");
            Barman BarmanNormal = new Barman("BestOfCoca");

            //Initialisation des ingrédiant
            Ingredient Menthe = new Ingredient("Menthe");
            Ingredient GlacePilee = new Ingredient("Glae Pilée");
            Ingredient Limonade = new Ingredient("Limonade");
            Ingredient CitronVert = new Ingredient("Citron Vert");
            Ingredient Orange = new Ingredient("Orange");
            Ingredient Grenadine = new Ingredient("Grenadine");

            //Ajout des ingrediant :
            BarmanAlcoolique.MesIngredients = new List<Ingredient>()
            {
                Menthe, GlacePilee, Limonade, CitronVert
            };
            BarmanNormal.MesIngredients = new List<Ingredient>()
            {
                Orange, Grenadine, GlacePilee, Menthe
            };
            
            //Lancement des thread
            Thread monThread = new Thread(new ThreadStart(BarmanAlcoolique.Run));
            Thread monThread2 = new Thread(new ThreadStart(BarmanNormal.Run));
            monThread.Start();            
            monThread2.Start();

            Console.ReadKey();
        }
    }
}
