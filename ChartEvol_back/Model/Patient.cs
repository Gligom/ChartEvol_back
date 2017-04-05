using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChartEvol_back.Model
{
    public class Patient
    {
        public Patient()
        { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Cod")]
        public int pacCod { get; set; }

        [DisplayName("Nume")]
        public string pacNume { get; set; }

        [DisplayName("Prenume")]
        public string pacPrenume { get; set; }

        [DisplayName("CNP")]
        public string pacCNP { get; set; }
    }
}




