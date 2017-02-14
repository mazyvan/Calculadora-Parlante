using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int last_op = 0;
        float valor_anterior = 0;
        float valor_actual = 0;
        float result = 0;
        Boolean hayValorAnterior = false;
        Boolean sePresionoOperador = false;
        Boolean sePresionoIgual = false;
        public Form1()
        {
            InitializeComponent();
            this.Select();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            setProperty("start_program", "calcu.exe");
        }

        private void hacerOperacion()
        {
            switch (last_op)
            {
                case 1:
                    {
                        valor_actual = valor_anterior / valor_actual;
                        texto.Text = valor_actual.ToString("0.00");
                    }
                    break;
                case 2:
                    {
                        valor_actual = valor_anterior * valor_actual;
                        texto.Text = valor_actual.ToString("0.00");
                    }
                    break;
                case 3:
                    {
                        valor_actual = valor_anterior - valor_actual;
                        texto.Text = valor_actual.ToString("0.00");
                    }
                    break;
                case 4:
                    {
                        valor_actual = valor_anterior + valor_actual;
                        texto.Text = valor_actual.ToString("0.00");
                    }
                    break;
            }
        }

        private Boolean esCero()
        {
            if (texto.Text.Equals("0") || texto.Text.Equals("Entrada no válida"))
            {
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (esCero() || sePresionoOperador)
            {
                texto.Text = "8";
                sePresionoOperador = false;
            }
            else
            {
                texto.Text = texto.Text + "8";
            }
            sePresionoIgual = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (esCero() || sePresionoOperador)
            {
                texto.Text = "2";
                sePresionoOperador = false;
            }
            else
            {
                texto.Text = texto.Text + "2";
            }
            sePresionoIgual = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (esCero() || sePresionoOperador)
            {
                texto.Text = "7";
                sePresionoOperador = false;
            }else
            {
                texto.Text = texto.Text + "7";
            }
            sePresionoIgual = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (esCero() || sePresionoOperador)
            {
                texto.Text = "9";
                sePresionoOperador = false;
            }
            else
            {
                texto.Text = texto.Text + "9";
            }
            sePresionoIgual = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (esCero() || sePresionoOperador)
            {
                texto.Text = "4";
                sePresionoOperador = false;
            }
            else
            {
                texto.Text = texto.Text + "4";
            }
            sePresionoIgual = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (esCero() || sePresionoOperador)
            {
                texto.Text = "5";
                sePresionoOperador = false;
            }
            else
            {
                texto.Text = texto.Text + "5";
            }
            sePresionoIgual = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (esCero() || sePresionoOperador)
            {
                texto.Text = "6";
                sePresionoOperador = false;
            }
            else
            {
                texto.Text = texto.Text + "6";
            }
            sePresionoIgual = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (esCero() || sePresionoOperador)
            {
                texto.Text = "1";
                sePresionoOperador = false;
            }
            else
            {
                texto.Text = texto.Text + "1";
            }
            sePresionoIgual = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (esCero() || sePresionoOperador)
            {
                texto.Text = "3";
                sePresionoOperador = false;
            }
            else
            {
                texto.Text = texto.Text + "3";
            }
            sePresionoIgual = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Boolean HayPunto = false;
            for (int i = 0; i < texto.Text.Length; i++)
            {
                if (texto.Text.ElementAt(i).Equals('.'))
                {
                    HayPunto = true;
                }
            }
            if (!HayPunto)
            {
                if (texto.Text.Equals(""))
                {
                    texto.Text = texto.Text + "0.";
                }
                else
                {
                    texto.Text = texto.Text + ".";
                }
            }
            if (sePresionoIgual || sePresionoOperador)
            {
                texto.Text = "0.";
            }
            sePresionoIgual = false;
            sePresionoOperador = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!esCero())
            {
                texto.Text = texto.Text + "0";
            }
            if (sePresionoOperador)
            {
                texto.Text = "0";
                sePresionoOperador = false;
            }
            sePresionoIgual = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            texto.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Select();
            if ((!sePresionoOperador || sePresionoIgual) && texto.Text.Equals("Entrada no válida") == false)
            {
                valor_actual = float.Parse(texto.Text);
                if (hayValorAnterior)
                {
                    if (last_op == 5)
                    {
                        last_op = 2;
                    }
                    hacerOperacion();
                }
                
                valor_anterior = valor_actual;
                hayValorAnterior = true;
            }
            last_op = 2;
            sePresionoOperador = true;
            sePresionoIgual = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (texto.Text.Equals("Entrada no válida"))
            {
                texto.Text = "0";
            }
            if (!sePresionoOperador && !sePresionoIgual)
            {
                String borra1 = "";
                for (int a = 0; a < texto.Text.Length - 1; a++)
                {
                    borra1 = borra1 + texto.Text.ElementAt(a);
                }
                texto.Text = borra1;
                if (borra1.Equals(""))
                {
                    texto.Text = "0";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ((!sePresionoOperador || sePresionoIgual) && texto.Text.Equals("Entrada no válida") == false)
            {
                valor_actual = float.Parse(texto.Text);
                if (hayValorAnterior)
                {
                    if(last_op == 5)
                    {
                        last_op = 1;
                    }
                    hacerOperacion();
                }
                
                valor_anterior = valor_actual;
                hayValorAnterior = true;
            }
            last_op = 1;
            sePresionoOperador = true;
            sePresionoIgual = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((!sePresionoOperador || sePresionoIgual) && texto.Text.Equals("Entrada no válida") == false)
            {
                valor_actual = float.Parse(texto.Text);
                if (hayValorAnterior)
                {
                    if (last_op == 5)
                    {
                        last_op = 3;
                    }
                    hacerOperacion();
                }
                
                valor_anterior = valor_actual;
                hayValorAnterior = true;
            }
            last_op = 3;
            sePresionoOperador = true;
            sePresionoIgual = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Select();
            if ((!sePresionoOperador || sePresionoIgual) && texto.Text.Equals("Entrada no válida") == false)
            {
                valor_actual = float.Parse(texto.Text);
                if (hayValorAnterior)
                {
                    if (last_op == 5)
                    {
                        last_op = 4;
                    }
                    hacerOperacion();
                }
                
                valor_anterior = valor_actual;
                hayValorAnterior = true;
            }
            last_op = 4;
            sePresionoOperador = true;
            sePresionoIgual = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!sePresionoOperador && texto.Text.Equals("Entrada no válida") == false)
            {
                valor_actual = float.Parse(texto.Text);
                if (hayValorAnterior)
                {
                    hacerOperacion();
                }
                last_op = 5;
                hayValorAnterior = false;
            }
            sePresionoOperador = true;
            sePresionoIgual = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            texto.Text = "0";
            last_op = 0;
            valor_anterior = 0;
            valor_actual = 0;
            hayValorAnterior = false;
            
        }

        private void texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.D0))
            {
                button10_Click(null, null);
                button10.Select();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D1))
            {
                button7_Click(null, null);
                button7.Select();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D2))
            {
                button8_Click(null, null);
                button8.Select();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D3))
            {
                button9_Click(null, null);
                button9.Select();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D4))
            {
                button4_Click(null, null);
                button4.Select();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D5))
            {
                button5_Click(null, null);
                button5.Select();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D6))
            {
                button6_Click(null, null);
                button6.Select();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D7))
            {
                button1_Click(null, null);
                button1.Select();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D8))
            {
                button2_Click(null, null);
                button2.Select();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D9))
            {
                button3_Click(null, null);
                button3.Select();
            }
            
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button15_Click(null, null);
                button15.Select();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(texto.Text);
            }
            if (e.Control && e.KeyCode == Keys.V)
            {
                try
                {
                    texto.Text = float.Parse(Clipboard.GetText()).ToString();
                }
                catch (Exception err)
                {
                    texto.Text = "Entrada no válida";
                }
                
            }
            if (e.Shift && e.KeyCode == Keys.D7)
            {
                button13_Click(null, null);
                button13.Select();
            }
            if (e.Shift && e.KeyCode == Keys.Oemplus)
            {
                button12_Click(null, null);
                
            }else if (e.KeyCode == Keys.Oemplus)
            {
                button14_Click(null, null);

            }
            if (e.KeyCode == Keys.OemMinus)
            {
                button11_Click(null, null);
                button11.Select();
            }
            
            if (e.KeyCode == Keys.Return)
            {
                button15_Click(null, null);
                button15.Select();
            }
            if (e.KeyCode == Keys.Delete) 
            {
                button19_Click(null, null);
                button19.Select();
            }
            if (e.KeyValue == Convert.ToChar(Keys.Back))
            {
                button17_Click(null, null);
                button17.Select();
            }
            if (e.KeyValue == Convert.ToChar(Keys.OemPeriod))
            {
                button16_Click(null, null);
                button16.Select();
            }
        }





        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            Form1_KeyDown(this, e);
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Form1_KeyPress(this, e);
        }
        
        private void button14_KeyDown(object sender, KeyEventArgs e)
        {
            Form1_KeyDown(this, e);
        }

        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(texto.Text);
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                texto.Text = float.Parse(Clipboard.GetText()).ToString();
            }
            catch (Exception err)
            {
                texto.Text = "Entrada no válida";
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraEstandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calcu2.exe");
                Application.Exit();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al intentar iniciar el programa");
            }
        }
        public void setProperty(string watchValue, string newValue)
        {
            string propertiesfilename = @"doc.properties";
            System.IO.File.Delete(propertiesfilename);
            String[] todo = new String[1];
            todo[0] = watchValue + " = " + newValue;
            System.IO.File.WriteAllLines(propertiesfilename, todo);
        }

        private void calculadoraCientíficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jajajajajajajaja. Sí cómo no", "Sí Claro...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void documentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void donarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/mx/cgi-bin/webscr?cmd=_flow&SESSION=JdqTna7qvmyjm2ImDeVbwoVmr_AR8-pbdpYKlyo6Mj5KuYJKXugCDCijocS&dispatch=5885d80a13c0db1f8e263663d3faee8dcce3e160f5b9538489e17951d2c62172");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MIT License Copyright (c) 2016 Iván Sánchez \nMás información en https://opensource.org/licenses/MIT", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void irAPáginaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/mazivans");
        }
    }
}
