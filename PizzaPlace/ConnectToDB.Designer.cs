namespace PizzaPlace
{
    partial class ConnectToDB
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
            this.csatlakozas = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.labelparam = new System.Windows.Forms.Label();
            this.dbsourcefile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // csatlakozas
            // 
            this.csatlakozas.Location = new System.Drawing.Point(261, 96);
            this.csatlakozas.Name = "csatlakozas";
            this.csatlakozas.Size = new System.Drawing.Size(129, 59);
            this.csatlakozas.TabIndex = 0;
            this.csatlakozas.Text = "Csatlakozás";
            this.csatlakozas.UseVisualStyleBackColor = true;
            this.csatlakozas.Click += new System.EventHandler(this.csatlakozas_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(152, 323);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 20);
            this.output.TabIndex = 9;
            // 
            // labelparam
            // 
            this.labelparam.AutoSize = true;
            this.labelparam.Location = new System.Drawing.Point(13, 29);
            this.labelparam.Name = "labelparam";
            this.labelparam.Size = new System.Drawing.Size(144, 20);
            this.labelparam.TabIndex = 11;
            this.labelparam.Text = "Paraméterek forrása:";
            // 
            // dbsourcefile
            // 
            this.dbsourcefile.Location = new System.Drawing.Point(164, 29);
            this.dbsourcefile.Name = "dbsourcefile";
            this.dbsourcefile.Size = new System.Drawing.Size(528, 27);
            this.dbsourcefile.TabIndex = 12;
            // 
            // ConnectToDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 239);
            this.Controls.Add(this.dbsourcefile);
            this.Controls.Add(this.labelparam);
            this.Controls.Add(this.output);
            this.Controls.Add(this.csatlakozas);
            this.Name = "ConnectToDB";
            this.Text = "Kapcsolódás az adatbázishoz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button csatlakozas;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label labelparam;
        private System.Windows.Forms.TextBox dbsourcefile;
       
    }
}

