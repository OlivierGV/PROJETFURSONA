using System.Text.RegularExpressions;

namespace WinFormDemonstratif
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue sur FursonaMaker!");
            MessageBox.Show("Entrez le nom de votre personnage et son niveau.");
            MessageBox.Show("S�lectionnez les ennemis vaincus.");
            MessageBox.Show("Si vous voulez manuellement ajouter un niveau, utilisez le TrackBar.");
        }

        private void buttonLevel_Click(object sender, EventArgs e)
        {
            /** V�rification du niveau donn� **/
            if (textBoxLevel.Text == "")
            {
                MessageBox.Show("Veuillez entrer un niveau ad�quat.");
            }
            Regex regex = new Regex("[0-9]");
            if (!regex.IsMatch(textBoxLevel.Text))
            {
                MessageBox.Show("Veuillez entrer seulement des nombres comme niveau.");
            }
            /** V�rification qu'au moins une Checkbox soit coch�e + calcul **/
            int experience = 0;
            int gbm = 15;
            int gbsoldat = 15;
            int gbs = 20;
            if (checkBoxGBM.Checked)
            {
                experience += gbm;
            }
            if (checkBoxGBS.Checked)
            {
                experience += gbs;
            }
            if (checkBoxGBSoldat.Checked)
            {
                experience += gbsoldat;
            }
            if (!checkBoxGBM.Checked && !checkBoxGBS.Checked && !checkBoxGBSoldat.Checked)
            {
                MessageBox.Show("S�lectionnez au moins un type de monstre tu�.");
            }
            /** Calculer les niveaux ajout�s en fonction de la trackbar **/
            int niveau = int.Parse(textBoxLevel.Text);
            niveau += trackBarManuel.Value;
            textBoxLevel.Text = niveau.ToString();
            /** Calculer l'xp de la progress bar **/
            int xp_necessaire = niveau * 50;
            progressBarNiveau.Maximum = xp_necessaire;
            if(progressBarNiveau.Value > progressBarNiveau.Maximum)
            {
                progressBarNiveau.Value = 0;
                MessageBox.Show("Level Up!");
            }
            else
            {
                progressBarNiveau.Value += experience;
            }

        }
    }
}