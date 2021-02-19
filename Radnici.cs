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
    public partial class Radnici : Form
    {
        public Radnici()
        {
            InitializeComponent();
        }

        private void prikazi_radnici_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server = localhost; port = 3306; uid = root; pwd = badel1862; database = baze2_projekt; ";
                string upit = "select * from baze2_projekt.radnik;";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand command = new MySqlCommand(upit, conn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = command;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                datagrid_radnici.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void unesi_radnici_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;port=3306;uid=root;pwd=badel1862;database=baze2_projekt;";
                string upit = "insert into baze2_projekt.radnik(OIB,prez_ime,datum_rodenja,godine_staza) values('" + this.oibradnici_box.Text + "','" + this.prez_ime_box.Text + "','" + this.datum_rodenja_box.Text + "',' " + this.godine_staza_box.Text + "');";
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

        private void uredi_radnici_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;port=3306;uid=root;pwd=badel1862;database=baze2_projekt;";
            string upit = "UPDATE baze2_projekt.radnik SET prez_ime= '" + prez_ime_box.Text + "', datum_rodenja= '" + datum_rodenja_box.Text + "', godine_staza= '" + godine_staza_box.Text+ "' WHERE OIB='" + Int64.Parse(oibradnici_box.Text)+"'";
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

        private void izbrisi_radnici_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;port=3306;uid=root;pwd=badel1862;database=baze2_projekt;";
                string upit = "delete from baze2_projekt.radnik where OIB='" + this.oibradnici_box.Text + "';";
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
    }
}
