﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concrate
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public List<Kitap> Kitaplar { get; set; }
    }
}
