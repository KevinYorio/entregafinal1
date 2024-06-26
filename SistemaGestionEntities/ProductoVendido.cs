﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public int Stock { get; set; } 
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

        public ProductoVendido() { }

        public ProductoVendido(int stock, int idProducto, int idVenta)
        {
            this.Stock = stock;
            this.IdProducto = idProducto;
            this.IdVenta = idVenta;
        }
        public ProductoVendido(int id, int stock, int idProducto, int idVenta)
        {
            this.Id = id;
            this.Stock = stock;
            this.IdProducto = idProducto;
            this.IdVenta = idVenta;
        }

        public override string ToString()
        {
            return $"ID = {this.Id} - Stock = {this.Stock} - IdProducto = {this.IdProducto} - IdVenta = {this.IdVenta}";
        }
    }
}
