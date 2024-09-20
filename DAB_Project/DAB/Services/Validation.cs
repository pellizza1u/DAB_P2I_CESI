namespace DAB_Project.Services
{
    public class Validation
    {
        // Vérifie si le code PIN est correct
        public bool VerifierPIN(int code)
        {
            // Pour cet exemple, le code correct est fixé à 1234
            return code == 1234;
        }
    }
}
