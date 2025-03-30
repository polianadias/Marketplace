using System.ComponentModel.DataAnnotations;

namespace Marketplace.Dominio.Entidades
{
    public class Vendedor
    {
        [Key]
        public Guid Codigo { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
    }
}
