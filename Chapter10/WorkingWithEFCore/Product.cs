﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithEFCore
{
    public class Product
    {
        public int ProductId { get; set; } //primary key
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        [Column("Unit Price", TypeName = "money")]

        public decimal? Cost { get; set; } //propery name != column name
        [Column("UnitsInStock")]

        public short? Stock { get; set; }

        public bool Discontinued { get; set; }  
        //There two define the foreign key relationship to the Categories table
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;


    }
}
