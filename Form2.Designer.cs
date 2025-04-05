namespace EXAMEN_01V2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox_USD = new CheckBox();
            btn_Cancelar = new Button();
            btn_Aceptar = new Button();
            checkBox_MEX = new CheckBox();
            checkBox_CAD = new CheckBox();
            checkBox_EUR = new CheckBox();
            checkBox_YEN = new CheckBox();
            SuspendLayout();
            // 
            // checkBox_USD
            // 
            checkBox_USD.AutoSize = true;
            checkBox_USD.Location = new Point(49, 32);
            checkBox_USD.Name = "checkBox_USD";
            checkBox_USD.Size = new Size(73, 29);
            checkBox_USD.TabIndex = 0;
            checkBox_USD.Text = "USD";
            checkBox_USD.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(61, 233);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(112, 34);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(315, 233);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(112, 34);
            btn_Aceptar.TabIndex = 1;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // checkBox_MEX
            // 
            checkBox_MEX.AutoSize = true;
            checkBox_MEX.Location = new Point(49, 67);
            checkBox_MEX.Name = "checkBox_MEX";
            checkBox_MEX.Size = new Size(78, 29);
            checkBox_MEX.TabIndex = 0;
            checkBox_MEX.Text = "MXN";
            checkBox_MEX.UseVisualStyleBackColor = true;
            // 
            // checkBox_CAD
            // 
            checkBox_CAD.AutoSize = true;
            checkBox_CAD.Location = new Point(49, 102);
            checkBox_CAD.Name = "checkBox_CAD";
            checkBox_CAD.Size = new Size(74, 29);
            checkBox_CAD.TabIndex = 0;
            checkBox_CAD.Text = "CAD";
            checkBox_CAD.UseVisualStyleBackColor = true;
            // 
            // checkBox_EUR
            // 
            checkBox_EUR.AutoSize = true;
            checkBox_EUR.Location = new Point(49, 137);
            checkBox_EUR.Name = "checkBox_EUR";
            checkBox_EUR.Size = new Size(70, 29);
            checkBox_EUR.TabIndex = 0;
            checkBox_EUR.Text = "EUR";
            checkBox_EUR.UseVisualStyleBackColor = true;
            // 
            // checkBox_YEN
            // 
            checkBox_YEN.AutoSize = true;
            checkBox_YEN.Location = new Point(49, 172);
            checkBox_YEN.Name = "checkBox_YEN";
            checkBox_YEN.Size = new Size(70, 29);
            checkBox_YEN.TabIndex = 0;
            checkBox_YEN.Text = "YEN";
            checkBox_YEN.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 317);
            Controls.Add(btn_Aceptar);
            Controls.Add(btn_Cancelar);
            Controls.Add(checkBox_YEN);
            Controls.Add(checkBox_EUR);
            Controls.Add(checkBox_CAD);
            Controls.Add(checkBox_MEX);
            Controls.Add(checkBox_USD);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button btn_Cancelar;
        private Button btn_Aceptar;
        public CheckBox checkBox_USD;
        public CheckBox checkBox_MEX;
        public CheckBox checkBox_CAD;
        public CheckBox checkBox_EUR;
        public CheckBox checkBox_YEN;
    }
}