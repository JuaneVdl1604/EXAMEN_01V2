using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_01V2
{
    public partial class Form2 : Form
    {
        private string monedaBase;

        public bool USD { get; private set; }
        public bool MXN { get; private set; }
        public bool CAD { get; private set; }
        public bool EUR { get; private set; }
        public bool YEN { get; private set; }
        public Form2(string monedaBase)
        {
            InitializeComponent();
            this.monedaBase = monedaBase;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch (monedaBase)
            {
                case "USD-Dólares estadounidenses":
                    checkBox_USD.Visible = false;
                    break;
                case "MXN-Pesos mexicanos":
                    checkBox_MEX.Visible = false;
                    break;
                case "CAD-Dólares canadienses":
                    checkBox_CAD.Visible = false;
                    break;
                case "EUR-Euros":
                    checkBox_EUR.Visible = false;
                    break;
                case "JPY-Yenes":

                    checkBox_YEN.Visible = false;
                    break;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            USD = checkBox_USD.Checked;
            MXN = checkBox_MEX.Checked;
            CAD = checkBox_CAD.Checked;
            EUR = checkBox_EUR.Checked;
            YEN = checkBox_YEN.Checked;

            OcultarLabelsYTextBoxes();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        Form1 form1 = new Form1();
        private void OcultarLabelsYTextBoxes()
        {
            if (USD == false)
            {
                form1.label_USD.Visible = false;
                form1.txt_USD.Visible = false;
            }
            if (MXN == false)
            {
                form1.label_MXN.Visible = false;
                form1.txt_MXN.Visible = false;
            }
            if (CAD == false)
            {
                form1.label_CAD.Visible = false;
                form1.txt_CAD.Visible = false;
            }
            if (EUR == false)
            {
                form1.label_EUR.Visible = false;
                form1.txt_EUR.Visible = false;
            }
            if (YEN == false)
            {
                form1.label_YEN.Visible = false;
                form1.txt_YEN.Visible = false;
            }
        }
        public void MonedasDisponibles(string monedaBase)
        {
            switch (monedaBase)
            {
                case "USD-Dólar estadounidense":
                    checkBox_USD.Enabled = false;
                    break;
                case "MXN-Peso mexicano":
                    checkBox_MEX.Enabled = false;
                    break;
                case "CAD-Dólar canadiense":
                    checkBox_CAD.Enabled = false;
                    break;
                case "EUR-Euro":
                    checkBox_EUR.Enabled = false;
                    break;
                case "JPY-Yen japonés":
                    checkBox_YEN.Enabled = false;
                    break;
            }
        }
    }
}
