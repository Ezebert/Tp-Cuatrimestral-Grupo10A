using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Productos
    {
        public int ProductoId {  get; set; }
        public string? Nobmre {  get; set; }
        public string? Descripcion {  get; set; }
        public float Precio {  get; set; }
        public int stock {  get; set; }
        public int CategoriaId {  get; set; }
        public bool Estado { get; set; }
    }
}
