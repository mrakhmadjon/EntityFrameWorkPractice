using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkPractive.Models
{
    [Table("student")]
    internal class Student
    {
        [Column("id"),Key]
        public int Id { get; set; }

        [Column("firstname"),MaxLength(30)]
        public string Firstname { get; set; }

        [Column("lastname"),MaxLength(30)]
        public string Lastname { get; set; }


        [Column("age")]
        public int Age { get; set; }

        [Column("email"),MaxLength(20)]
        public string Email { get; set; }

        [Column("password"), MaxLength(20)]

        public string Password { get; set; }
    }
}
