using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_cours
{
    // Définir la classe Person.
    public class Person
    {
        //Déclarer les attributs privés.
        private string nom;
        private string prenom;
        private string ville;

        // Déclarer les propriétés.

        public string Nom
        {
            get { return nom; }
            set { nom = value; }

        }

        // Définir le constructeur sans paramètres de la classe Person.
        public Person()
        {
            Console.WriteLine("Création d'une nouvelle personne.");

        }

        // Définir le constructeur avec deux paramètres - Surcharger le constructeur-.
        public Person(string p_nom, string p_prenom)
        {
            Console.WriteLine("Création d'une nouvelle personne qui se nomme "
                    + p_prenom + " " + p_nom+".");
        }

        // Définir un constructeur avec trois paramètres - Surcharger le constructeur-.
        public Person(string p_nom, string p_prenom, string p_ville)
        {
            this.nom = p_nom;
            this.prenom = p_nom;
            this.ville = p_ville;
            Console.WriteLine("Création d'une nouvelle personne qui se nomme "
               + p_prenom + " " + p_nom + " et qui habite à " + p_ville+".");
        }
        // Définir le destructeur de la classe Person.
        ~Person()
        {
            Console.WriteLine("Destruction d'un objet de la classe Person.");
            Console.ReadKey();
        }


    }

}
