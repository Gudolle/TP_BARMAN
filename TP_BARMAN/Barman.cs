using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP_BARMAN
{
    //Mutex
    class Barman 
    {
        public string Name { get; private set; }
        public bool IsFinish { get; private set; }

        public List<Ingredient> MesIngredients { get; set; }

        public Barman(string _name) => Name = _name;

        public void Run() {
            IsFinish = true;
            while (IsFinish)
            {
                Console.WriteLine("Préparation d'un {0}", Name);
                MesIngredients.ForEach(x => x.prendre(Name));
                Console.WriteLine("Tout les elements sont pris pour {0}", Name);
                Thread.Sleep(100);
                Console.WriteLine("Fin du cocktail, remise en libre service des ingrediant");
                MesIngredients.ForEach(x => x.poser());
                Console.WriteLine("Fin du cocktail pour {0}", Name);
                Thread.Sleep(100);
            }
        }
    }
}
