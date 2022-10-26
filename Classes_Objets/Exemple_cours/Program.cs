using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_cours
{
    class Program
    {
                static void Main(string[] args)
        {
            // Déclarer l'objet. 
            Person hasna;
            // Instancier l'objet. 
            hasna = new Person();
            
            // Déclarer et instancier l'objet Daniel. 
            Person daniel = new Person();
            

            // Déclarer et instantier l'objet Patrick avec un constructeur à deux paramètres.
            Person patrick = new Person("Roy", "Patrick");

            // Déclarer et instancier au moyen d'un constructeur à trois paramètres.
            Person isabelle = new Person("Roy", "Isabelle","Gatineau");
            
            // Modifier l'attribut nom au moyen de la propriété Nom (Setter).
            Console.WriteLine("Le nom de famille d'Isabelle est "+isabelle.Nom+".");
            // Propriété Nom, Setter
            isabelle.Nom = "Couillard";
            // Afficher l'attribut nom au moyen de la propriété Nom (Getter).
            Console.WriteLine("Après la modification de la propriété Nom, " +
                "le nom de famille d'Isabelle est devenu "+isabelle.Nom+".");
            Console.ReadKey();


        }
    }
}
