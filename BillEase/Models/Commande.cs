using System.Text.RegularExpressions;

namespace BillEase.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public DateTime Date { get; set; }
        public float Total { get; set; }

        // Méthodes
        public float CalculerTotal()
        {
            // Implémentation pour calculer le total
            return Total;
        }

        public Facture GenererFacture()
        {
            return new Facture
            {
                CommandeId = this.Id,
                Date = DateTime.Now,
                TotalTTC = this.Total
            };
        }
    }

}
