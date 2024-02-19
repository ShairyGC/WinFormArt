namespace WinFormsApp3
{
    public class Artistan(string nombre, string pais, string genero)
    {
        public string NombreArtista { get; set; } = nombre;
        public string PaisOrigen { get; set; } = pais ?? "";
        public string GeneroMusical { get; set; } = genero;
        public Image Fotografia { get; set; } = Image.FromFile("ruta/de/imagen/default.jpg");
    }
}