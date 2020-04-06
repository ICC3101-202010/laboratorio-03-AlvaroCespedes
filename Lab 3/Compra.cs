using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Compra : Producto
    {
        List<string> carro;
        public Compra()
        {
            carro = new List<string>();
        }
        public void AgregarCarro(string id)
        {
            carro.Add(id);
        }
    }
}
