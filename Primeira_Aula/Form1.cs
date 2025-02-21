using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeira_Aula
{
    public partial class Calculadora : Form
    {

        public bool virgula = false;
        public bool mais = false;
        public bool menos = false;
        public bool vezes = false;
        public bool div = false;
        public bool exp = false;
        public bool por = false;
        public double res;
        Operacoes op;

        public Calculadora()
        {
            InitializeComponent();
            op = new Operacoes();
            this.KeyPreview = true;

        }
        public void calculo()
        {
            op.b = Convert.ToDouble(textBox1.Text);
            if (mais == true) {
                res = op.Adicao();
            }
            if (menos == true)
            {
                res = op.Sub();
            }
            else if (vezes == true)
            {
                res = op.Mult();
            }
            if (div == true)
            {
                res = op.Divisao();
            }
            else if (exp)
            {
                res = op.Exp();
            }
            else if (por)
            {
                res = op.Porcentual();
            }
            textBox1.Text = Convert.ToString(res);
            menos = false;
            vezes = false;
            mais = false;
            div = false;
            virgula = false;
            exp = false;
            por = false;
        }

     



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            label1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                label1.Text = "Insira um valor";
            }
            else if (textBox1.Text != "")
            {
                op.a = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                mais = true;
                virgula = false;
            }

            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Insira um valor";
            }
            else if (textBox1.Text != "")
            {
                op.a = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                vezes = true;
                virgula = false;
            }
    
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Insira um valor";
            }
            else if (textBox1.Text != "")
            {
                op.a = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                menos = true;
                virgula = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Insira um valor";
            }
            else if (textBox1.Text != "")
            {
                op.a = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                div = true;
                virgula = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (virgula == false)
            {
                textBox1.Text += ",";
                virgula = true;
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Insira um valor";
            }
            else if (textBox1.Text != "")
            {
                calculo();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            label1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            label1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            label1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void button17_Click(object sender, EventArgs e)
		{
            textBox1.Clear();
            virgula = false;
            label1.Text = "";
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            //BORDER RADIUS E GRADIENT
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    int cornerRadius = 8;
                    path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
                    path.AddLine(cornerRadius, 0, control.Width - cornerRadius, 0);
                    path.AddArc(control.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
                    path.AddLine(control.Width, cornerRadius, control.Width, control.Height - cornerRadius);
                    path.AddArc(control.Width - cornerRadius * 2, control.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                    path.AddLine(control.Width - cornerRadius, control.Height, cornerRadius, control.Height);
                    path.AddArc(0, control.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                    path.AddLine(0, control.Height - cornerRadius, 0, cornerRadius);
                    control.Region = new Region(path);

                    LinearGradientBrush gradientBrush = new LinearGradientBrush(
                        new Point(0, 0),  
                        new Point(button10.Width, button10.Height), 
                        Color.FromArgb(255, 128, 255), Color.SkyBlue
                    );
                    gradientBrush.WrapMode = WrapMode.TileFlipXY;
                    button10.BackColor = Color.Transparent;
                    button10.BackgroundImage = new Bitmap(button10.Width, button10.Height);
                    Graphics g = Graphics.FromImage(button10.BackgroundImage);
                    g.FillRectangle(gradientBrush, 0, 0, button10.Width, button10.Height);

                }
            }


        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                label1.Text = "Insira um valor";
            }
            else if (textBox1.Text != "")
            {
                op.a = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                exp = true;
                virgula = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Insira um valor";
            }
            else if (textBox1.Text != "")
            {
                op.a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(op.Raiz());
                virgula = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Insira um valor";
            }
            else if (textBox1.Text != "")
            {
                op.a = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                por = true;
                virgula = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Insira um valor";
            }
            else if (textBox1.Text != "")
            {
                op.a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(op.Elevado());
                virgula = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text == "")
            {
                textBox1.Text = "3.14159265358";
                op.a = 3.14159265358;
            }
            else
            {
                op.a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(op.Npi());
                virgula = false;
            }
        }

        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
           

            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                textBox1.Text += "1";
                label1.Text = "";
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                textBox1.Text += "2";
                label1.Text = "";
                ;
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                textBox1.Text += "3";
                label1.Text = "";
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                textBox1.Text += "4";
                label1.Text = "";
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                textBox1.Text += "5";
                label1.Text = "";
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                textBox1.Text += "6";
                label1.Text = "";
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                textBox1.Text += "7";
                label1.Text = "";
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                textBox1.Text += "8";
                label1.Text = "";
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                textBox1.Text += "9";
                label1.Text = "";
            }
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                textBox1.Text += "0";
                label1.Text = "";
            }
            
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                if (virgula == false)
                {
                    textBox1.Text += ",";
                    virgula = true;
                    label1.Text = "";
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (textBox1.Text == "")
            {
                label1.Text= "Insira um valor";
            }
            else if (textBox1.Text != "")
            {

                if (e.KeyCode == Keys.Add)
                {
                    op.a = Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    mais = true;
                    virgula = false;
                    label1.Text = "";
                }
                if (e.KeyCode == Keys.Subtract)
                {
                    op.a = Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    menos = true;
                    virgula = false;
                    label1.Text = "";
                }
                
                if (e.KeyCode == Keys.Multiply)
                {
                    op.a = Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    vezes = true;
                    virgula = false;
                    label1.Text = "";
                }
                if (e.KeyCode == Keys.Divide)
                {
                    op.a = Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    div = true;
                    virgula = false;
                    label1.Text = "";
                }
                if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                {
                    textBox1.Clear();
                    virgula = false;
                    label1.Text = "";
                }
            }            

        }

        private void Calculadora_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
