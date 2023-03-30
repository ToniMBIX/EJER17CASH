namespace EJER17CASH
{
    partial class FunWithJoeAndBob
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJoeCash = new System.Windows.Forms.Label();
            this.lblBobCash = new System.Windows.Forms.Label();
            this.lblBankCash = new System.Windows.Forms.Label();
            this.buttonDar10Joe = new System.Windows.Forms.Button();
            this.buttonRecibir5Bob = new System.Windows.Forms.Button();
            this.buttonJoe10Bob = new System.Windows.Forms.Button();
            this.buttonBob5Joe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoeCash
            // 
            this.lblJoeCash.AutoSize = true;
            this.lblJoeCash.Location = new System.Drawing.Point(12, 9);
            this.lblJoeCash.Name = "lblJoeCash";
            this.lblJoeCash.Size = new System.Drawing.Size(80, 13);
            this.lblJoeCash.TabIndex = 0;
            this.lblJoeCash.Text = "Joe tiene 50eur";
            // 
            // lblBobCash
            // 
            this.lblBobCash.AutoSize = true;
            this.lblBobCash.Location = new System.Drawing.Point(12, 33);
            this.lblBobCash.Name = "lblBobCash";
            this.lblBobCash.Size = new System.Drawing.Size(88, 13);
            this.lblBobCash.TabIndex = 1;
            this.lblBobCash.Text = "Bob tiene 100eur";
            // 
            // lblBankCash
            // 
            this.lblBankCash.AutoSize = true;
            this.lblBankCash.ForeColor = System.Drawing.Color.Red;
            this.lblBankCash.Location = new System.Drawing.Point(12, 56);
            this.lblBankCash.Name = "lblBankCash";
            this.lblBankCash.Size = new System.Drawing.Size(117, 13);
            this.lblBankCash.TabIndex = 2;
            this.lblBankCash.Text = "La banca tiene: 100eur";
            // 
            // buttonDar10Joe
            // 
            this.buttonDar10Joe.Location = new System.Drawing.Point(15, 87);
            this.buttonDar10Joe.Name = "buttonDar10Joe";
            this.buttonDar10Joe.Size = new System.Drawing.Size(85, 35);
            this.buttonDar10Joe.TabIndex = 6;
            this.buttonDar10Joe.Text = "Dar 10E a Joe";
            this.buttonDar10Joe.UseVisualStyleBackColor = true;
            this.buttonDar10Joe.Click += new System.EventHandler(this.buttonDar10Joe_Click);
            // 
            // buttonRecibir5Bob
            // 
            this.buttonRecibir5Bob.Location = new System.Drawing.Point(106, 87);
            this.buttonRecibir5Bob.Name = "buttonRecibir5Bob";
            this.buttonRecibir5Bob.Size = new System.Drawing.Size(83, 35);
            this.buttonRecibir5Bob.TabIndex = 7;
            this.buttonRecibir5Bob.Text = "Recibir 5E de Bob";
            this.buttonRecibir5Bob.UseVisualStyleBackColor = true;
            this.buttonRecibir5Bob.Click += new System.EventHandler(this.buttonRecibir5Bob_Click);
            // 
            // buttonJoe10Bob
            // 
            this.buttonJoe10Bob.Location = new System.Drawing.Point(15, 128);
            this.buttonJoe10Bob.Name = "buttonJoe10Bob";
            this.buttonJoe10Bob.Size = new System.Drawing.Size(85, 34);
            this.buttonJoe10Bob.TabIndex = 8;
            this.buttonJoe10Bob.Text = "Joe da 10E a Bob";
            this.buttonJoe10Bob.UseVisualStyleBackColor = true;
            this.buttonJoe10Bob.Click += new System.EventHandler(this.buttonJoe10Bob_Click);
            // 
            // buttonBob5Joe
            // 
            this.buttonBob5Joe.Location = new System.Drawing.Point(106, 128);
            this.buttonBob5Joe.Name = "buttonBob5Joe";
            this.buttonBob5Joe.Size = new System.Drawing.Size(83, 34);
            this.buttonBob5Joe.TabIndex = 9;
            this.buttonBob5Joe.Text = "Bob da 5E a Joe";
            this.buttonBob5Joe.UseVisualStyleBackColor = true;
            this.buttonBob5Joe.Click += new System.EventHandler(this.buttonBob5Joe_Click);
            // 
            // FunWithJoeAndBob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 180);
            this.Controls.Add(this.buttonBob5Joe);
            this.Controls.Add(this.buttonJoe10Bob);
            this.Controls.Add(this.buttonRecibir5Bob);
            this.Controls.Add(this.buttonDar10Joe);
            this.Controls.Add(this.lblBankCash);
            this.Controls.Add(this.lblBobCash);
            this.Controls.Add(this.lblJoeCash);
            this.Name = "FunWithJoeAndBob";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJoeCash;
        private System.Windows.Forms.Label lblBobCash;
        private System.Windows.Forms.Label lblBankCash;
        private System.Windows.Forms.Button buttonDar10Joe;
        private System.Windows.Forms.Button buttonRecibir5Bob;
        private System.Windows.Forms.Button buttonJoe10Bob;
        private System.Windows.Forms.Button buttonBob5Joe;
    }
}

