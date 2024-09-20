using System;

namespace DAB_Project.Models
{
    public class Client
    {
        // Attribut privé pour stocker le code PIN du client
        private int codeSecret;

        // Constructeur pour initialiser le code PIN du client
        public Client(int code)
        {
            codeSecret = code;
        }

        // Permet au client d'utiliser le DAB
        public void UtiliserDAB(DAB dab)
        {
            // Vérifie si le code PIN est correct
            if (dab.VerifierCode(codeSecret))
            {
                Console.WriteLine("Code vérifié. Que voulez-vous faire ?");
                Console.WriteLine("1. Consulter solde");
                Console.WriteLine("2. Retirer argent");

                // Récupère le choix de l'utilisateur
                string choix = Console.ReadLine();

                // Traitement des actions en fonction du choix
                switch (choix)
                {
                    case "1":
                        // Consultation du solde
                        double solde = dab.ConsulterSolde();
                        Console.WriteLine($"Votre solde est de {solde}€.");
                        break;

                    case "2":
                        // Retrait d'argent
                        Console.WriteLine("Entrez le montant à retirer : ");
                        double montant = Convert.ToDouble(Console.ReadLine());
                        dab.RetirerArgent(montant); // Tente de retirer le montant demandé
                        break;

                    default:
                        Console.WriteLine("Option invalide.");
                        break;
                }
            }
            else
            {
                // code incorrect --> afficher un message d'erreur
                Console.WriteLine("Code incorrect.");
            }
        }
    }
}
