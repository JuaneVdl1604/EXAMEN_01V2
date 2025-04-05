namespace EXAMEN_01V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmb_Moneda.Items.Add("USD-Dólar estadounidense");
            this.cmb_Moneda.Items.Add("MXN-Peso mexicano");
            this.cmb_Moneda.Items.Add("CAD-Dólar canadiense");
            this.cmb_Moneda.Items.Add("EUR-Euro");
            this.cmb_Moneda.Items.Add("JPY-Yen japonés");
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double cantidad;
            cantidad = double.Parse(txt_Monto.Text);
            String modo = this.cmb_Moneda.SelectedItem.ToString();
            if (cantidad != null)
            {
                Form2 form2 = new Form2(modo);
                form2.MonedasDisponibles(modo);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    ResetLabels();
                    if (modo.StartsWith("USD"))
                    {
                        if (form2.CAD) MostrarConversion(label_CAD, txt_CAD, cantidad * 1.38);
                        if (form2.MXN) MostrarConversion(label_MXN, txt_MXN, cantidad * 19.38);
                        if (form2.YEN) MostrarConversion(label_YEN, txt_YEN, cantidad * 149.77);
                        if (form2.EUR) MostrarConversion(label_EUR, txt_EUR, cantidad * 0.92);
                    }
                    else if (modo.StartsWith("MXN"))
                    {
                        if (form2.CAD) MostrarConversion(label_CAD, txt_CAD, cantidad * 0.07);
                        if (form2.USD) MostrarConversion(label_USD, txt_USD, cantidad * 0.05);
                        if (form2.YEN) MostrarConversion(label_YEN, txt_YEN, cantidad * 7.73);
                        if (form2.EUR) MostrarConversion(label_EUR, txt_EUR, cantidad * 0.05);
                    }
                    else if (modo.StartsWith("CAD"))
                    {
                        if (form2.USD) MostrarConversion(label_USD, txt_USD, cantidad * 0.72);
                        if (form2.MXN) MostrarConversion(label_MXN, txt_MXN, cantidad * 14.05);
                        if (form2.YEN) MostrarConversion(label_YEN, txt_YEN, cantidad * 108.56);
                        if (form2.EUR) MostrarConversion(label_EUR, txt_EUR, cantidad * 0.66);
                    }
                    else if (modo.StartsWith("EUR"))
                    {
                        if (form2.CAD) MostrarConversion(label_CAD, txt_CAD, cantidad * 1.50);
                        if (form2.MXN) MostrarConversion(label_MXN, txt_MXN, cantidad * 21.13);
                        if (form2.YEN) MostrarConversion(label_YEN, txt_YEN, cantidad * 163.31);
                        if (form2.USD) MostrarConversion(label_USD, txt_USD, cantidad * 1.09);
                    }
                    else if (modo.StartsWith("JPY"))
                    {
                        if (form2.CAD) MostrarConversion(label_CAD, txt_CAD, cantidad * 0.0092);
                        if (form2.MXN) MostrarConversion(label_MXN, txt_MXN, cantidad * 0.1293);
                        if (form2.EUR) MostrarConversion(label_EUR, txt_EUR, cantidad * 0.0061);
                        if (form2.USD) MostrarConversion(label_USD, txt_USD, cantidad * 0.0067);
                    }

                }

            }
        }
        private void ResetLabels()
        {
            label_CAD.Visible = false;
            txt_CAD.Visible = false;
            label_MXN.Visible = false;
            txt_MXN.Visible = false;
            label_USD.Visible = false;
            txt_USD.Visible = false;
            label_YEN.Visible = false;
            txt_YEN.Visible = false;
            label_EUR.Visible = false;
            txt_EUR.Visible = false;
        }
        private void MostrarConversion(Label lbl, TextBox txt, double valor)
        {
            lbl.Visible = true;
            txt.Visible = true;
            txt.Text = valor.ToString("#,##0.00");
        }


    }
}

