namespace ArduinoApp
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.btnEncenderLed = new System.Windows.Forms.Button();
            this.btnApagarLed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(72, 209);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 0;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(69, 113);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(102, 23);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(71, 82);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(100, 20);
            this.txtPuerto.TabIndex = 2;
            this.txtPuerto.Text = "COM3";
            // 
            // btnEncenderLed
            // 
            this.btnEncenderLed.Location = new System.Drawing.Point(253, 244);
            this.btnEncenderLed.Name = "btnEncenderLed";
            this.btnEncenderLed.Size = new System.Drawing.Size(80, 31);
            this.btnEncenderLed.TabIndex = 3;
            this.btnEncenderLed.Text = "ON";
            this.btnEncenderLed.UseVisualStyleBackColor = true;
            this.btnEncenderLed.Click += new System.EventHandler(this.btnEncenderLed_Click);
            // 
            // btnApagarLed
            // 
            this.btnApagarLed.Location = new System.Drawing.Point(253, 281);
            this.btnApagarLed.Name = "btnApagarLed";
            this.btnApagarLed.Size = new System.Drawing.Size(80, 34);
            this.btnApagarLed.TabIndex = 4;
            this.btnApagarLed.Text = "OFF";
            this.btnApagarLed.UseVisualStyleBackColor = true;
            this.btnApagarLed.Click += new System.EventHandler(this.btnApagarLed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puerto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor obtenido";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApagarLed);
            this.Controls.Add(this.btnEncenderLed);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtValor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Button btnEncenderLed;
        private System.Windows.Forms.Button btnApagarLed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}