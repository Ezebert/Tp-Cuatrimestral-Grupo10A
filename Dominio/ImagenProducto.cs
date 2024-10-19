using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class ImagenProducto
    {
        public int ImagenID {  get; set; }
        public int ProductoID {  get; set; }
        public string? ImagenUrl { get; set; }
    }
}
