using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcExamenAWS2.Models
{
    [Table("categoriaevento")]
    public class CategoriaEvento
    {
        [Key]
        [Column("idcategoria")]
        public int IdCategoria { get; set; }

        [Column("nombre")]
        public string Nombre { get; set;}

    }
}
