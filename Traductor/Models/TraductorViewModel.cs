namespace Traductor.Models
{
    public class TraductorViewModel
    {
        public List<(char Letra, string RutaSvg)> RutasSvg { get; set; }
        public string Kripto { get; set; }
        public TraductorViewModel()
        {
            RutasSvg = new List<(char Letra, string RutaSvg)>();
            Kripto = string.Empty;
        }
    }
}
