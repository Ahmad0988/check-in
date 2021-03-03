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
    public partial class Form2 : Form
    {
        private String vb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\insaa\source\repos\projekt\check_In.mdf;Integrated Security=True;Connect Timeout=30";
        private String id = "", gepaeckLabel = "";
        private int gewichtswert = 0;
        private bool wiegenOk = false, erstWiegn = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            if(ticketNummer.Text == "")
            {
                MessageBox.Show("Bitte Ticketnummer eingeben!");
            }
            else
            {
                try
                {

                    SqlConnection conn = new SqlConnection(vb);
                    String sql = String.Format("SELECT t_id " +
                                 "FROM tickets " +
                                 "WHERE ticketNummer = '{0}'", ticketNummer.Text);

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    id = cmd.ExecuteScalar().ToString();

                    conn.Close();

                    sql = String.Format("SELECT * " +
                                 "FROM tickets AS t , passagiere AS p , fluege AS f " +
                                 "WHERE t.t_id = '{0}'" +
                                 "AND p.p_id = t.p_id", id);
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        nachName.Text      = sdr["nachName"].ToString();
                        vorName.Text       = sdr["vorName"].ToString();
                        DateTime date1     = new DateTime();
                        date1              = Convert.ToDateTime(sdr["geburstDatum"].ToString());
                        geburstDatum.Text  = date1.ToShortDateString();
                        geburstOrt.Text    = sdr["geburstOrt"].ToString();
                        strasse.Text       = sdr["strasse"].ToString();
                        plz.Text           = sdr["plz"].ToString();
                        ort.Text           = sdr["ort"].ToString();
                        nationalitaet.Text = sdr["nationalitaet"].ToString();
                        passNummer.Text    = sdr["passnummer"].ToString();
                        flugNummer.Text    = sdr["flugNummer"].ToString();
                        abflugZeit.Text    = sdr["abflugZeit"].ToString();
                        ankunftZeit.Text   = sdr["ankunftZeit"].ToString();
                        stratOrt.Text      = sdr["startOrt"].ToString();
                        zielOrt.Text       = sdr["zielOrt"].ToString();
                        sitzPlatzNummer.Text = sdr["sitzPlatzNummer"].ToString();

                        if (sdr["standby"].ToString() == "1")
                        {
                            standby.Checked = true;
                        }
                        else
                        {
                            normal.Checked = true;
                            wiegenOk = true;
                        }
                    }
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("TicketNummer nicht gefunden!");

                }
            }
        }

        private void zuruecksetzen_Click(object sender, EventArgs e)
        {
            ticketNummer.Text  = "";
            nachName.Text      = "";
            vorName.Text       = "";
            geburstDatum.Text  = "";
            geburstOrt.Text    = "";
            strasse.Text       = "";
            plz.Text           = "";
            ort.Text           = "";
            nationalitaet.Text = "";
            passNummer.Text    = "";
            flugNummer.Text    = "";
            abflugZeit.Text    = "";
            ankunftZeit.Text   = "";
            stratOrt.Text      = "";
            zielOrt.Text       = "";
            id                 = "";
            gepaeckLabel       = "";
            uebergewicht.Text  = "";
            gebuehr.Text       = "";
            sitzPlatzNummer.Text = "";
            normal.Checked     = false;
            standby.Checked    = false;
            wiegenOk           = false;

        }

        private void gepäckWiegen_Click(object sender, EventArgs e)
        {
            if(ticketNummer.Text == "")
            {
                MessageBox.Show("Bitte Ticketnummer eingeben");
            }
            else
            {
                if (!wiegenOk && id != "")
                {
                    MessageBox.Show("Der Passagier steht auf der Warteliste");
                }
                else if(!wiegenOk && id == "")
                {
                    MessageBox.Show("Bitte Anzeigen cliken");
                }
                else if(wiegenOk && erstWiegn)
                {
                    Random gewicht = new Random();
                    gewichtswert = gewicht.Next(0,21)  ;
                    try
                    {
                        SqlConnection conn = new SqlConnection(vb);
                        String sql = "SELECT * FROM gebuehren";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            if(gewichtswert <= (int)sdr["maxGewicht"])
                            {
                                erstWiegn = false;
                                uebergewicht.Text = String.Format("{0}", 0);
                                gebuehr.Text = String.Format("{0:c}", 0);
                                normalgewicht.Text = String.Format("{0}", gewichtswert);
                                gepaeckLabel = flugNummer.Text + ticketNummer.Text;
                                MessageBox.Show("Die Gepäck wurde gelabelt");
                            }
                            else
                            {
                                erstWiegn = false;
                                normalgewicht.Text = String.Format("{0}", gewichtswert);
                                uebergewicht.Text = (gewichtswert - Convert.ToInt16( sdr["maxGewicht"])).ToString();
                                gebuehr.Text = String.Format("{0:c}", (Convert.ToDecimal(uebergewicht.Text) * Convert.ToDecimal(sdr["gebuehrePorKilo"])));
                                gepaeckLabel = flugNummer.Text + ticketNummer.Text;
                                MessageBox.Show("Die Gepäck wurde gelabelt");
                                
                            }
                        }
                        conn.Close();
                        sql = String.Format("INSERT INTO gepaeckstueke(t_id,gepaeckLabel) " +
                                            "VALUES('{0}','{1}')",
                                            id, gepaeckLabel);
                        cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        int anzahl = cmd.ExecuteNonQuery(); 
                        conn.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Fehler!");
                    }
                }
            }
        }

        private void anwesenheit_Click(object sender, EventArgs e)
        {
            if(id != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(vb);
                    String sql = String.Format("UPDATE tickets " +
                                               "SET anwesenheit = '{0}'" +
                                               " WHERE t_id = '{1}' ", 1, id);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    int anzahl = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Fehler In DatenBank");
                }
                MessageBox.Show("Chack in ok");
            }
            else
            {
                MessageBox.Show("Keine Eingabe");
            }
           
        }

        private void standby_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(vb);
                String sql = String.Format("UPDATE tickets " +
                                           "SET standby = '{0}'" +
                                           " WHERE t_id = '{1}' ", 1, id);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int anzahl = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Fehler In DatenBank");
            }
            wiegenOk = false;


        }

        private void normal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(vb);
                String sql = String.Format("UPDATE tickets " +
                                           "SET standby = '{0}'" +
                                           " WHERE t_id = '{1}' ", 0, id);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int anzahl = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Fehler In DatenBank");
            }
            wiegenOk = true;
        }

        private void formZu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
