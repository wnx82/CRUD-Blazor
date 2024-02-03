using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Entities
{
    public class Employe
    {

        [Key]
        [Column("Id_Employe")]
        public Guid idEmpoloye { get; set; }

        [Column("Nom")]
        public string? Nom { get; set; }

        [Column("Prenom")]
        public string? Prenom { get; set; }


        [Column("Birthday")]
        public DateTime? Birthday { get; set; }


    }
}
