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
    public partial class gestionPrincipal : Form
    {
        public gestionPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plzPV_Click(object sender, EventArgs e)
        {

        }

        private void iniciativa_Click(object sender, EventArgs e)
        {

        }

        private void puntosDeVida_Click(object sender, EventArgs e)
        {

        }

        private void puntosExperiencia_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void claseDeArmadura_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label29_Click_1(object sender, EventArgs e)
        {

        }

        private void plzNombre_Click(object sender, EventArgs e)
        {

        }

        private void listaJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            object currentItem = listaJugadores.SelectedItem;
            var myString = listaJugadores.GetItemText(currentItem);
            var myNumbers = myString.Where(x => char.IsDigit(x)).ToArray();
            var myNewString = new String(myNumbers);
            try
            {
                updateById(Int32.Parse(myNewString));
            }
            catch
            {
                MessageBox.Show("No se ha podido convertir la selección en un numero", "Error", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Leer Tabla Inv
            gestorDB.tablaInv sendInv;

            sendInv.id = Int32.Parse(plzId.Text);
            sendInv.slot1 = slot1.Text;
            sendInv.slot2 = slot2.Text;
            sendInv.slot3 = slot3.Text;
            sendInv.slot4 = slot4.Text;
            sendInv.slot5 = slot5.Text;
            sendInv.slot6 = slot6.Text;
            sendInv.slot7 = slot7.Text;
            sendInv.slot8 = slot8.Text;
            sendInv.slot9 = slot9.Text;
            sendInv.slot10 = slot10.Text;
            sendInv.slot11 = slot11.Text;
            sendInv.slot12 = slot12.Text;
            sendInv.slot13 = slot13.Text;
            sendInv.slot14 = slot14.Text;
            sendInv.slot15 = slot15.Text;
            sendInv.slot16 = slot16.Text;
            sendInv.slot17 = slot17.Text;
            sendInv.slot18 = slot18.Text;
            sendInv.slot19 = slot19.Text;
            sendInv.slot20 = slot20.Text;
            sendInv.oro = Int32.Parse(plzOro.Text);
            sendInv.plata = Int32.Parse(plzPlata.Text);
            sendInv.cobre = Int32.Parse(plzCobre.Text);

            gestorDB.sendInv(sendInv.id, sendInv);

            // Leer Tabla Mod Salvación
            gestorDB.tablaMod sendMod;

            sendMod.id = Int32.Parse(plzId.Text);
            sendMod.Fuerza = Int32.Parse(plzSalvFuerza.Text);
            sendMod.Destreza = Int32.Parse(plzSalvDestreza.Text);
            sendMod.Constitucion = Int32.Parse(plzSalvConstitucion.Text);
            sendMod.Inteligencia = Int32.Parse(plzSalvInteligencia.Text);
            sendMod.Sabiduria = Int32.Parse(plzSalvSabiduria.Text);
            sendMod.Carisma = Int32.Parse(plzSalvCarisma.Text);

            gestorDB.sendMod(sendMod.id, sendMod);

            // Leer Tabla Stats
            gestorDB.tablaStats sendStats;

            sendStats.id = Int32.Parse(plzId.Text);
            sendStats.Nombre = plzNombre.Text;
            sendStats.Nivel = Int32.Parse(plzLvl.Text);
            sendStats.PX = Int32.Parse(plzPX.Text);
            sendStats.PXActuales = Int32.Parse(plzPXActuales.Text);
            sendStats.Iniciativa = Int32.Parse(plzIniciativa.Text);
            sendStats.Velocidad = Int32.Parse(plzVelocidad.Text);
            sendStats.CA = Int32.Parse(plzCA.Text);
            sendStats.PV = Int32.Parse(plzPV.Text);
            sendStats.PVActuales = Int32.Parse(plzPVActuales.Text);
            sendStats.Fuerza = Int32.Parse(plzFuerza.Text);
            sendStats.Destreza = Int32.Parse(plzDestreza.Text);
            sendStats.Constitucion = Int32.Parse(plzConstitucion.Text);
            sendStats.Inteligencia = Int32.Parse(plzInteligencia.Text);
            sendStats.Sabiduria = Int32.Parse(plzSabiduria.Text);
            sendStats.Carisma = Int32.Parse(plzCarisma.Text);

            gestorDB.sendStats(sendStats.id, sendStats);

            //Leer Tabla Skills
            gestorDB.tablaSkills sendSkills;

            sendSkills.id = Int32.Parse(plzId.Text);
            sendSkills.Acrobacia = Int32.Parse(plzAcrobacias.Text);
            sendSkills.Atletismo = Int32.Parse(plzAtletismo.Text);
            sendSkills.ConArcano = Int32.Parse(plzConArcano.Text);
            sendSkills.Engano = Int32.Parse(plzEngano.Text);
            sendSkills.Historia = Int32.Parse(plzHistoria.Text);
            sendSkills.Interpretacion = Int32.Parse(plzInterpretacion.Text);
            sendSkills.Intimidacion = Int32.Parse(plzIntimidacion.Text);
            sendSkills.Investigacion = Int32.Parse(plzInvestigacion.Text);
            sendSkills.JuegoManos = Int32.Parse(plzJManos.Text);
            sendSkills.Medicina = Int32.Parse(plzMedicina.Text);
            sendSkills.Naturaleza = Int32.Parse(plzNaturaleza.Text);
            sendSkills.Percepcion = Int32.Parse(plzPercepcion.Text);
            sendSkills.Perspicacia = Int32.Parse(plzPerspicacia.Text);
            sendSkills.Persuasion = Int32.Parse(plzPersuasion.Text);
            sendSkills.Religion = Int32.Parse(plzReligion.Text);
            sendSkills.Sigilo = Int32.Parse(plzSigilo.Text);
            sendSkills.Supervivencia = Int32.Parse(plzSupervivencia.Text);
            sendSkills.TratoAnimales = Int32.Parse(plzTratoAnimales.Text);

            gestorDB.sendSkills(sendSkills.id, sendSkills);
            MessageBox.Show("Se ha actualizado la Base De Datos\ncon la información en la tabla", "Info", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myString = plzId.Text;
            var myNumbers = myString.Where(x => char.IsDigit(x)).ToArray();
            var myNewString = new String(myNumbers);
            try
            {
                updateById(Int32.Parse(myNewString));
            } catch
            {
                MessageBox.Show("Debes seleccionar primero a alguien de la lista", "Error", MessageBoxButtons.OK);
            }
        }

        private void gestionPrincipal_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.ids.Count(); i++) {
                gestorDB.tablaStats stats = gestorDB.getStats(Program.ids[i]);
                listaJugadores.Items.Add(String.Format("{0} ({1})", stats.Nombre, stats.id));
            }
            updateById(Program.ids.First());
        }

        public int numAleatorio(int min, int max) {
            Random r = new Random();
            return r.Next(min, max+1);

        }

        public void updateById(int id) {
            gestorDB.tablaStats stats = gestorDB.getStats(id);

            plzNombre.Text = stats.Nombre;
            plzId.Text = String.Format("{0}", stats.id);
            plzLvl.Text = String.Format("{0}", stats.Nivel);
            plzPX.Text = String.Format("{0}", stats.PX);
            plzPXActuales.Text = String.Format("{0}", stats.PXActuales);
            plzPV.Text = String.Format("{0}", stats.PV);
            plzPVActuales.Text = String.Format("{0}", stats.PVActuales);
            plzIniciativa.Text = String.Format("{0}", stats.Iniciativa);
            plzVelocidad.Text = String.Format("{0}", stats.Velocidad);
            plzCA.Text = String.Format("{0}", stats.CA);
            plzCarisma.Text = String.Format("{0}", stats.Carisma);
            plzSabiduria.Text = String.Format("{0}", stats.Sabiduria);
            plzInteligencia.Text = String.Format("{0}", stats.Inteligencia);
            plzConstitucion.Text = String.Format("{0}", stats.Constitucion);
            plzDestreza.Text = String.Format("{0}", stats.Destreza);
            plzFuerza.Text = String.Format("{0}", stats.Fuerza);

            decimal modCarsima = (stats.Carisma - 10) / 2;
            plzModCarisma.Text = String.Format("({0})", Math.Floor(modCarsima));
            decimal modSabiduria = (stats.Sabiduria - 10) / 2;
            plzModSabiduria.Text = String.Format("({0})", Math.Floor(modSabiduria));
            decimal modInteligencia = (stats.Inteligencia - 10) / 2;
            plzModInteligencia.Text = String.Format("({0})", Math.Floor(modInteligencia));
            decimal modConstitucion = (stats.Constitucion - 10) / 2;
            plzModConstitucion.Text = String.Format("({0})", Math.Floor(modConstitucion));
            decimal modDestreza = (stats.Destreza - 10) / 2;
            plzModDestreza.Text = String.Format("({0})", Math.Floor(modDestreza));
            decimal modFuerza = (stats.Fuerza - 10) / 2;
            plzModFuerza.Text = String.Format("({0})", Math.Floor(modFuerza));

            gestorDB.tablaSkills skills = gestorDB.getSkills(id);

            plzAcrobacias.Text = String.Format("{0}", skills.Acrobacia);
            plzAtletismo.Text = String.Format("{0}", skills.Atletismo);
            plzConArcano.Text = String.Format("{0}", skills.ConArcano);
            plzEngano.Text = String.Format("{0}", skills.Engano);
            plzHistoria.Text = String.Format("{0}", skills.Historia);
            plzInterpretacion.Text = String.Format("{0}", skills.Interpretacion);
            plzIntimidacion.Text = String.Format("{0}", skills.Intimidacion);
            plzInvestigacion.Text = String.Format("{0}", skills.Investigacion);
            plzJManos.Text = String.Format("{0}", skills.JuegoManos);
            plzMedicina.Text = String.Format("{0}", skills.Medicina);
            plzNaturaleza.Text = String.Format("{0}", skills.Naturaleza);
            plzPercepcion.Text = String.Format("{0}", skills.Percepcion);
            plzPerspicacia.Text = String.Format("{0}", skills.Perspicacia);
            plzPersuasion.Text = String.Format("{0}", skills.Persuasion);
            plzReligion.Text = String.Format("{0}", skills.Religion);
            plzSigilo.Text = String.Format("{0}", skills.Sigilo);
            plzSupervivencia.Text = String.Format("{0}", skills.Supervivencia);
            plzTratoAnimales.Text = String.Format("{0}", skills.TratoAnimales);

            gestorDB.tablaMod mods = gestorDB.getMod(id);

            plzSalvCarisma.Text = String.Format("{0}", mods.Carisma);
            plzSalvSabiduria.Text = String.Format("{0}", mods.Sabiduria);
            plzSalvInteligencia.Text = String.Format("{0}", mods.Inteligencia);
            plzSalvConstitucion.Text = String.Format("{0}", mods.Constitucion);
            plzSalvDestreza.Text = String.Format("{0}", mods.Destreza);
            plzSalvFuerza.Text = String.Format("{0}", mods.Fuerza);

            gestorDB.tablaInv inv = gestorDB.getInv(id);

            slot1.Text = inv.slot1;
            slot2.Text = inv.slot2;
            slot3.Text = inv.slot3;
            slot4.Text = inv.slot4;
            slot5.Text = inv.slot5;
            slot6.Text = inv.slot6;
            slot7.Text = inv.slot7;
            slot8.Text = inv.slot8;
            slot9.Text = inv.slot9;
            slot10.Text = inv.slot10;
            slot11.Text = inv.slot11;
            slot12.Text = inv.slot12;
            slot13.Text = inv.slot13;
            slot14.Text = inv.slot14;
            slot15.Text = inv.slot15;
            slot16.Text = inv.slot16;
            slot17.Text = inv.slot17;
            slot18.Text = inv.slot18;
            slot19.Text = inv.slot19;
            slot20.Text = inv.slot20;
            plzOro.Text = String.Format("{0}", inv.oro);
            plzPlata.Text = String.Format("{0}", inv.plata);
            plzCobre.Text = String.Format("{0}", inv.cobre);

            plzClase.Text = gestorDB.getClase(id);
        }

        private void d20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Has sacado un {0}", numAleatorio(1, 20)), "Tirar un D20", MessageBoxButtons.OK);
        }

        private void d12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Has sacado un {0}", numAleatorio(1, 12)), "Tirar un D12", MessageBoxButtons.OK);
        }

        private void d10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Has sacado un {0}", numAleatorio(1, 10)), "Tirar un D10", MessageBoxButtons.OK);
        }

        private void d8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Has sacado un {0}", numAleatorio(1, 8)), "Tirar un D8", MessageBoxButtons.OK);
        }

        private void d6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Has sacado un {0}", numAleatorio(1, 6)), "Tirar un D6", MessageBoxButtons.OK);
        }

        private void d4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Has sacado un {0}", numAleatorio(1, 4)), "Tirar un D4", MessageBoxButtons.OK);
        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            gestorDB.darXPATodos(Program.ids, Int32.Parse(plzPXatodos.Text));
            MessageBox.Show("Se ha sumado " + plzPXatodos.Text + " a todos los jugadores", "Info", MessageBoxButtons.OK);
            updateById(Int32.Parse(plzId.Text));
        }

        private void label62_Click(object sender, EventArgs e)
        {

        }
    }
}
