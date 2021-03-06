﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeginCollectionItemCoreDemo.ViewModels
{
    public class OrderItemModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public double Quantity { get; set; }

        public List<DiscountModel> Discounts { get; set; }
    }
}
