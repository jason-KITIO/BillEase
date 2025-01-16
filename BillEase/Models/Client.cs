namespace BillEase.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }

        // Relations
        public ICollection<Commande> Commandes { get; set; }
    }

}
