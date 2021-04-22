using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAluno.Models
{
    [Table("tb_aluno")]
    public partial class TbAluno
    {
        [Key]
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Required]
        [Column("nm_aluno", TypeName = "varchar(200)")]
        public string NmAluno { get; set; }
        [Column("nr_chamada", TypeName = "int(11)")]
        public int NrChamada { get; set; }
        [Required]
        [Column("nm_turma", TypeName = "varchar(50)")]
        public string NmTurma { get; set; }
    }
}
