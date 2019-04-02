using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistrzostwa_Europy
{
    class Program
    {
        static void Main(string[] args)
        {
           Basket.Generate();
           Basket.Lottery();
           Group.A1(Basket.ListA);
           Group.A2(Basket.ListA);
           Champions.ChampionA();
           Group.A1(Basket.ListB);
           Group.A2(Basket.ListB);
           Champions.ChampionB();
           Group.A1(Basket.ListC);
           Group.A2(Basket.ListC);
           Champions.ChampionC();
           Group.A1(Basket.ListD);
           Group.A2(Basket.ListD);
           Champions.ChampionD();

           Console.WriteLine("Press any key to go to the quarterfinals stage.");
           Console.ReadKey();

           Champions.Quarter();
           Console.WriteLine("Press any key to go to the semifinals stage.");
           Console.ReadKey();
           Champions.Semis();
           Console.WriteLine("Press any key to go to the final stage.");
           Console.ReadKey();
           Champions.Finals();


        }
    }
}
