namespace WinFormDemonstratif
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBoxDND = new System.Windows.Forms.PictureBox();
            this.contextMenuStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.éditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelEnnemis = new System.Windows.Forms.Label();
            this.checkBoxGBS = new System.Windows.Forms.CheckBox();
            this.checkBoxGBM = new System.Windows.Forms.CheckBox();
            this.checkBoxGBSoldat = new System.Windows.Forms.CheckBox();
            this.progressBarNiveau = new System.Windows.Forms.ProgressBar();
            this.trackBarManuel = new System.Windows.Forms.TrackBar();
            this.buttonLevel = new System.Windows.Forms.Button();
            this.labelIndicateur = new System.Windows.Forms.Label();
            this.labelNiveauCaliss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDND)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarManuel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDND
            // 
            this.pictureBoxDND.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDND.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDND.BackgroundImage")));
            this.pictureBoxDND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDND.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDND.Name = "pictureBoxDND";
            this.pictureBoxDND.Size = new System.Drawing.Size(152, 86);
            this.pictureBoxDND.TabIndex = 0;
            this.pictureBoxDND.TabStop = false;
            // 
            // contextMenuStripMenu
            // 
            this.contextMenuStripMenu.Name = "contextMenuStripMenu";
            this.contextMenuStripMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFichier
            // 
            this.toolStripMenuItemFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.éditionToolStripMenuItem,
            this.sauvegarderToolStripMenuItem,
            this.restaurerToolStripMenuItem,
            this.exporterToolStripMenuItem,
            this.importerToolStripMenuItem});
            this.toolStripMenuItemFichier.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItemFichier.Name = "toolStripMenuItemFichier";
            this.toolStripMenuItemFichier.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemFichier.Text = "Fichier";
            // 
            // éditionToolStripMenuItem
            // 
            this.éditionToolStripMenuItem.Name = "éditionToolStripMenuItem";
            this.éditionToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.éditionToolStripMenuItem.Text = "Édition";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            // 
            // restaurerToolStripMenuItem
            // 
            this.restaurerToolStripMenuItem.Name = "restaurerToolStripMenuItem";
            this.restaurerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.restaurerToolStripMenuItem.Text = "Restaurer";
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exporterToolStripMenuItem.Text = "Exporter";
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.importerToolStripMenuItem.Text = "Importer";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNom.Location = new System.Drawing.Point(12, 99);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(116, 15);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom du personnage";
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNom.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxNom.Location = new System.Drawing.Point(14, 114);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 23);
            this.textBoxNom.TabIndex = 0;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLevel.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxLevel.Location = new System.Drawing.Point(14, 157);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(100, 23);
            this.textBoxLevel.TabIndex = 1;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLevel.Location = new System.Drawing.Point(14, 139);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(44, 15);
            this.labelLevel.TabIndex = 4;
            this.labelLevel.Text = "Niveau";
            // 
            // labelEnnemis
            // 
            this.labelEnnemis.AutoSize = true;
            this.labelEnnemis.BackColor = System.Drawing.Color.Transparent;
            this.labelEnnemis.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEnnemis.Location = new System.Drawing.Point(14, 183);
            this.labelEnnemis.Name = "labelEnnemis";
            this.labelEnnemis.Size = new System.Drawing.Size(95, 15);
            this.labelEnnemis.TabIndex = 5;
            this.labelEnnemis.Text = "Ennemis vaincus";
            // 
            // checkBoxGBS
            // 
            this.checkBoxGBS.AutoSize = true;
            this.checkBoxGBS.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxGBS.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxGBS.Location = new System.Drawing.Point(17, 200);
            this.checkBoxGBS.Name = "checkBoxGBS";
            this.checkBoxGBS.Size = new System.Drawing.Size(106, 19);
            this.checkBoxGBS.TabIndex = 6;
            this.checkBoxGBS.Text = "Gobelin Sorcier";
            this.checkBoxGBS.UseVisualStyleBackColor = false;
            // 
            // checkBoxGBM
            // 
            this.checkBoxGBM.AutoSize = true;
            this.checkBoxGBM.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxGBM.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxGBM.Location = new System.Drawing.Point(17, 215);
            this.checkBoxGBM.Name = "checkBoxGBM";
            this.checkBoxGBM.Size = new System.Drawing.Size(105, 19);
            this.checkBoxGBM.TabIndex = 7;
            this.checkBoxGBM.Text = "Gobelin Druide";
            this.checkBoxGBM.UseVisualStyleBackColor = false;
            // 
            // checkBoxGBSoldat
            // 
            this.checkBoxGBSoldat.AutoSize = true;
            this.checkBoxGBSoldat.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxGBSoldat.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxGBSoldat.Location = new System.Drawing.Point(17, 230);
            this.checkBoxGBSoldat.Name = "checkBoxGBSoldat";
            this.checkBoxGBSoldat.Size = new System.Drawing.Size(103, 19);
            this.checkBoxGBSoldat.TabIndex = 8;
            this.checkBoxGBSoldat.Text = "Gobelin Soldat";
            this.checkBoxGBSoldat.UseVisualStyleBackColor = false;
            // 
            // progressBarNiveau
            // 
            this.progressBarNiveau.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBarNiveau.Location = new System.Drawing.Point(17, 255);
            this.progressBarNiveau.Name = "progressBarNiveau";
            this.progressBarNiveau.Size = new System.Drawing.Size(97, 16);
            this.progressBarNiveau.TabIndex = 9;
            // 
            // trackBarManuel
            // 
            this.trackBarManuel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBarManuel.Location = new System.Drawing.Point(17, 277);
            this.trackBarManuel.Name = "trackBarManuel";
            this.trackBarManuel.Size = new System.Drawing.Size(96, 45);
            this.trackBarManuel.TabIndex = 10;
            // 
            // buttonLevel
            // 
            this.buttonLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLevel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLevel.Location = new System.Drawing.Point(14, 328);
            this.buttonLevel.Name = "buttonLevel";
            this.buttonLevel.Size = new System.Drawing.Size(99, 23);
            this.buttonLevel.TabIndex = 11;
            this.buttonLevel.Text = "Ajouter Niveau";
            this.buttonLevel.UseVisualStyleBackColor = false;
            this.buttonLevel.Click += new System.EventHandler(this.buttonLevel_Click);
            // 
            // labelIndicateur
            // 
            this.labelIndicateur.AutoSize = true;
            this.labelIndicateur.BackColor = System.Drawing.Color.Transparent;
            this.labelIndicateur.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIndicateur.Location = new System.Drawing.Point(14, 356);
            this.labelIndicateur.Name = "labelIndicateur";
            this.labelIndicateur.Size = new System.Drawing.Size(172, 15);
            this.labelIndicateur.TabIndex = 12;
            this.labelIndicateur.Text = "Vous êtes actuellement niveau :";
            // 
            // labelNiveauCaliss
            // 
            this.labelNiveauCaliss.AutoSize = true;
            this.labelNiveauCaliss.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNiveauCaliss.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNiveauCaliss.Location = new System.Drawing.Point(192, 356);
            this.labelNiveauCaliss.Name = "labelNiveauCaliss";
            this.labelNiveauCaliss.Size = new System.Drawing.Size(13, 15);
            this.labelNiveauCaliss.TabIndex = 13;
            this.labelNiveauCaliss.Text = "0";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNiveauCaliss);
            this.Controls.Add(this.labelIndicateur);
            this.Controls.Add(this.buttonLevel);
            this.Controls.Add(this.trackBarManuel);
            this.Controls.Add(this.progressBarNiveau);
            this.Controls.Add(this.checkBoxGBSoldat);
            this.Controls.Add(this.checkBoxGBM);
            this.Controls.Add(this.checkBoxGBS);
            this.Controls.Add(this.labelEnnemis);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBoxDND);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "PersonaMaker";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDND)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarManuel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxDND;
        private ContextMenuStrip contextMenuStripMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemFichier;
        private ToolStripMenuItem éditionToolStripMenuItem;
        private ToolStripMenuItem sauvegarderToolStripMenuItem;
        private ToolStripMenuItem restaurerToolStripMenuItem;
        private ToolStripMenuItem exporterToolStripMenuItem;
        private ToolStripMenuItem importerToolStripMenuItem;
        private Label labelNom;
        private TextBox textBoxNom;
        private TextBox textBoxLevel;
        private Label labelLevel;
        private Label labelEnnemis;
        private CheckBox checkBoxGBS;
        private CheckBox checkBoxGBM;
        private CheckBox checkBoxGBSoldat;
        private ProgressBar progressBarNiveau;
        private TrackBar trackBarManuel;
        private Button buttonLevel;
        private Label labelIndicateur;
        private Label labelNiveauCaliss;
    }
}