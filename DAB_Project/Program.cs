using System;
using DAB_Project.Models;
using DAB_Project.Services;

namespace DAB_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisation du DAB avec un solde de 1000€ et une limite de retrait de 500€
            DAB dab = new DAB(1000, 500);

            // Création d'un client avec un code PIN (par exemple 1234)
            Client client = new Client(1234);

            // Le client tente d'utiliser le DAB
            client.UtiliserDAB(dab);

            Console.WriteLine("Transaction terminée.");
        }
    }
}
