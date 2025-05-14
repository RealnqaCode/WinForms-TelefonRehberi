using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TelefonRehberi;

namespace main
{
    public partial class Form1 : Form
    {

        VeriTabani vt;

        public Form1()
        {
            InitializeComponent();

            string server = "localhost";
            string database = "telefon_rehberi";
            string user = "root";
            string password = "123456789#";
            string port = "3306";

            vt = new VeriTabani(server, database, user, password, port);

            if (string.IsNullOrEmpty(txtAd.Text))
            {
                txtAd.Text = "Adınızı Giriniz";
                txtAd.ForeColor = Color.Gray;
            }

            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                txtSoyad.Text = "Soyadınızı giriniz";
                txtSoyad.ForeColor = Color.Gray;
            }

            if (string.IsNullOrEmpty(txtNumara.Text))
            {
                txtNumara.Text = "Telefon numaranızı girin";
                txtNumara.ForeColor = Color.Gray;
            }

            if (string.IsNullOrEmpty(txtArama.Text))
            {
                txtArama.Text = "Arama";
                txtArama.ForeColor = Color.Gray;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string numara = txtNumara.Text.Trim();

            if (ad != "Adınızı Giriniz" && soyad != "Soyadınızı giriniz" && numara != "Telefon numaranızı girin" && ad != "" && soyad != "" && numara != "" && numara.Length == 11)
            {
                try
                {
                    vt.Connect();
                    string insertQuery = "INSERT INTO kisiler (ad, soyad, telefon_numarasi, telefon_turu) VALUES (@Ad, @Soyad, @TelefonNumarasi, @TelefonTuru)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, vt.Connection);
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@TelefonNumarasi", numara);
                    string telefonTuru = (comboSecim.SelectedIndex == 0) ? "GSM" : "Sabit Telefon";
                    cmd.Parameters.AddWithValue("@TelefonTuru", telefonTuru);
                    cmd.ExecuteNonQuery();
                    vt.Disconnect();
                    MessageBox.Show("Kişi ve telefon numarası başarıyla eklendi.");
                    txtAd_Leave(txtAd, EventArgs.Empty);
                    txtSoyad_Leave(txtSoyad, EventArgs.Empty);
                    txtNumara_Leave(txtNumara, EventArgs.Empty);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL ekleme hatası: " + ex.Message);
                }
            }
            else
            {
                if (ad == "Adınızı Giriniz" || soyad == "Soyadınızı giriniz" || numara == "Telefon numaranızı girin" || ad == "" || soyad == "" || numara == "")
                    MessageBox.Show("Ad, Soyad ve Telefon Numarası boş bırakılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (numara.Length != 11)
                    MessageBox.Show("Telefon numarası 11 haneli olmalıdır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            vt.Connect();
            string selectQuery = "SELECT ad, soyad, telefon_numarasi, telefon_turu FROM kisiler";
            MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, vt.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            vt.Disconnect();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string numara = txtNumara.Text.Trim();

            if (ad != "Adınızı Giriniz" && soyad != "Soyadınızı giriniz" && numara != "Telefon numaranızı girin" && ad != "" && soyad != "" && numara != "")
            {
                try
                {
                    vt.Connect();
                    string deleteQuery = "DELETE FROM kisiler WHERE ad = @Ad AND soyad = @Soyad AND telefon_numarasi = @TelefonNumarasi";
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, vt.Connection);
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@TelefonNumarasi", numara);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kişi ve telefon numarası başarıyla silindi.");
                    txtAd_Leave(txtAd, EventArgs.Empty);
                    txtSoyad_Leave(txtSoyad, EventArgs.Empty);
                    txtNumara_Leave(txtNumara, EventArgs.Empty);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL silme hatası: " + ex.Message);
                }
                finally
                {
                    vt.Disconnect();
                }
            }
            else
            {
                MessageBox.Show("Silinecek bilgileri doğru giriniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string numara = txtNumara.Text.Trim();

            if (ad != "Adınızı Giriniz" && soyad != "Soyadınızı giriniz" && numara != "Telefon numaranızı girin" && ad != "" && soyad != "" && numara != "" && numara.Length == 11)
            {
                try
                {
                    vt.Connect();
                    string updateQuery = "UPDATE kisiler SET telefon_numarasi = @TelefonNumarasi, telefon_turu = @TelefonTuru WHERE ad = @Ad AND soyad = @Soyad";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, vt.Connection);
                    cmd.Parameters.AddWithValue("@TelefonNumarasi", numara);
                    string telefonTuru = (comboSecim.SelectedIndex == 0) ? "GSM" : "Sabit Telefon";
                    cmd.Parameters.AddWithValue("@TelefonTuru", telefonTuru);
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.ExecuteNonQuery();
                    vt.Disconnect();
                    MessageBox.Show("Kişi bilgileri başarıyla güncellendi.");
                    txtAd_Leave(txtAd, EventArgs.Empty);
                    txtSoyad_Leave(txtSoyad, EventArgs.Empty);
                    txtNumara_Leave(txtNumara, EventArgs.Empty);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL güncelleme hatası: " + ex.Message);
                }
            }
            else
            {
                if (ad == "Adınızı Giriniz" || soyad == "Soyadınızı giriniz" || numara == "Telefon numaranızı girin" || ad == "" || soyad == "" || numara == "")
                    MessageBox.Show("Ad, Soyad ve Telefon Numarası boş bırakılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (numara.Length != 11)
                    MessageBox.Show("Telefon numarası 11 haneli olmalıdır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTelefon_Click(object sender, EventArgs e)
        {
            vt.Connect();
            string searchQuery = "SELECT ad, soyad, telefon_numarasi, telefon_turu FROM kisiler WHERE telefon_numarasi LIKE @TelefonNumarasi";
            MySqlCommand cmd = new MySqlCommand(searchQuery, vt.Connection);
            cmd.Parameters.AddWithValue("@TelefonNumarasi", "%" + (txtArama.Text == "Arama" ? "" : txtArama.Text) + "%");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            vt.Disconnect();
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            vt.Connect();
            string searchQuery = "SELECT ad, soyad, telefon_numarasi, telefon_turu FROM kisiler WHERE ad LIKE @Ad OR soyad LIKE @Soyad";
            MySqlCommand cmd = new MySqlCommand(searchQuery, vt.Connection);
            cmd.Parameters.AddWithValue("@Ad", "%" + (txtArama.Text == "Arama" ? "" : txtArama.Text) + "%");
            cmd.Parameters.AddWithValue("@Soyad", "%" + (txtArama.Text == "Arama" ? "" : txtArama.Text) + "%");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            vt.Disconnect();
        }

        private void txtAd_Enter(object sender, EventArgs e)
        {
            if (txtAd.Text == "Adınızı Giriniz")
            {
                txtAd.Text = "";
                txtAd.ForeColor = Color.White;
            }
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                txtAd.Text = "Adınızı Giriniz";
                txtAd.ForeColor = Color.Gray;
            }
        }

        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "Soyadınızı giriniz")
            {
                txtSoyad.Text = "";
                txtSoyad.ForeColor = Color.White;
            }
        }

        private void txtSoyad_Leave(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "")
            {
                txtSoyad.Text = "Soyadınızı giriniz";
                txtSoyad.ForeColor = Color.Gray;
            }
        }

        private void txtNumara_Enter(object sender, EventArgs e)
        {
            if (txtNumara.Text == "Telefon numaranızı girin")
            {
                txtNumara.Text = "";
                txtNumara.ForeColor = Color.White;
            }
        }

        private void txtNumara_Leave(object sender, EventArgs e)
        {
            if (txtNumara.Text == "")
            {
                txtNumara.Text = "Telefon numaranızı girin";
                txtNumara.ForeColor = Color.Gray;
            }
        }

        private void txtArama_Enter(object sender, EventArgs e)
        {
            if (txtArama.Text == "Arama")
            {
                txtArama.Text = "";
                txtArama.ForeColor = Color.White;
            }
        }

        private void txtArama_Leave(object sender, EventArgs e)
        {
            if (txtArama.Text == "")
            {
                txtArama.Text = "Arama";
                txtArama.ForeColor = Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
        }

    }
}