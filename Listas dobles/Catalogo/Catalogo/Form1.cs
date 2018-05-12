using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Form1 : Form
    {
        Catal lista = new Catal();
        Producto p;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = new Producto(lista.getCuantos(),Convert.ToInt32(textCod.Text), Convert.ToInt32(textCan.Text), textNom.Text, Convert.ToDouble(textCos.Text),textAlum.Text,Convert.ToInt32(textCont.Text),textVehi.Text);
            lista.agregarInicio(p);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textMost.Text = lista.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textMost.Text=lista.buscarP(lista.primero,Convert.ToInt16(textPos.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.eliminarP(lista.primero,Convert.ToInt16(textPos.Text));
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            eliminarUltimo();
        }
        private void eliminarPrimero()
        {
            lista.primero = lista.primero.siguiente;
        }
        private void eliminarUltimo()
        {
            Producto tmp = lista.primero;
            while (tmp.siguiente.siguiente!=null)
            {
                tmp = tmp.siguiente;
            }
            tmp.siguiente = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            eliminarPrimero();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textMost.Text=lI();
        }

        private string listarInverso(Producto x)
        {
            string s = "";
            if (x.siguiente!= null)
            {
                s = x.ToString() + Environment.NewLine;
                return listarInverso(x.siguiente) + s;
            }
            else
            {
                s = lista.primero.ToString() + Environment.NewLine;
                return s;
            }
        }

        private string lI()
        {
            string str = "";
            if (lista.primero != null)
            {
                str += listarInverso(lista.primero);
            }
            return str;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lista.InvertirLista();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
