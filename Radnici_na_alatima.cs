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
    public partial class Radnici_na_alatima : Form
    {
        public Radnici_na_alatima()
        {
            InitializeComponent();
        }

        private void prikazi_radnikalat_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server = localhost; port = 3306; uid = root; pwd = badel1862; database = baze2_projekt; ";
                string upit = "select * from baze2_projekt.alat_radnik;";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand command = new MySqlCommand(upit, conn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = command;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                datagrid_radnikalat.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void unesi_radnikalat_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;port=3306;uid=root;pwd=badel1862;database=baze2_projekt;";
                string upit = "insert into baze2_projekt.alat_radnik(ID_alatradnik, alatradnikID_alat,radnik_OIB,vrijeme_od,vrijeme_do) values('" + this.idalataradnika_box.Text + "', '" + this.idalatradnik_box.Text + "','" + this.oib_alatradnik_box.Text + "',' " + this.vrijemeod_box.Text + "','" + this.vrijemedo_box.Text + "');";
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

        private void uredi_radnikalat_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;port=3306;uid=root;pwd=badel1862;database=baze2_projekt;";
            string upit = "UPDATE baze2_projekt.alat_radnik SET radnik_OIB= '" + oib_alatradnik_box.Text + "', vrijeme_od= '" + vrijemeod_box.Text + "', vrijeme_do= '" + vrijemedo_box.Text+ "', alatradnikID_alat='" + idalatradnik_box.Text+ "' WHERE ID_alatradnik='" + int.Parse(idalataradnika_box.Text) + "'";
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

        private void izbrisi_radnikalat_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;port=3306;uid=root;pwd=badel1862;database=baze2_projekt;";
                string upit = "delete from baze2_projekt.alat_radnik where ID_alatradnik='" + this.idalataradnika_box.Text + "';";
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
