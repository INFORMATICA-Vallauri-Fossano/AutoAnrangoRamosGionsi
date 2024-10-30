using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnrangoRamosLibrary;

namespace AutoAnrangoRamosGionsi
{
    internal class clsAutoAnrangoRamos
    {
        private bool stato;
        private int numeroGiri;
        ProgressBar prgb;

        private const int min = 600;
        private const int max = 7000;

        //DELEGATI
        public delegate void superatoMassimo();
        public event  superatoMassimo overMax;

        public delegate void inferioreMin();
        public event inferioreMin underMin;

        public int NumeroGiri
        {
            get => numeroGiri;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Bisogna almeno avere un giro");
                else numeroGiri = value;
            }
        }
        public bool Stato
        {
            get=>stato;
            set => stato = value;
        }
        //COSTRUTTORE
        public clsAutoAnrangoRamos(ProgressBar _prgb) {
            prgb = _prgb;
            prgb.Minimum = 0;
            prgb.Maximum=max;
        }

        public void Accendi()
        {
            if (Stato) throw new Exception("Auto già accesa");
            else
            {
                Stato = true;
                NumeroGiri = 600;
            }
        }
        public void Spegni()
        {
            if (!Stato) throw new Exception("Auto già spenta");
            else
            {
                Stato = false;
                NumeroGiri = 0;
            }
        }
        public void Accelera()
        {
            if (Stato) NumeroGiri += 500;
            else throw new Exception("Auto Spenta");
        }

        public void Frena()
        {
            if (Stato) NumeroGiri -= 500;
            else throw new Exception("Auto Spenta");
        }
        public void Visualizza()
        {
            if (stato)
            {
                if (NumeroGiri > max)
                    overMax.Invoke();
                else if (numeroGiri < min)
                    underMin.Invoke();
                else
                {
                    prgb.Value = NumeroGiri;
                }
            }
            else prgb.Value = 0;
        }
    }
}
