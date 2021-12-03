using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp4
{
    public partial class Form1 : Form
    {
        int x  = 0;
        int btn_actif;
        //etabire une nouvelle connection
        DataConnection conn = new DataConnection();
        DataTable dt = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
            DataTable ids = new DataTable();
            comboBox_id.Enabled = true;
            textBox_nom.Enabled = false;
            textBox_prenom.Enabled = false;
            btn_ajouter.Enabled = true;
            btn_modifier.Enabled = false;
            btn_supprimer.Enabled = false;
            btn_annuler.Enabled = false;
            btn_confirmer.Enabled = false;
            comboBox_id.Text = null;
            textBox_nom.Clear();
            textBox_prenom.Clear();
            dt = conn.afficher();
            dataGridView1.DataSource = dt;
            ids = conn.selectId();
            comboBox_id.Items.Clear();
            
            for (int i = 0; i < ids.Rows.Count; i++)
            {
                comboBox_id.Items.Add(ids.Rows[i]["Id"]);
            }
            
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            comboBox_id.Enabled = false;
            textBox_nom.Enabled = false;
            textBox_prenom.Enabled = false;
            btn_ajouter.Enabled = true;
            btn_modifier.Enabled = true;
            btn_supprimer.Enabled = true;
            btn_annuler.Enabled = false;
            btn_confirmer.Enabled = false;
            dt = conn.searchItems(comboBox_id.Text);

            /*&& x.ToString() != comboBox_id.Text && dt != null*/
            /*if (comboBox_id.Text == comboBox_id.Items.Count.ToString())
            {
                textBox_nom.Text = dt.Rows[0].ItemArray[1].ToString();
                textBox_prenom.Text = dt.Rows[0].ItemArray[2].ToString();
            }*/

            textBox_nom.Text = dt.Rows[0].ItemArray[1].ToString();
            textBox_prenom.Text = dt.Rows[0].ItemArray[2].ToString();
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            comboBox_id.Enabled = false;
            textBox_nom.Enabled = true;
            textBox_prenom.Enabled = true;
            btn_ajouter.Enabled = false;
            btn_modifier.Enabled = false;
            btn_supprimer.Enabled = false;
            btn_annuler.Enabled = true;
            btn_confirmer.Enabled = true;
            btn_actif = 1;

        }
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            comboBox_id.Enabled = false;
            textBox_nom.Enabled = true;
            textBox_prenom.Enabled = true;
            btn_ajouter.Enabled = false;
            btn_modifier.Enabled = false;
            btn_supprimer.Enabled = false;
            btn_annuler.Enabled = true;
            btn_confirmer.Enabled = true;
            btn_actif = 2;
        }
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            comboBox_id.Enabled = false;
            textBox_nom.Enabled = false;
            textBox_prenom.Enabled = false;
            btn_ajouter.Enabled = false;
            btn_modifier.Enabled = false;
            btn_supprimer.Enabled = false;
            btn_annuler.Enabled = true;
            btn_confirmer.Enabled = true;
            btn_actif = 3;
        }
        private void btn_annuler_Click(object sender, EventArgs e)
        {

            comboBox_id.Enabled = true;
           
            textBox_nom.Enabled = false;
            textBox_prenom.Enabled = false;
            btn_ajouter.Enabled = true;
            btn_modifier.Enabled = false;
            btn_supprimer.Enabled = false;
            btn_annuler.Enabled = false;
            btn_confirmer.Enabled = false;
            textBox_nom.Clear();
            textBox_prenom.Clear();
            btn_actif = 4;
        }
        private void btn_confirmer_Click(object sender, EventArgs e)
        {
            comboBox_id.Enabled = true;
            textBox_nom.Enabled = false;
            textBox_prenom.Enabled = false;
            btn_ajouter.Enabled = true;
            btn_modifier.Enabled = true;
            btn_supprimer.Enabled = true;
            btn_annuler.Enabled = false;
            btn_confirmer.Enabled = false;
            if (btn_actif == 1)
            {
                if (comboBox_id.Text.Length == 0)
                {
                    conn.ajouter(textBox_nom.Text, textBox_prenom.Text);
                }
                else
                {
                    conn.modifier(comboBox_id.Text, textBox_nom.Text, textBox_prenom.Text);
                }
                
                
            }
            else if (btn_actif == 2)
            {
                bool x = conn.modifier(comboBox_id.Text, textBox_nom.Text, textBox_prenom.Text);
                /*if (x == true)
                    MessageBox.Show("personne modifier avec success");
                else
                    MessageBox.Show("personne n'est pas modifiee");*/
            }
            else if (btn_actif == 3)
            {
                bool x = conn.supprimer(comboBox_id.Text);
                /*if (x == true)
                    MessageBox.Show("personne supprimer avec success");
                else
                    MessageBox.Show("personne n'est pas supprimee");*/
               
            }
            if (btn_actif == 3)
            {
                textBox_nom.Clear();
                textBox_prenom.Clear();
                dt = conn.afficher();
                comboBox_id.Items.Clear();
                DataTable ids = new DataTable();
                ids = conn.selectId();
               
                for (int i = 0; i < ids.Rows.Count; i++)
                {
                    comboBox_id.Items.Add(ids.Rows[i]["Id"]);
                }
                
                dataGridView1.DataSource = dt;
                comboBox_id.Text = "";
                btn_actif = 5;
            }
            else
            {
                textBox_nom.Clear();
                textBox_prenom.Clear();
                dt = conn.afficher();
                comboBox_id.Items.Clear();
                DataTable ids = new DataTable();
                ids = conn.selectId();
                
                for (int i = 0; i < ids.Rows.Count; i++)
                {
                    comboBox_id.Items.Add(ids.Rows[i]["Id"]);
                }
                
                dataGridView1.DataSource = dt;
                comboBox_id.Text = "";
                btn_actif = 5;
            }
        }
    }
}
