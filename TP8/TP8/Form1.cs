using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testTP8
{
    public partial class Form1 : Form
    {
        char[] separadores = { '+', '-', '*', '/' };
        Calculadora Calc;
        LinkedList<Calculadora> Lista;
        public Form1()
        {
            InitializeComponent();
            Calc = new Calculadora();
            Lista = new LinkedList<Calculadora>();
        }
        
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }
        private void buttonE_Click(object sender, EventArgs e)
        {
            string operacion = textBox1.Text;
            string[] elementos;
            if (operacion.Contains('+'))
            {
                elementos = operacion.Split(separadores);
                Calc.Numero1 = Convert.ToSingle(elementos[0]);
                Calc.Numero2 = Convert.ToSingle(elementos[1]);
                textBox1.Text = Convert.ToString(Calc.Numero1 + Calc.Numero2);
            }
            else if (operacion.Contains('-'))
            {
                elementos = operacion.Split(separadores);
                Calc.Numero1 = Convert.ToSingle(elementos[0]);
                Calc.Numero2 = Convert.ToSingle(elementos[1]);
                textBox1.Text = Convert.ToString(Calc.Numero1 - Calc.Numero2);
            }
            else if (operacion.Contains('*'))
            {
                elementos = operacion.Split(separadores);
                Calc.Numero1 = Convert.ToSingle(elementos[0]);
                Calc.Numero2 = Convert.ToSingle(elementos[1]);
                textBox1.Text = Convert.ToString(Calc.Numero1 * Calc.Numero2);
            }
            else if (operacion.Contains('/'))
            {
                elementos = operacion.Split(separadores);
                Calc.Numero1 = Convert.ToSingle(elementos[0]);
                Calc.Numero2 = Convert.ToSingle(elementos[1]);
                textBox1.Text = Convert.ToString(Calc.Numero1 / Calc.Numero2);
            }
            Calc.Operacion = operacion + '=' + textBox1.Text;
            Calc.Tiempo = DateTime.Now;
            Lista.AddLast(Calc);
            listBox1.DataSource = Lista.ToList();
            Calc = new Calculadora();
        }
        
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
