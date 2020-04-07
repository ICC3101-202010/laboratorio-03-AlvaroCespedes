using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Producto
    {
        private string _nombre;
        private string _precio;
        private string _marca;
        private string _tipo;
        private string _id;
        private string _stock;

        //Encapsulando campos --> Comando rapido.
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Precio { get => _precio; set => _precio = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Id { get => _id; set => _id = value; }
        public string Stock { get => _stock; set => _stock = value; }

        public Producto(string nombre, string precio, string marca, string stock, string tipo, string id)
        {

            this._marca = marca;
            this._precio = precio;
            this._nombre = nombre;
            this._tipo = tipo;
            this._id = id;
            this._stock = stock;
        }

        public List<string> nombresPro;
        public List<string> preciosPro;
        public List<string> marcasPro;
        public List<string> tiposPro;
        public List<string> idsPro;
        public List<string> stockPro;

        public Producto()
        {
            nombresPro = new List<string>();
            preciosPro = new List<string>();
            marcasPro = new List<string>();
            tiposPro = new List<string>();
            idsPro = new List<string>();
            stockPro = new List<string>();
        }

        public void AgregarNombrePro(string nombre)
        {
            nombresPro.Add(nombre);
        }
        public void AgregarPreciosPro(string precio)
        {
            preciosPro.Add(precio);
        }
        public void AgregarMarcasPro(string marca)
        {
            marcasPro.Add(marca);
        }
        public void AgregarTiposPro(string tipo)
        {
            tiposPro.Add(tipo);
        }
        public void AgregarIdPro(string id)
        {
            idsPro.Add(id);
        }
        public void QuitarId(string id)
        {
            idsPro.Remove(id);
        }
        public void AgregarStock(string stock)
        {
            stockPro.Add(stock);
        }
        public void QuitarStock(string stock) // Cada vez ue se compre algo, se elemina uno
        {
            stockPro.Remove(stock);
        }




    }
}
