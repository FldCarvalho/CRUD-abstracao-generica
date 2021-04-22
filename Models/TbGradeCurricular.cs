using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAluno.Models
{
    [Table("tb_grade_curricular")]
    public partial class TbGradeCurricular
    {
        [Key]
        [Column("id_grade_curricular", TypeName = "int(11)")]
        public int IdGradeCurricular { get; set; }
        [Column("nm_materia", TypeName = "varchar(100)")]
        public string NmMateria { get; set; }
        [Column("nm_professor", TypeName = "varchar(100)")]
        public string NmProfessor { get; set; }
        [Column("nr_carga_horaria", TypeName = "decimal(10,2)")]
        public decimal? NrCargaHoraria { get; set; }
    }
}
