
namespace Personnage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreer = new System.Windows.Forms.Button();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblVie = new System.Windows.Forms.Label();
            this.txtEtatPerso = new System.Windows.Forms.TextBox();
            this.txtBoxMaxVie = new System.Windows.Forms.TextBox();
            this.lblListPerso = new System.Windows.Forms.Label();
            this.lblMaxVie = new System.Windows.Forms.Label();
            this.listPersos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(400, 50);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(233, 46);
            this.btnCreer.TabIndex = 0;
            this.btnCreer.Text = "Créer personnage";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(152, 58);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(242, 31);
            this.txtBoxLogin.TabIndex = 1;
            this.txtBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLogin_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(54, 61);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(77, 25);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 140);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.Location = new System.Drawing.Point(54, 146);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(61, 25);
            this.lblVie.TabIndex = 4;
            this.lblVie.Text = "Vie : ";
            // 
            // txtEtatPerso
            // 
            this.txtEtatPerso.Location = new System.Drawing.Point(59, 222);
            this.txtEtatPerso.Name = "txtEtatPerso";
            this.txtEtatPerso.Size = new System.Drawing.Size(574, 31);
            this.txtEtatPerso.TabIndex = 5;
            // 
            // txtBoxMaxVie
            // 
            this.txtBoxMaxVie.Location = new System.Drawing.Point(59, 678);
            this.txtBoxMaxVie.Name = "txtBoxMaxVie";
            this.txtBoxMaxVie.Size = new System.Drawing.Size(574, 31);
            this.txtBoxMaxVie.TabIndex = 8;
            // 
            // lblListPerso
            // 
            this.lblListPerso.AutoSize = true;
            this.lblListPerso.Location = new System.Drawing.Point(54, 284);
            this.lblListPerso.Name = "lblListPerso";
            this.lblListPerso.Size = new System.Drawing.Size(157, 25);
            this.lblListPerso.TabIndex = 9;
            this.lblListPerso.Text = "Personnages : ";
            // 
            // lblMaxVie
            // 
            this.lblMaxVie.AutoSize = true;
            this.lblMaxVie.Location = new System.Drawing.Point(54, 622);
            this.lblMaxVie.Name = "lblMaxVie";
            this.lblMaxVie.Size = new System.Drawing.Size(349, 25);
            this.lblMaxVie.TabIndex = 10;
            this.lblMaxVie.Text = "Personnage ayant le plus de vies : ";
            // 
            // listPersos
            // 
            this.listPersos.FormattingEnabled = true;
            this.listPersos.ItemHeight = 25;
            this.listPersos.Location = new System.Drawing.Point(59, 334);
            this.listPersos.Name = "listPersos";
            this.listPersos.Size = new System.Drawing.Size(574, 254);
            this.listPersos.TabIndex = 11;
            this.listPersos.SelectedIndexChanged += new System.EventHandler(this.listPersos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 782);
            this.Controls.Add(this.listPersos);
            this.Controls.Add(this.lblMaxVie);
            this.Controls.Add(this.lblListPerso);
            this.Controls.Add(this.txtBoxMaxVie);
            this.Controls.Add(this.txtEtatPerso);
            this.Controls.Add(this.lblVie);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.btnCreer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblVie;
        private System.Windows.Forms.TextBox txtEtatPerso;
        private System.Windows.Forms.TextBox txtBoxMaxVie;
        private System.Windows.Forms.Label lblListPerso;
        private System.Windows.Forms.Label lblMaxVie;
        private System.Windows.Forms.ListBox listPersos;
    }
}

