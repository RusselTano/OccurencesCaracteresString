using System;
using System.Windows.Forms;

namespace OccurencesCaracteresString
{
    public partial class OccurencesCaracteresStringForm : Form
    {
        // Relations plusieurs a plusieurs
        // Table d'association (@ relations 1 a plusieurs)

        private string[] tProgrammes = new string[] { "Application mobile", "Reseautique", "Admin", "Generale", "Environement", "Soudure" };

        private int[] tEmployes = new int[] { 3, 4, 5, 6 };


        private int[] tAssociations = new int[] { 1, 0, 2, 3, 1, 2 };
        //application mobile 0 --> 3 employes
        // reseautique 1 --> 4 emloyes
        //admin 2 --> 5 employes
        //generale 3 --> 6 emplyes
        public OccurencesCaracteresStringForm()
        {
            InitializeComponent();
        }

        private void OccurencesCaracteresStringForm_Load(object sender, EventArgs e)
        {
            programmesListBox.Items.AddRange(tProgrammes);
        }

        private void programmesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int positionListe = programmesListBox.SelectedIndex;

            int positionAssociation = tAssociations[positionListe];

            int nombresEmployes = tEmployes[positionAssociation];

            nombreLabel.Text = programmesListBox.SelectedItem + " : " + nombresEmployes;
        }

        private void rechercherButton_Click(object sender, EventArgs e)
        {
            int position = IndiceListe(programmesListBox, programmesListBox.Text);

            MessageBox.Show("Position = " + position);
        }

        private int IndiceListe(ListBox liste, string item)
        {
            int indiceListeInt = -1;

            if (liste != null && item != null && liste.Items.Count > 0 && item.Length > 0)
            {
                int indiceItemRetrouve = 0;

                do
                {
                    if (String.Compare(liste.Items[indiceItemRetrouve].ToString(), item, StringComparison.CurrentCultureIgnoreCase) == 0)
                    {
                        indiceListeInt = indiceItemRetrouve;
                        indiceItemRetrouve++;
                    }
                } while (indiceListeInt == -1 && indiceItemRetrouve < liste.Items.Count);
            }

            return indiceListeInt;
        }

        private void occurenceButton_Click(object sender, EventArgs e)
        {
            /*
             * Lire premier dossier d'emloye 
             * jusqu'a ce qu'il n'y a plus de dossier dans le fichier (End of File)
             *      Traitement du premier dossier
             *      Lire le prochain dossier de l'employe
             * Prochain
             */
            string cara = "e";
            int occurencesCaracteresInt = OccurencesCaractere(programmesListBox.Text, cara);

            MessageBox.Show("Nombre de " + cara + " : " + occurencesCaracteresInt.ToString());

        }

        private int OccurencesCaractere(string message, string caracteres)
        {
            int occurencesCaracteresInt = 0;

            if(message != null && caracteres != null)
            {
                int positioncaractere;

                positioncaractere = message.IndexOf(caracteres, StringComparison.CurrentCultureIgnoreCase);

                while(positioncaractere != -1)
                {
                    occurencesCaracteresInt++;

                    positioncaractere = message.IndexOf(caracteres, positioncaractere + 1, StringComparison.CurrentCultureIgnoreCase);
                }
            }
            return occurencesCaracteresInt;
        }
    }
}
