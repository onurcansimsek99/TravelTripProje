using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KulaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public Blog Blog { get; set; }
    }
}