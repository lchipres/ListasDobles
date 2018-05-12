using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Catal
    {
        //Producto[] p = new Producto[15];

        int cuantosBan;
        public Producto primero, tmpT;

        public Catal()
        {
            primero = null;
            cuantosBan = 1;
        }

        public void agregarInicio(Producto p2)
        {
            Producto nuevo = new Producto(p2);
            nuevo.siguiente = primero;//ir al primer producto
            primero = nuevo;//Lo coloca en el primero
            cuantosBan++;
        }
        public void agregar(Producto p, Producto lugar)
        {
            if (lugar.siguiente == null)
            {
                lugar.siguiente = p;
            }
            else
            {
                agregar(p, lugar.siguiente);
            }
        }
        private void agregarInv(Producto p)
        {
            if (tmpT == null)
            {
                tmpT = p;
            }
            else
            {
                agregar(p, tmpT);
            }
        }

        private Producto invertir(Producto lugar)
        {
            if (lugar.siguiente != null)
            {
                agregarInv(invertir(lugar.siguiente));
                lugar.siguiente = null;
                return lugar;
            }
            else
            {
                return lugar;
            }
        }

        public void InvertirLista()
        {
            if (primero != null)
            {
                tmpT = null;
                invertir(primero);
                primero.siguiente = null;
                agregarInv(primero);
                primero = tmpT;
            }
        }

        public string Listar()
        {
            Producto actual = primero;
            string s = "";
            while (actual != null)
            {
                s += actual + Environment.NewLine;
                actual = actual.siguiente;
            }
            return s;
        }

        //public void agregarP(Producto p)
        //{

        //    this.p[cuantosBan] = p;
        //    cuantosBan++;
        //}

        public int getCuantos()
        {
            return cuantosBan;
        }

        //public override string ToString()
        //{
        //    string s = "";
        //    foreach (Producto element in p)
        //    {
        //        s += element+Environment.NewLine;
        //    }
        //    return s;
        //}

        public string buscarP(Producto p, int codigo)
        {
            string s = "";
            if (p != null)//Hay algo en la lista?
            {
                for (int i = 0; i < cuantosBan; i++)
                {
                    if (p.siguiente.getCodigo() == codigo)
                    {
                        s = p.siguiente.ToString() + Environment.NewLine;//Tu siguiente es el que busco?
                        break;
                    }
                }
            }
            return s;
            
        }

        public void eliminarP(Producto p,int codigo)
        {
            if (p != null)//Lista vacia?
            {
                if (p.siguiente.getCodigo()==codigo)//Tu siguiente es el que quiero eliminar?
                {
                    p.siguiente = p.siguiente.siguiente;//Entonces tu siguiente va a ser el siguiente de ese
                }
            }
        }

    }
}
