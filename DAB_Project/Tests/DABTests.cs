using Xunit;
using DAB_Project.Models;

namespace DAB_Project.Tests
{
    public class DABTests
    {
        [Fact]
        public void VerifierCode_CorrectCode_ReturnsTrue()
        {
            // création d'un objet DAB
            DAB dab = new DAB(1000, 500);

            // vérification du code correct
            bool result = dab.VerifierCode(1234);

            // on s'attend à ce que le résultat soit vrai
            Assert.True(result);
        }

        [Fact]
        public void VerifierCode_IncorrectCode_ReturnsFalse()
        {
            DAB dab = new DAB(1000, 500);

            bool result = dab.VerifierCode(5678);

            // on s'attend à ce que le résultat soit faux
            Assert.False(result);
        }

        [Fact]
        public void RetirerArgent_ValidAmount_ReturnsTrueAndDecreasesSolde()
        {
            //DAB initialisé avec 1000€ de solde et une limite de retrait de 500€
            DAB dab = new DAB(1000, 500);

            // tentative de retirer 400€, ce qui est inférieur à la limite
            bool result = dab.RetirerArgent(400);

            // le retrait doit réussir et le solde doit être mis à jour
            Assert.True(result);
            Assert.Equal(600, dab.ConsulterSolde()); // Le solde devrait être donc 1000 - 400 = 600€
        }

        [Fact]
        public void RetirerArgent_ExceedsLimit_ReturnsFalse()
        {
            // DAB initialisé avec une limite de retrait de 500€
            DAB dab = new DAB(1000, 500);

            // tentative de retirer 600€, au-delà de la limite
            bool result = dab.RetirerArgent(600);

            // le retrait doit échouer
            Assert.False(result);
        }

        [Fact]
        public void RetirerArgent_InsufficientFunds_ReturnsFalse()
        {
            // DAB initialisé avec 200€ de solde
            DAB dab = new DAB(200, 500);

            // tentative de retirer 300€, ce qui dépasse le solde disponible
            bool result = dab.RetirerArgent(300);

            // le retrait doit échouer
            Assert.False(result);
        }
    }
}
