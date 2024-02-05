using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CRUD.Entities
{
    public class Employe
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Nom")]
        public string? Nom { get; set; }

        [Column("Prenom")]
        public string? Prenom { get; set; }

        [Column("CreatedAt")]
        public DateTime? CreatedAt { get; set; }

		[Column("UpdatedAt")]
		public DateTime? UpdatedAt { get; set; }

		[Column("DeletedAt")]
        public DateTime? DeletedAt { get; set; }
    }

}
