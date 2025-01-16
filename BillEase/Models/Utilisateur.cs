namespace BillEase.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; }

        // Relations
        public ICollection<Commande> Commandes { get; set; }

        // Méthodes
        public bool Authentifier(string login, string motDePasse)
        {
            return this.Login == login && this.MotDePasse == motDePasse;
        }
    }

}
