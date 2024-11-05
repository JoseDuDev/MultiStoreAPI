namespace MultiStoreAPI.Domain.Models
{
    public class Loja
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Dominio { get; set; }
        public LayoutConfig LayoutConfig { get; set; }
    }
}
