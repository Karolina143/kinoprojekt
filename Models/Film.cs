namespace kinoprojekt.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Tytul { get; set; } = "";
        public string Obrazek { get; set; } = "";
        public string Opis { get; set; } = "";
        public string ZwiastunUrl { get; set; } = "";
        public string Godziny { get; set; } = "";
        public string CzasTrwania { get; set; } = "";
        public string Rezyseria { get; set; } = "";
        public string Obsada { get; set; } = "";
        public string Kategoria { get; set; } = "";
    }
}