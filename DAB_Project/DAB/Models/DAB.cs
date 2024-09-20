using System;
using DAB_Project.Services;

namespace DAB_Project.Models
{
    public class DAB
    {
        // Attributs privés
        private double solde; // Le solde actuel du DAB
        private double limiteRetrait; // La limite de retrait par opération

        // Constructeur pour initialiser le solde et la limite de retrait
        public DAB(double soldeInitial, double limite)
        {
            solde = soldeInitial;
            limiteRetrait = limite;
        }

        // Vérifie si le code PIN est correct via un service externe de validation
        public bool VerifierCode(int code)
        {
            Validation validator = new Validation();
            return validator.VerifierPIN(code);
        }

        // Retire un montant d'argent si possible
        public bool RetirerArgent(double montant)
        {
            // Vérifie si le montant demandé est inférieur ou égal au solde et à la limite de retrait
            if (montant <= solde && montant <= limiteRetrait)
            {
                solde -= montant; // Met à jour le solde après le retrait
                Console.WriteLine($"Vous avez retiré {montant}€. Votre nouveau solde est de {solde}€.");
                return true; // Retrait réussi
            }
            else
            {
                // Si le montant dépasse le solde ou la limite de retrait, le retrait est refusé
                Console.WriteLine("Le retrait a échoué. Solde insuffisant ou montant supérieur à la limite.");
                return false; // Retrait échoué
            }
        }

        // Renvoie le solde actuel
        public double ConsulterSolde()
        {
            return solde;
        }
    }
}
