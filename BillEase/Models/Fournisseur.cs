namespace BillEase.Models
{
    public class Fournisseur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Contact { get; set; }

        // Relations
        public ICollection<Marchandise> Marchandises { get; set; }
    }

}
