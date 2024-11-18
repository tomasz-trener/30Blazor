﻿namespace Shop.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Barcode { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
