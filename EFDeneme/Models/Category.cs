﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeneme.Models
{
    
    public class Category
    {
        public int Id { get; set; }

        
        public string CategoryName{ get; set; }

        public List<Product> Products { get; set; }

    }
}
