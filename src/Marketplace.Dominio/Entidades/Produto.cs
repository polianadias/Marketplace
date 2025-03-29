namespace Marketplace.Dominio.Entidades
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
