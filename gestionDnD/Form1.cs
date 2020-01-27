using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionDnD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.inputId.KeyDown += new KeyEventHandler(inputId_KeyDown);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(inputId.Text);
                if (Program.ids.Contains(id))
                {
                    label2.Visible = true;
                    label2.Text = "Ese jugador ya está en la lista";
                }
                else
                {
                    Program.ids.Add(id);
                    Program.ids.Sort();
                    listaIds.Text = "Introducidos: " + string.Join(", ", Program.ids);
                    label2.Visible = false;
                }
            }
            catch
            {
                label2.Visible = true;
                label2.Text = "No has introducido un número";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listaIds_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.ids.Any()) {
                this.Hide();
                var form2 = new gestionPrincipal();
                form2.FormClosed += (s, args) => this.Close();
                form2.Show();
            } else {
                MessageBox.Show("Debes introducir al menos una ID");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void inputId_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
