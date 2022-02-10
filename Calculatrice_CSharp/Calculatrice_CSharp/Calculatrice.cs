using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice_CSharp
{
    public partial class FM_Calculatrice : Form
    {
        public FM_Calculatrice()
        {
            InitializeComponent();
        }

        string operateur="";
        double PremierNombre = 0;
        double Deuxiemenombre = 0;
        Boolean virgule_temp = false;
        Boolean virgule_on = false;
        Boolean negatif_temp = false;
        Boolean negatif_on = false;

        //////////////////////////////////////////// BOUTON 0 à 9 ////////////////////////////////////////////////////////
        private void BTN_chiffre(object sender, EventArgs e)
        {
            Button Chiffre = (Button)sender;

            if ((virgule_temp == false) && (Chiffre.Text == ","))
            {
                TXT_champs.Text += Chiffre.Text;
                virgule_temp = true;
                virgule_on = true;
            }

            if ((negatif_temp == false) && (Chiffre.Text == "(-)"))
            {
                TXT_champs.Text += "-";
                negatif_temp = true;
                negatif_on = true;
            }

            if (Chiffre.Text != ",") 
            {
                if (Chiffre.Text != "(-)")
                {
                    if (virgule_on == true)
                    {
                        TXT_champs.Text += Chiffre.Text;
                        Deuxiemenombre += Convert.ToDouble("," + Chiffre.Text);
                        virgule_on = false;
                    }
                    else if (negatif_on == true)
                    {
                        TXT_champs.Text += Chiffre.Text;
                        Deuxiemenombre += Convert.ToDouble("-" + Chiffre.Text);
                        negatif_on = false;
                    }
                    else
                    {
                        TXT_champs.Text += Chiffre.Text;
                        Deuxiemenombre += Convert.ToDouble(Chiffre.Text);
                    }
                }
            }
        }




        //////////////////////////////////////////// Opérateur ////////////////////////////////////////////////////////
        private void BTN_operateur(object sender, EventArgs e)
        {
            Button BtnOperateur = (Button)sender;
            operateur = BtnOperateur.Text;
            PremierNombre = Convert.ToDouble(TXT_champs.Text);
            TXT_champs.Text += BtnOperateur.Text;
            Deuxiemenombre = 0;
            virgule_temp = false;
            negatif_temp = false;
        }


        //////////////////////////////////////////// Resultat ////////////////////////////////////////////////////////

        private void BTN_result_Click(object sender, EventArgs e)
        {
            switch (operateur)
            {
                case "mod":
                    TXT_champs.Text = Convert.ToString(PremierNombre % Deuxiemenombre);
                    break;

                case "^":
                    TXT_champs.Text = Convert.ToString(Math.Pow(PremierNombre, Deuxiemenombre));
                    break;

                case "+":
                    TXT_champs.Text = Convert.ToString(PremierNombre + Deuxiemenombre);
                    break;

                case "-":
                    TXT_champs.Text = Convert.ToString(PremierNombre - Deuxiemenombre);
                    break;

                case "*":
                    TXT_champs.Text = Convert.ToString(PremierNombre * Deuxiemenombre);
                    break;

                case "/":
                    try
                    {
                        TXT_champs.Text = Convert.ToString(PremierNombre / Deuxiemenombre);
                    }
                    catch (Exception Error)
                    {
                        TXT_champs.Text = Convert.ToString(Error);
                    }
                    break;
            }
        }


        //////////////////////////////////////////// Reset ////////////////////////////////////////////////////////

        private void BTN_reset_Click(object sender, EventArgs e)
        {
            TXT_champs.Text = "";
            virgule_temp = false;
            negatif_temp = false;
        }





  


        /*
    ' 1 - I.H.M 
    ' 2 - opérations avec les nombres positifs et négatifs
    ' 3 - Priorité des calcules, comme les multiplications ou parenthèses
    ' 4 - Cas impossible de divisé par 0, ne pas le faire avec un if mais avec une execption (try, catch)
    ' 5 - Nombre d'opération illimité(5 x 5 + 6 x 5 - 5)
    ' 6 - 1 touche scientifiques
        */
    }
}
