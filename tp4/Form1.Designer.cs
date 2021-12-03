
namespace tp4
{
    partial class Form1
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
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.txt_Id = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.Label();
            this.txt_Prenom = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_id
            // 
            this.comboBox_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_id.Location = new System.Drawing.Point(150, 78);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(173, 28);
            this.comboBox_id.TabIndex = 0;
            this.comboBox_id.SelectedIndexChanged += new System.EventHandler(this.comboBox_id_SelectedIndexChanged);
            // 
            // txt_Id
            // 
            this.txt_Id.AutoSize = true;
            this.txt_Id.Location = new System.Drawing.Point(52, 81);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(23, 20);
            this.txt_Id.TabIndex = 1;
            this.txt_Id.Text = "Id";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(150, 138);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(173, 26);
            this.textBox_nom.TabIndex = 2;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(150, 197);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(173, 26);
            this.textBox_prenom.TabIndex = 3;
            // 
            // txt_Nom
            // 
            this.txt_Nom.AutoSize = true;
            this.txt_Nom.Location = new System.Drawing.Point(52, 141);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(42, 20);
            this.txt_Nom.TabIndex = 4;
            this.txt_Nom.Text = "Nom";
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.AutoSize = true;
            this.txt_Prenom.Location = new System.Drawing.Point(52, 200);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(64, 20);
            this.txt_Prenom.TabIndex = 5;
            this.txt_Prenom.Text = "Prenom";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(122, 358);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(146, 48);
            this.btn_ajouter.TabIndex = 6;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(274, 359);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(146, 47);
            this.btn_modifier.TabIndex = 7;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(426, 358);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(146, 48);
            this.btn_supprimer.TabIndex = 8;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(578, 358);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(146, 47);
            this.btn_annuler.TabIndex = 9;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.Location = new System.Drawing.Point(730, 358);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(146, 47);
            this.btn_confirmer.TabIndex = 10;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = true;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(575, 239);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.comboBox_id);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.Label txt_Id;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.Label txt_Nom;
        private System.Windows.Forms.Label txt_Prenom;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

