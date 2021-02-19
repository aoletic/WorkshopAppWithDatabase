using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Baze2_MOZAIK
{
    public partial class Alat : Form
    {
        public Alat()
        {
            InitializeComponent();
        }

        private void prikazi_alati_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server = localhost; port = 3306; uid = root; pwd = badel1862; database = baze2_projekt; ";
                string upit = "select * from baze2_projekt.alat;";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand command = new MySqlCommand(upit, conn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = command;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                datagrid_alati.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;port=3306;uid=root;pwd=badel1862;database=baze2_projekt;";
                string upit = "insert into baze2_projekt.alat(ID_alat,naziv_alata,starost_alata) values('" + this.idalata_box.Text + "','" + this.nazivalata_box.Text + "','" + this.starostalata_box.Text + "');";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand command = new MySqlCommand(upit, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Spremljeno u bazu podataka!");
                while (reader.Read())
                {
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;port=3306;uid=root;pwd=badel1862;database=baze2_projekt;";
            string upit = "UPDATE baze2_projekt.alat SET naziv_alata= '" + nazivalata_box.Text + "', starost_alata= '" + starostalata_box.Text + "' WHERE ID_alat ='" + int.Parse(idalata_box.Text)+"'";
            try
            {
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand command = new MySqlCommand(upit, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Spremljeno u bazu podataka!");
                while (reader.Read())
                {
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;port=3306;uid=root;pwd=badel1862;database=baze2_projekt;";
                string upit = "delete from baze2_projekt.alat where ID_alat='" + this.idalata_box.Text + "';";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand command = new MySqlCommand(upit, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Izbrisano iz baze podataka!");
                while (reader.Read())
                {
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datagrid_alati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
      
          
        
    
}
