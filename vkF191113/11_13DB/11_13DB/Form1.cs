using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace _11_13DB
{
    public partial class Form1 : Form
    {
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            //SqlConnection conn;
            conn = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; Database=naplo");

            //string connectionsString = @"Server = (localdb)\MSSQLLocalDB; Database=naplo";
            //var conn = new SqlConnection(connectionsString);
            Fill();
        }

        private void Fill()
        {
            Tb_1.Clear();

            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM jegyek;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                //Rich Textbox kiiratás

                //Tb_1.Text += $"{r[1]} \t {r[2]} \t {r[3]} \t {r[4]} \t {r[5]} \n";
                Tb_1.Text += string.Format("{0, -18} {1,9} {2, 19} {3} {4} \n",
                    r[1], 
                    r.GetDateTime(2).ToString("MMM dd"),
                    r[3],
                    r.GetBoolean(4) ? "TZ" : "  ", 
                    r[5]);

                dgv_jegyek.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5]);

                //paraméteres kiírás
                Console.WriteLine("{0}", 12);
            }
            conn.Close();
        }

        private void Bt_1_Click(object sender, EventArgs e)
        {
            conn.Open();

            //INSERT: nem-lekérdezés




            var adapter = new SqlDataAdapter();
            //SZÓKÖZ MINDIG LEGYEN HA ÚJ SORBA KEZDÜNK

            adapter.InsertCommand = new SqlCommand(
                "INSERT INTO jegyek (Nev, Datum, Tema, Tz, Jegy) " +
                $"VALUES ('{tb_nev.Text}', " +
                $"'{dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss")}', " +
                $"'{tb_tema.Text}', " +
                $"{(checkBox_tz.Checked ? 1 : 0)}, " +
                $"{numericUpDown1.Value});", conn); 
            //text, datum, text, bit(0 OR 1), int
            //Datetime:
            //d - 1
            //dd - 01
            //dd - 01, hétfő

            adapter.InsertCommand.ExecuteNonQuery();

            //CHECKBOX

            conn.Close();
            MessageBox.Show("Adatok rögzítése megtörtént!");

            //InsertCommand = beszúrás
            //InsertCommand = törlés
            //InsertCommand = fejlesztés

            dgv_jegyek.Refresh();
            Fill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //PROPERTIES
            //REALONLY TRUE
            //MIN-MAX VALUE
            //VALUE-val kérdezzük le az értékét


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Dgv_jegyek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgv_jegyek[e.ColumnIndex, e.RowIndex].Value.ToString());
        }
    }
}
