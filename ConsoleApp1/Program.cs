// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Xml;
using System.Xml.Linq;

namespace System
{
    class MainMenu
    {
        // Créer un nouveau dictionnaire de clients
        static Dictionary<int, string> dicClients = new Dictionary<int, string>();

        // Initialisation du Dictionnaire
        static void Init()
        {
            dicClients.Add(1, "Bertand");
            dicClients.Add(2, "Lyna");
            dicClients.Add(3, "Arnaud");
            dicClients.Add(4, "Melissa");
            dicClients.Add(5, "Pierre");
        }
        static void Main(string[] args)
        {
            string choixOperation;
            Init();
            Menu();
            do
            {
                choixOperation = Console.ReadLine();
                Nettoyage();
                switch (choixOperation)
                {
                    case "1":
                        AfficherLesClients();
                        break;
                    case "2":
                        AjouterClient();
                        break;
                    case "3":
                        SupprimerClient();
                        break;
                    case "4":
                        RechercherClient();
                        break;
                }
            } while (choixOperation != "Q");
        }
        #region Methodes statiques
        // Créer un menu 
        static void Menu()
        {
            Console.WriteLine("\t  ---- Mon Premier Menu en C# ---- \n");
            Console.WriteLine("1 : Afficher tous les clients");
            Console.WriteLine("2 : Ajouter un client");
            Console.WriteLine("3 : Supprimer un client");
            Console.WriteLine("4 : Rechercher un client");
            Console.WriteLine("Q : QUIT");
            Console.Write("\t\n Donnez votre choix : ");
        }

        public static void Nettoyage()
        {
            Console.Clear();
        }

        public static void AfficherLesClients()
        {
            Console.Write("\t Liste des clients : \n");

            // Trier par valeur
            Console.WriteLine("Trier par valeur :");
            Console.WriteLine("====================");
            foreach (KeyValuePair<int, string> client in dicClients.OrderBy(key => key.Value))
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", client.Key, client.Value);
            }
        }
        public static void AjouterClient()
        {
            Console.Write("\t\n Ajouter un client : \n");
            // Ajouter un client au dictionnaire
            dicClients.Add(6, "Nathan");

            // Pour obtenir le nombre de clés/valeurs
            Console.WriteLine(" Nombre total de paires clé/valeur dans" +
                        " dicClients : " + dicClients.Count);

            // Affichage de clé/valeur
            Console.WriteLine("Les paires clé/valeur" +
                               " dans dicClients sont : ");

            foreach (KeyValuePair<int, string> kvp in dicClients)
            {
                Console.WriteLine("Clé = {0}, Valeur = {1}",
                                  kvp.Key, kvp.Value);
            }
        }

        public static void SupprimerClient()
        {
            // Supprimer un client du dictionnaire
            dicClients.Remove(1); // supprime Bertrand

            // Parcourir le dictionnaire
            foreach (KeyValuePair<int, string> client in dicClients)
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}",
                    client.Key, client.Value);
            }
        }

        public static void RechercherClient()
        {
            Console.Write("\t Le client recherché est : \n");
            // Rechercher un client dans le dictionnaire
            Console.WriteLine(dicClients[2]); // retourne Lyna
            #endregion

        }
    }
}





