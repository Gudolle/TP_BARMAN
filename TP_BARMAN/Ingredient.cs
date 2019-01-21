using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP_BARMAN
{
    class Ingredient
    {
        public string Name { get; private set; }

        private Mutex Wait { get; set; }
        public Ingredient(string _name) {
            Name = _name;
            Wait = new Mutex();
        }

        public void prendre(string Cocktail)
        {
            Console.WriteLine("=>Récupération de l'ingrédiant {0} pour {1}", Name, Cocktail);
            Wait.WaitOne();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("&&Récupération réussi l'ingrédiant {0} pour {1}", Name, Cocktail);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void poser()
        {
            Wait.ReleaseMutex();
            Console.WriteLine("||Remise de {0}", Name);
        }
    }
}
