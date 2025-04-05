namespace EXAMEN_01V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cmb_Moneda = new ComboBox();
            txt_Monto = new TextBox();
            btn_Calcular = new Button();
            grpb_Resultados = new GroupBox();
            txt_YEN = new TextBox();
            txt_EUR = new TextBox();
            txt_CAD = new TextBox();
            txt_MXN = new TextBox();
            txt_USD = new TextBox();
            label_YEN = new Label();
            label_EUR = new Label();
            label_CAD = new Label();
            label_MXN = new Label();
            label_USD = new Label();
            grpb_Resultados.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 57);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Moneda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 57);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 0;
            label2.Text = "Monto";
            // 
            // cmb_Moneda
            // 
            cmb_Moneda.FormattingEnabled = true;
            cmb_Moneda.Location = new Point(12, 85);
            cmb_Moneda.Name = "cmb_Moneda";
            cmb_Moneda.Size = new Size(236, 33);
            cmb_Moneda.TabIndex = 1;
            // 
            // txt_Monto
            // 
            txt_Monto.Location = new Point(261, 87);
            txt_Monto.Name = "txt_Monto";
            txt_Monto.Size = new Size(150, 31);
            txt_Monto.TabIndex = 2;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(261, 140);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(150, 34);
            btn_Calcular.TabIndex = 3;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // grpb_Resultados
            // 
            grpb_Resultados.Controls.Add(txt_YEN);
            grpb_Resultados.Controls.Add(txt_EUR);
            grpb_Resultados.Controls.Add(txt_CAD);
            grpb_Resultados.Controls.Add(txt_MXN);
            grpb_Resultados.Controls.Add(txt_USD);
            grpb_Resultados.Controls.Add(label_YEN);
            grpb_Resultados.Controls.Add(label_EUR);
            grpb_Resultados.Controls.Add(label_CAD);
            grpb_Resultados.Controls.Add(label_MXN);
            grpb_Resultados.Controls.Add(label_USD);
            grpb_Resultados.Location = new Point(22, 222);
            grpb_Resultados.Name = "grpb_Resultados";
            grpb_Resultados.Size = new Size(368, 278);
            grpb_Resultados.TabIndex = 4;
            grpb_Resultados.TabStop = false;
            grpb_Resultados.Text = "Conversiones";
            // 
            // txt_YEN
            // 
            txt_YEN.Location = new Point(200, 217);
            txt_YEN.Name = "txt_YEN";
            txt_YEN.Size = new Size(150, 31);
            txt_YEN.TabIndex = 1;
            txt_YEN.Visible = false;
            // 
            // txt_EUR
            // 
            txt_EUR.Location = new Point(200, 160);
            txt_EUR.Name = "txt_EUR";
            txt_EUR.Size = new Size(150, 31);
            txt_EUR.TabIndex = 1;
            txt_EUR.Visible = false;
            // 
            // txt_CAD
            // 
            txt_CAD.Location = new Point(200, 112);
            txt_CAD.Name = "txt_CAD";
            txt_CAD.Size = new Size(150, 31);
            txt_CAD.TabIndex = 1;
            txt_CAD.Visible = false;
            // 
            // txt_MXN
            // 
            txt_MXN.Location = new Point(200, 67);
            txt_MXN.Name = "txt_MXN";
            txt_MXN.Size = new Size(150, 31);
            txt_MXN.TabIndex = 1;
            txt_MXN.Visible = false;
            // 
            // txt_USD
            // 
            txt_USD.Location = new Point(200, 24);
            txt_USD.Name = "txt_USD";
            txt_USD.Size = new Size(150, 31);
            txt_USD.TabIndex = 1;
            txt_USD.Visible = false;
            // 
            // label_YEN
            // 
            label_YEN.AutoSize = true;
            label_YEN.Location = new Point(17, 220);
            label_YEN.Name = "label_YEN";
            label_YEN.Size = new Size(89, 25);
            label_YEN.TabIndex = 0;
            label_YEN.Text = "YEN       ¥";
            label_YEN.Visible = false;
            // 
            // label_EUR
            // 
            label_EUR.AutoSize = true;
            label_EUR.Location = new Point(17, 166);
            label_EUR.Name = "label_EUR";
            label_EUR.Size = new Size(89, 25);
            label_EUR.TabIndex = 0;
            label_EUR.Text = "EUR       €";
            label_EUR.Visible = false;
            // 
            // label_CAD
            // 
            label_CAD.AutoSize = true;
            label_CAD.Location = new Point(17, 118);
            label_CAD.Name = "label_CAD";
            label_CAD.Size = new Size(93, 25);
            label_CAD.TabIndex = 0;
            label_CAD.Text = "CAD       $";
            label_CAD.Visible = false;
            // 
            // label_MXN
            // 
            label_MXN.AutoSize = true;
            label_MXN.Location = new Point(12, 73);
            label_MXN.Name = "label_MXN";
            label_MXN.Size = new Size(97, 25);
            label_MXN.TabIndex = 0;
            label_MXN.Text = "MXN       $";
            label_MXN.Visible = false;
            // 
            // label_USD
            // 
            label_USD.AutoSize = true;
            label_USD.Location = new Point(17, 27);
            label_USD.Name = "label_USD";
            label_USD.Size = new Size(92, 25);
            label_USD.TabIndex = 0;
            label_USD.Text = "USD       $";
            label_USD.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 512);
            Controls.Add(grpb_Resultados);
            Controls.Add(btn_Calcular);
            Controls.Add(txt_Monto);
            Controls.Add(cmb_Moneda);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpb_Resultados.ResumeLayout(false);
            grpb_Resultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_Calcular;
        public ComboBox cmb_Moneda;
        public TextBox txt_Monto;
        private GroupBox grpb_Resultados;
        public Label label_EUR;
        public Label label_CAD;
        public Label label_MXN;
        public Label label_USD;
        public Label label_YEN;
        public TextBox txt_YEN;
        public TextBox txt_EUR;
        public TextBox txt_CAD;
        public TextBox txt_MXN;
        public TextBox txt_USD;
    }
}
