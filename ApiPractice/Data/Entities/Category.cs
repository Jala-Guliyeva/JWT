﻿using System.Collections.Generic;

namespace ApiPractice.Data.Entities
{
    public class Category:BaseEntity
    {
       
        public string Name { get; set; }
        public string Desc { get; set; }
        public bool  IsDeleted { get; set; }

        public List<Product> Products { get; set; }
    }
}
