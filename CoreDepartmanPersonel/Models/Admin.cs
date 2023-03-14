﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreDepartmanPersonel.Models
{
    public class Admin
    {
        [Key] 
        public int AdminID { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string Kullanici { get; set; }
       
        [Column(TypeName = "Varchar(20)")]
        public string Sifre { get; set; }
    }
}
