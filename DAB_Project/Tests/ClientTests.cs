using Xunit;
using DAB_Project.Models;

namespace DAB_Project.Tests
{
    public class ClientTests
    {
        [Fact]
        public void UtiliserDAB_WithCorrectPIN_CanCheckBalance()
        {
            // création d'un DAB avec 1000€ et d'un client avec le code 1234
            DAB dab = new DAB(1000, 500);
            Client client = new Client(1234);

            // on simule la consultation du solde.
            // on valide que le code correct permet au client d'utiliser le DAB.
            Assert.True(dab.VerifierCode(1234));
        }

        [Fact]
        public void UtiliserDAB_WithIncorrectPIN_CannotCheckBalance()
        {
            // création d'un DAB et d'un client avec un mauvais code PIN
            DAB dab = new DAB(1000, 500);
            Client client = new Client(5678); // PIN incorrect

            // le client ne peut pas utiliser le DAB car le code est incorrect
            Assert.False(dab.VerifierCode(5678));
        }
    }
}
