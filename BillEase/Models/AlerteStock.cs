namespace BillEase.Models
{
    public class AlerteStock
    {
        public int Id { get; set; }
        public int MarchandiseId { get; set; }
        public Marchandise Marchandise { get; set; }
        public string Message { get; set; }

        // Méthodes
        public void EnvoyerAlerte()
        {
            // Implémentation pour envoyer une alerte
        }
    }

}
