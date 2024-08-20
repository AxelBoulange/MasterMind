using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace MasterMind
{
    public partial class Form1 : Form
    {
       /* Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple, Color.Orange }; */
        string[] couleurs = new string[6] { "R", "B", "V", "J", "M", "O" };
        string[] combinaison = new string[4];
        string[] verif = new string[4];
        bool[] verifbool = new bool[4] { false, false, false, false };
        bool[] combibool = new bool[4] { false, false, false, false };  
        Random rdm = new Random();
        int btncolor1, btncolor2, btncolor3, btncolor4, bonneplace, mauvaiseplace, x = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btn_color1_Click(object sender, EventArgs e)
        {
            btncolor1++;
            if (btncolor1 == 7)
                btncolor1 = 1;
            if (btncolor1 == 1)
            {
                btn_color1.BackColor = Color.Red;
                verif[0] = "R";
            }
            if (btncolor1 == 2)
            {
                btn_color1.BackColor = Color.Blue;
                verif[0] = "B";
            }
            if (btncolor1 == 3)
            {
                btn_color1.BackColor = Color.Green;
                verif[0] = "V";
            }
            if (btncolor1 == 4)
            {
                btn_color1.BackColor = Color.Yellow;
                verif[0] = "J";
            }
            if (btncolor1 == 5)
            {
                btn_color1.BackColor = Color.Brown;
                verif[0] = "M";
            }
            if (btncolor1 == 6)
            {
                btn_color1.BackColor = Color.Orange;
                verif[0] = "O";
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            for (int i = 0; i <= 3; i++)
            {
                int rcolor1 = rdm.Next(0, 6);
                combinaison[i] = couleurs[rcolor1];
            }
            lbl_verif.Text = combinaison[0] + combinaison[1] + combinaison[2] + combinaison[3];
            btn_start.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            lbl_vrai.Visible = true;
            lbl_mal_placer.Visible = true;
            btn_rep.Visible = true;
            label2.Visible = true;
            lbx_essais.Visible = true;
            lbl_victoire.Visible = false;
            btn_verif.Visible = true;
            lbx_essais.Items.Clear();
            lbl_apresvictoire.Text = "";
        }

        private void btn_color2_Click(object sender, EventArgs e)
        {
            btncolor2++;
            if (btncolor2 == 7)
                btncolor2 = 1;
            if (btncolor2 == 1)
            {
                btn_color2.BackColor = Color.Red;
                verif[1] = "R";
            }
            if (btncolor2 == 2)
            {
                btn_color2.BackColor = Color.Blue;
                verif[1] = "B";
            }
            if (btncolor2 == 3)
            {
                btn_color2.BackColor = Color.Green;
                verif[1] = "V";
            }
            if (btncolor2 == 4)
            {
                btn_color2.BackColor = Color.Yellow;
                verif[1] = "J";
            }
            if (btncolor2 == 5)
            {
                btn_color2.BackColor = Color.Brown;
                verif[1] = "M";
            }
            if (btncolor2 == 6)
            {
                btn_color2.BackColor = Color.Orange;
                verif[1] = "O";
            }
        }

        private void btn_color3_Click(object sender, EventArgs e)
        {
            // Button b = (Button)sender;

            btncolor3++;
            if (btncolor3 == 7)
                btncolor3 = 1;
            if (btncolor3 == 1)
            {
                btn_color3.BackColor = Color.Red;
                verif[2] = "R";
            }
            if (btncolor3 == 2)
            {
                btn_color3.BackColor = Color.Blue;
                verif[2] = "B";
            }
            if (btncolor3 == 3)
            {
                btn_color3.BackColor = Color.Green;
                verif[2] = "V";
            }
            if (btncolor3 == 4)
            {
                btn_color3.BackColor = Color.Yellow;
                verif[2] = "J";
            }
            if (btncolor3 == 5)
            {
                btn_color3.BackColor = Color.Brown;
                verif[2] = "M";
            }
            if (btncolor3 == 6)
            {
                btn_color3.BackColor = Color.Orange;
                verif[2] = "O";
            }
        }

        private void btn_rep_Click(object sender, EventArgs e)
        {
            if (lbl_verif.Visible == true)
                lbl_verif.Visible = false;
            else
                lbl_verif.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                int rcolor1 = rdm.Next(0, 6);
                verif[i] = couleurs[rcolor1];
            }
            if (verif[0] == "R")
                btn_color1.BackColor = Color.Red;
            else if (verif[0] == "B")
                btn_color1.BackColor = Color.Blue;
            else if (verif[0] == "V")
                btn_color1.BackColor = Color.Green;
            else if (verif[0] == "J")
                btn_color1.BackColor = Color.Yellow;
            else if (verif[0] == "M")
                btn_color1.BackColor = Color.Brown;
            else
                btn_color1.BackColor = Color.Orange;
            if (verif[1] == "R")
                btn_color2.BackColor = Color.Red;
            else if (verif[1] == "B")
                btn_color2.BackColor = Color.Blue;
            else if (verif[1] == "V")
                btn_color2.BackColor = Color.Green;
            else if (verif[1] == "J")
                btn_color2.BackColor = Color.Yellow;
            else if (verif[1] == "M")
                btn_color2.BackColor = Color.Brown;
            else
                btn_color2.BackColor = Color.Orange;
            if (verif[2] == "R")
                btn_color3.BackColor = Color.Red;
            else if (verif[2] == "B")
                btn_color3.BackColor = Color.Blue;
            else if (verif[2] == "V")
                btn_color3.BackColor = Color.Green;
            else if (verif[2] == "J")
                btn_color3.BackColor = Color.Yellow;
            else if (verif[2] == "M")
                btn_color3.BackColor = Color.Brown;
            else
                btn_color3.BackColor = Color.Orange;
            if (verif[3] == "R")
                btn_color4.BackColor = Color.Red;
            else if (verif[3] == "B")
                btn_color4.BackColor = Color.Blue;
            else if (verif[3] == "V")
                btn_color4.BackColor = Color.Green;
            else if (verif[3] == "J")
                btn_color4.BackColor = Color.Yellow;
            else if (verif[3] == "M")
                btn_color4.BackColor = Color.Brown;
            else
                btn_color4.BackColor = Color.Orange;

        }

        private void lbl_essai_p_Click(object sender, EventArgs e)
        {

        }

        private void btn_color4_Click(object sender, EventArgs e)
        {
            btncolor4++;
            if (btncolor4 == 7)
                btncolor4 = 1;
            if (btncolor4 == 1)
            {
                btn_color4.BackColor = Color.Red;
                verif[3] = "R";
            }
            if (btncolor4 == 2)
            {
                btn_color4.BackColor = Color.Blue;
                verif[3] = "B";
            }
            if (btncolor4 == 3)
            {
                btn_color4.BackColor = Color.Green;
                verif[3] = "V";
            }
            if (btncolor4 == 4)
            {
                btn_color4.BackColor = Color.Yellow;
                verif[3] = "J";
            }
            if (btncolor4 == 5)
            {
                btn_color4.BackColor = Color.Brown;
                verif[3] = "M";
            }
            if (btncolor4 == 6)
            {
                btn_color4.BackColor = Color.Orange;
                verif[3] = "O";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* bouton de vérification*/
            /* remise a 0 des variables*/
            bonneplace = 0;
            mauvaiseplace = 0;
            for (int i = 0; i < 4; i++)
            {
                verifbool[i] = false;
                combibool[i] = false;
            }
            /* verif si victoire */
            if ((verif[0] == combinaison[0]) && (verif[1] == combinaison[1]) && (verif[2] == combinaison[2]) && (verif[3] == combinaison[3]))
            {
                lbl_apresvictoire.Text = "Combinaison : " + verif[0] + " " + verif[1] + " " + verif[2] + " " + verif[3] + " | ( essai n°" + x + " )";
                lbl_apresvictoire.Visible = true;
                lbl_victoire.Visible = true;
                btn_verif.Visible = false;
                pnl1.Visible = false;
                btn_color1.BackColor = Color.White;
                btn_color2.BackColor = Color.White;
                btn_color3.BackColor = Color.White;
                btn_color4.BackColor = Color.White;
                lbl_mal_placer.Text = "X";
                lbl_vrai.Text = "X";
                label3.Visible = false;
                label4.Visible = false;
                lbl_vrai.Visible = false;
                lbl_mal_placer.Visible = false;
                lbl_verif.Visible = false;
                label2.Visible = false;
                lbx_essais.Visible = false;
                lbl_victoire.Visible = true;
                btn_start.Visible = true;
                btn_rep.Visible = false;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (verif[i] == combinaison[i])
                    {
                        /* verif nb de bonne place */
                        verifbool[i] = true;
                        combibool[i] = true;
                        bonneplace = bonneplace + 1;
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    if (verifbool[i] != true)
                    {
                        /* verif nb de mauvaise place */
                        for (int j = 0; j < 4; j++)
                        {
                            if (verif[i] == combinaison[j] && combibool[j] != true)
                            {
                                mauvaiseplace = mauvaiseplace + 1;
                                combibool[j] = true;
                            }
                        }

                    }
                }
                lbl_vrai.Text = Convert.ToString(bonneplace);
                lbl_mal_placer.Text = Convert.ToString(mauvaiseplace);
                x++;
                lbx_essais.Items.Add(" "+ verif[0] + " " + verif[1] + " " + verif[2] + " " + verif[3] + " | vrai : " + bonneplace + "  Mal Placé : " + mauvaiseplace + " ( essai n°" + x + " )");


            }
        }

        private void lbl_test_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}