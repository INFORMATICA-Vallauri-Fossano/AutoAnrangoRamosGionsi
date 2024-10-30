using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAnrangoRamosGionsi
{
    public partial class frmCambioAutomatico : Form
    {
        clsAutoAnrangoRamos macchina;
        public frmCambioAutomatico()
        {
            InitializeComponent();
            macchina = new clsAutoAnrangoRamos(prgbGiriMotore);
            macchina.overMax += rallenta;
            macchina.underMin += spegni;
        }

        private void spegni()
        {
            MessageBox.Show("La macchina ha troppi pochi giri, si spegnerà perchè non può mantenere il moto");
            macchina.Spegni();
            macchina.Visualizza(); lblNGiri.Text=macchina.NumeroGiri.ToString();
        }

        private void rallenta()
        {
            MessageBox.Show("Attenzione Numero Giri del motore superiore al massimo, si rallenterà per evitare danni");
            macchina.Frena();
            macchina.Visualizza(); lblNGiri.Text=macchina.NumeroGiri.ToString();
        }

        private void btnAccendi_Click(object sender, EventArgs e)
        {
            try
            {
            macchina.Accendi();
            macchina.Visualizza(); lblNGiri.Text=macchina.NumeroGiri.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSpegni_Click(object sender, EventArgs e)
        {
            try
            {
                macchina.Spegni();
                macchina.Visualizza(); lblNGiri.Text=macchina.NumeroGiri.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccelera_Click(object sender, EventArgs e)
        {
            try { 
            macchina.Accelera();
            macchina.Visualizza(); lblNGiri.Text=macchina.NumeroGiri.ToString();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btnFrena_Click(object sender, EventArgs e)
        {
            try{ 
            macchina.Frena();
            macchina.Visualizza(); lblNGiri.Text=macchina.NumeroGiri.ToString();
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
