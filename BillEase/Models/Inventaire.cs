namespace BillEase.Models
{
    public class Inventaire
    {
        public int Id { get; set; }
        public DateTime PeriodeDebut { get; set; }
        public DateTime PeriodeFin { get; set; }
        public float TotalVendu { get; set; }
        public float Benefices { get; set; }
        public float Pertes { get; set; }

        // Méthodes
        public void CalculerBenefices()
        {
            // Implémentation pour calculer les bénéfices
        }

        public void CalculerPertes()
        {
            // Implémentation pour calculer les pertes
        }
    }

}
