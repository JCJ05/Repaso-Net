using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetCore.EntityFrameworkCore;

namespace Repaso_Net.Models
{
    [Table("cursos")]
    public class Curso
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id {get;set;}
        [Column("nombre")]
        public string Nombre {get;set;}
        [Column("fechaInicio")]
        public string FechaInicio {get;set;}
        [Column("fechaFin")]
        public string FechaFin {get;set;}
        [Column("horario")]
        public string Horario {get;set;}
        [Column("cupo")]
        public int cupo {get;set;}
        [Column("usuarioId")]
        public string UsuarioId {get;set;}
        [Column("archivo")]
        public byte[] Archivo {get;set;}
    }
}