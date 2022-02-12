using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TioRACLab.Terrario.Shared
{
    [Table("StatusTerrario")]
    public class StatusTerrario
    {
        [Key]
        [Required]
        [Column("Timestamp")]
        public int Timestamp { get; set; }

        [Required]
        [Column("Status")]
        public Status Status { get; set; }

        [Column("Temperatura")]
        public int Temperatura { get; set; }

        [Column("Umidade")]
        public int Umidade { get; set; }

        [Column("NivelLago")]
        public byte NivelLago { get; set; }

        
    }
}