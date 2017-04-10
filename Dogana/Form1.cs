using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Dogana
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region topMostButton
        private void CheckTopMost_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTopMost.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }
#endregion


        #region Entries
        private void kalkulo_Click(object sender, EventArgs e)
        {
            double vlera_akcizes = 0;
            double vlera_tvsh = 0;
            string euro = "€";
            total1.Font = new Font(tvsh1.Font.FontFamily, 20);
            total2.Font = new Font(tvsh1.Font.FontFamily, 20);
#endregion
        #region Kubik 0-2000


            try
            {

                if (Regex.IsMatch(Viti_prodhimit.Text, "[ ^ 0-9]") && Regex.IsMatch(vlera.Text, "[ ^ 0-9]"))
                {


                    double Viti_val = double.Parse(Viti_prodhimit.Text);
                    double Vlera_val = double.Parse(vlera.Text); //Fix this
                    double tatimi_vleres = Vlera_val * 0.10;
                    double max_tvsh = (Vlera_val + tatimi_vleres) * 0.18;
                    #region Kubik 2001-3000

                    

                    #endregion


                    if (Viti_val == 2017 && dymi.Checked)
                    {
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = max_tvsh.ToString() + euro;


                        total1.Text = Convert.ToString(tatimi_vleres + max_tvsh + euro);
                        total2.Text = Convert.ToString(tatimi_vleres + max_tvsh + Vlera_val + euro);
                    }
                    else if (Viti_val <= 2016 && Viti_val >= 2009 && dymi.Checked)
                    {
                        vlera_akcizes = 400;
                        vlera_tvsh = 72;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);


                    }
                    else if (Viti_val == 2008 && dymi.Checked)
                    {
                        vlera_akcizes = 600;
                        vlera_tvsh = 108;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);

                    }
                    else if (Viti_val == 2007 && dymi.Checked)
                    {
                        vlera_akcizes = 700;
                        vlera_tvsh = 126;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);

                    }
                    else if (Viti_val == 2006 && dymi.Checked)
                    {
                        vlera_akcizes = 800;
                        vlera_tvsh = 144;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);

                    }
                    else if (Viti_val == 2005 && dymi.Checked)
                    {
                        vlera_akcizes = 900;
                        vlera_tvsh = 162;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);

                    }
                    else if (Viti_val == 2004 && dymi.Checked)
                    {
                        vlera_akcizes = 1000;
                        vlera_tvsh = 180;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);

                    }
                    else if (Viti_val == 2003 && dymi.Checked)
                    {
                        vlera_akcizes = 1100;
                        vlera_tvsh = 198;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);

                    }
                    else if (Viti_val == 2002 && dymi.Checked)
                    {
                        vlera_akcizes = 1200;
                        vlera_tvsh = 216;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);

                    }
                    else if (Viti_val == 2001 && dymi.Checked)
                    {
                        vlera_akcizes = 1300;
                        vlera_tvsh = 234;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);

                    }
                    else if (Viti_val <= 2000 && dymi.Checked)
                    {
                        vlera_akcizes = 1500;
                        vlera_tvsh = 270;
                        akciza1.Text = vlera_akcizes.ToString() + euro;
                        tatimi1.Text = tatimi_vleres.ToString("N0") + euro;
                        tvsh1.Text = Convert.ToString(max_tvsh + vlera_tvsh) + euro;

                        total1.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + vlera_tvsh + euro);
                        total2.Text = Convert.ToString(vlera_akcizes + tatimi_vleres + max_tvsh + Vlera_val + vlera_tvsh + euro);

                    }
                }
                else
                {
                    MessageBox.Show("Vetem numra");

                }

            }

            catch (Exception)
            {

                MessageBox.Show("Vetem numra");
            }


        }
        #endregion
 

        #region Main_context_menu
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2017";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2016";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2015";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2014";
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2013";
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2012";
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2011";
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2010";
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2009";
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2008";
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2007";
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2006";
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2005";
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2004";
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2003";
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2002";
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2001";
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "2000";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "";
            vlera.Text = "";
            akciza1.Text = "";
            tatimi1.Text = "";
            tvsh1.Text = "";
            total1.Text = "";
            total2.Text = "";
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viti_prodhimit.Text = "";
            vlera.Text = "";
            akciza1.Text = "";
            tatimi1.Text = "";
            tvsh1.Text = "";
            total1.Text = "";
            total2.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolTip_1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
    #endregion
}