using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cex5
{
    class Program
    {
        static void Main(string[] args)
        {
         string[] fujita = new string[] {"Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres.", "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés.", "Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées.", "Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts.", "Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances.", "Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu »."};
         Console.WriteLine("Veuillez indiquez le type de tornade :");
         string type = Console.ReadLine();
         int ind = int.Parse(type.Substring(1,1));        
         Console.WriteLine(fujita[ind]);
         Console.ReadKey();
        } // ajouter des conditions else if
        /* Méthode du switch case (selon le cas)
        switch
        {   
            case :
                break;
            default :
                break;
         }
        

}
}
