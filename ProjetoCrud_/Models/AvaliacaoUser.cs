using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCrud_.Models
{
    [Table("AvaliacaoUser")]
    public class AvaliacaoUser
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Avaliação")]
        [Column("Avaliacao")]
        public string Avaliação { get; set; }


        [Display(Name = "Operadora")]
        [Column("Aoperadora")]
        public Operadoras Aoperadora { get; set; }


        [Display(Name = "Usuario")]
        [Column("Ouser")]
        public Usuarios Ouser { get; set; }      

    }
}
