namespace WindowsFormsApp1
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
            this.adresse = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.Location = new System.Drawing.Point(62, 201);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(80, 20);
            this.adresse.TabIndex = 0;
            this.adresse.Text = "Adresse : ";
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.Location = new System.Drawing.Point(62, 346);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(96, 20);
            this.telephone.TabIndex = 2;
            this.telephone.Text = "Téléphone : ";
            this.telephone.Click += new System.EventHandler(this.telephone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "FICHE INFOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(61, 116);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(81, 30);
            this.nom.TabIndex = 7;
            this.nom.Text = "Nom : ";
            this.nom.Click += new System.EventHandler(this.label2_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(65, 149);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(282, 26);
            this.name.TabIndex = 8;
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(66, 237);
            this.adress.Multiline = true;
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(281, 80);
            this.adress.TabIndex = 9;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(65, 384);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(282, 26);
            this.tel.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 492);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.adresse);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.Label telephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox tel;
    }
}