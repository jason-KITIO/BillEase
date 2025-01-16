namespace BillEase.Models
{
    public class Marchandise
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Fournisseur { get; set; }
        public float PrixAchat { get; set; }
        public float PrixVente { get; set; }
        public float TauxTVA { get; set; }
        public int Stock { get; set; }
        public int StockSeuil { get; set; }

        // Méthodes
        public bool VerifierStock()
        {
            return Stock <= StockSeuil;
        }
    }

}
