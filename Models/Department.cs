﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMvc.Models

{
    public class Department
    {
        public int Id { get;  set; }

        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller Seller)
        {
            Sellers.Add(Seller);
        }

        public double TotalSales(DateTime inital, DateTime final)
        {
            return Sellers.Sum(x => x.TotalSales(inital, final));
        }


    }
}
