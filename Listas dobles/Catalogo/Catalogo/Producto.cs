using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Producto
    {
        private Int32 codigo,cantidad,contacto;
        public Int32 dato;
        private string nombre,alumno,vehiculo;
        private double costo;
        public Producto siguiente;

        public Producto(int codigo, int cantidad, string nombre, double costo)
        {
            this.codigo = codigo;
            this.cantidad = cantidad;
            this.nombre = nombre;
            this.costo = costo;
        }
        public Producto(int dato,int codigo, int cantidad, string nombre, double costo,string alumno,int contacto,string vehiculo)
        {
            this.dato = dato;
            this.codigo = codigo;
            this.cantidad = cantidad;
            this.nombre = nombre;
            this.costo = costo;
            this.alumno = alumno;
            this.contacto = contacto;
            this.vehiculo = vehiculo;
            siguiente = null;
        }

        public Producto(Producto p2)
        {
            dato = p2.dato;
            codigo = p2.codigo;
            cantidad = p2.cantidad;
            nombre = p2.nombre;
            costo = p2.costo;
            alumno = p2.alumno;
            contacto = p2.contacto;
            vehiculo = p2.vehiculo;
            siguiente = null;
        }

        public Producto(int dato)
        {
            this.dato = dato;
            siguiente = null;
        }


        public int getCodigo()
        {
            if (codigo.Equals(null))
            {
                return 0;
            }
            else
            {
                return codigo;
            }
            
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public string getNombre()
        {
            return nombre;
        }

        public double getCosto()
        {
            return costo;
        }

        public override string ToString()
        {
            string s = " Codigo: " + codigo + " Nombre: " + nombre + " Cantidad: " + cantidad + " Costo: "+costo+" Alumno: "+alumno+" Contacto: "+contacto+" Vehiculo: "+vehiculo;
            return s;
        }

    }
}
