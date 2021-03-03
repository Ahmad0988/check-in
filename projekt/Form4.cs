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
namespace projekt
{
    public partial class Form4 : Form
    {
        private String vb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\insaa\source\repos\projekt\check_In.mdf;Integrated Security=True;Connect Timeout=30";
        private String id = "", tid="",fid="";
        public Form4()
        {
            InitializeComponent();
        }

        private void zuruecksetzen_Click(object sender, EventArgs e)
        {
            labelGepaeck.Text = "";
            lviScann.Items.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void formZu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScannen_Click(object sender, EventArgs e)
        {
            if (labelGepaeck.Text == "")
            {
                MessageBox.Show("Bitte das Label des Gepaecks eingeben!");
            }
            else
            {
                try
                {

                    SqlConnection conn = new SqlConnection(vb);
                    String sql = String.Format("SELECT g_id,t_id " +
                                 "FROM gepaeckstueke " +
                                 "WHERE gepaeckLabel = '{0}'", labelGepaeck.Text);

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        id = sdr["g_id"].ToString();
                        tid = sdr["t_id"].ToString();
                    }

                    conn.Close();
                    sdr.Close();
                    sql = String.Format("SELECT f.f_id " +
                                 "FROM tickets AS t, fluege AS f " +
                                 "WHERE t.t_id = '{0}'", tid);

                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    fid = cmd.ExecuteScalar().ToString();

                    conn.Close();
                    sql = String.Format("SELECT * " +
                                 "FROM gepaeckstueke AS g ,tickets AS t," +
                                 "fluege AS f, passagiere AS p " +
                                 "WHERE g.g_id = '{0}'" +
                                 "AND t.t_id = '{1}'" +
                                 "AND f.f_id = '{2}'" +
                                 "AND p.p_id = t.p_id" 
                                 
                                 , id,tid,fid);
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    
                    sdr = cmd.ExecuteReader();
                    lviScann.Items.Clear();
                    while (sdr.Read())
                    {
                        String[] zeile = new string[6];

                        zeile[0] = sdr["flugNummer"].ToString();
                        zeile[1] = sdr["vorName"].ToString();
                        zeile[2] = sdr["nachName"].ToString();
                        zeile[3] = sdr["passnummer"].ToString();
                        zeile[4] = sdr["startOrt"].ToString();
                        zeile[5] = sdr["zielOrt"].ToString();
        
                        ListViewItem lvi_zeile = new ListViewItem(zeile);
                        lviScann.Items.Add(lvi_zeile);
                       
                    }
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Label des Gepaecks nicht gefunden!");

                }
            }
            }
    }
}
