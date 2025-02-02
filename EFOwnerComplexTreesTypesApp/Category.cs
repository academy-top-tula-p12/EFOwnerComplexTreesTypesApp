﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOwnerComplexTreesTypesApp
{
    public class Category
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public int? ParentId { get; set; }
        public Category? Parent { get; set; }

        public List<Category> Children { get; set; } = new();
    }
}
