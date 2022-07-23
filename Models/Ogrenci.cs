using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UygulamaSınav.Models
{
    public class Ogrenci
    {
        
        public int OgrenciID { get; set; }
        [StringLength(20)]
        public string OgrenciName { get; set; }
        [StringLength(20)]

        public string OgrenciSurName { get; set; }
        [StringLength(11)]
        public string OgrenciTC { get; set; }
        [StringLength(50)]
        public string OgrenciAdres { get; set; }
        [StringLength(20)]
        public string OgrenciTelefon { get; set; }
        [StringLength(20)]
        public string AldigiEgitim { get; set; }
        [StringLength(20)]
        public string BasariDurumu { get; set; }




    }
}