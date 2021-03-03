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
    public partial class Form3 : Form
    {
        private String vb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\insaa\source\repos\projekt\check_In.mdf;Integrated Security=True;Connect Timeout=30";
        private const int FLUF_PLAETZE = 12;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                String[] zeile = new string[4];
                SqlConnection conn = new SqlConnection(vb);
                String sql = "SELECT * FROM fluege";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    zeile[0] = sdr["flugNummer"].ToString();
                    zeile[1] = sdr["startOrt"].ToString();
                    zeile[2] = sdr["zielOrt"].ToString();
                    zeile[3] = sdr["abflugZeit"].ToString();

                    ListViewItem lvi_zeile = new ListViewItem(zeile);
                    lviFluege.Items.Add(lvi_zeile);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Fehler!");
            }
        }

        private void lviFluege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lviFluege.SelectedItems.Count > 0)
            {
                
               String flugnummer = lviFluege.SelectedItems[0].SubItems[0].Text;
                //MessageBox.Show(flugnummer);
                String idfluge = "";
                try
                {
                    SqlConnection conn = new SqlConnection(vb);
                    String sql = String.Format("SELECT f_id FROM fluege " +
                                              "WHERE flugNummer = '{0}'", flugnummer);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    idfluge = cmd.ExecuteScalar().ToString();
                    conn.Close();
                    
                    sql = String.Format("SELECT * " +
                                 "FROM tickets AS t , passagiere AS p , fluege AS f " +
                                 "WHERE flugNummer = '{0}'" +
                                 "AND t.f_id = {1}" +
                                 "AND p.p_id = t.p_id", flugnummer, idfluge);
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    lviPIL.Items.Clear();
                    int besetztePlaetze = 0, freiPlaetze = 0, standbyPassagiere = 0;
                    while (sdr.Read())
                    {
                        String[] zeile = new string[6];
                        if (sdr["anwesenheit"].ToString() == "1")
                        {
                            besetztePlaetze++;
                            if (sdr["standby"].ToString() == "0")
                                zeile[3] = "Normal";
                            else
                            {
                                standbyPassagiere++;
                                besetztePlaetze--;
                                continue;
                            }
                            zeile[0] = sdr["ticketNummer"].ToString();
                            zeile[1] = sdr["nachName"].ToString();
                            zeile[2] = sdr["vorName"].ToString();  
                            zeile[4] = sdr["sitzPlatznummer"].ToString();
                            zeile[5] = sdr["passNummer"].ToString();
                            ListViewItem lvi_zeile = new ListViewItem(zeile);
                            lviPIL.Items.Add(lvi_zeile);
                        }
                        
                    }
                    if (besetztePlaetze == 0)
                    {
                        freiPlaetze_.Text = FLUF_PLAETZE.ToString();
                    }
                    else if (besetztePlaetze > 0)
                    {
                        if (besetztePlaetze < FLUF_PLAETZE)
                        {
                            freiPlaetze = FLUF_PLAETZE - besetztePlaetze;
                            freiPlaetze_.Text = freiPlaetze.ToString();
                        }
                    }
                    anZahlPassagiere.Text = standbyPassagiere.ToString();
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Fehler!");
                }
            }
        }

        private void formZu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
