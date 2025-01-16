namespace BillEase.Models
{
    public class Facture
    {
        public int Id { get; set; }
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }
        public DateTime Date { get; set; }
        public float TotalTVA { get; set; }
        public float TotalTTC { get; set; }

        // Méthodes
        public void ImprimerPDF()
        {
            // Implémentation pour imprimer la facture en PDF
        }
    }

}
