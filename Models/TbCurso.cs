using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAluno.Models
{
    [Table("tb_curso")]
    public partial class TbCurso
    {
        [Key]
        [Column("id_curso", TypeName = "int(11)")]
        public int IdCurso { get; set; }
        [Required]
        [Column("nm_curso", TypeName = "varchar(200)")]
        public string NmCurso { get; set; }
        [Required]
        [Column("tp_curso", TypeName = "varchar(100)")]
        public string TpCurso { get; set; }
    }
}
