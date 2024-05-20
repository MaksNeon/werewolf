namespace LoupGarou
{
    partial class LoupGarou
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoupGarou));
            this.btnAjouterJoueur = new System.Windows.Forms.Button();
            this.timerRefreshList = new System.Windows.Forms.Timer(this.components);
            this.lblYourRole = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNomAdd = new System.Windows.Forms.Label();
            this.txboxNomAdd = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.listViewUsername = new System.Windows.Forms.ListView();
            this.btnListVillageois = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouterJoueur
            // 
            this.btnAjouterJoueur.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouterJoueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouterJoueur.Font = new System.Drawing.Font("Correction Tape", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterJoueur.Location = new System.Drawing.Point(12, 88);
            this.btnAjouterJoueur.Name = "btnAjouterJoueur";
            this.btnAjouterJoueur.Size = new System.Drawing.Size(180, 48);
            this.btnAjouterJoueur.TabIndex = 0;
            this.btnAjouterJoueur.Text = "ajouter un joueur";
            this.btnAjouterJoueur.UseVisualStyleBackColor = false;
            this.btnAjouterJoueur.Click += new System.EventHandler(this.btnAjouterJoueur_Click);
            // 
            // timerRefreshList
            // 
            this.timerRefreshList.Enabled = true;
            this.timerRefreshList.Interval = 150;
            this.timerRefreshList.Tick += new System.EventHandler(this.timerRefreshList_Tick_1);
            // 
            // lblYourRole
            // 
            this.lblYourRole.AutoSize = true;
            this.lblYourRole.BackColor = System.Drawing.Color.Transparent;
            this.lblYourRole.Font = new System.Drawing.Font("Correction Tape", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourRole.ForeColor = System.Drawing.Color.Gold;
            this.lblYourRole.Location = new System.Drawing.Point(9, 9);
            this.lblYourRole.Name = "lblYourRole";
            this.lblYourRole.Size = new System.Drawing.Size(127, 31);
            this.lblYourRole.TabIndex = 2;
            this.lblYourRole.Text = "Vous: ...";
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Teal;
            this.panelAdd.Controls.Add(this.button1);
            this.panelAdd.Controls.Add(this.btnAdd);
            this.panelAdd.Controls.Add(this.lblNomAdd);
            this.panelAdd.Controls.Add(this.txboxNomAdd);
            this.panelAdd.Location = new System.Drawing.Point(12, 157);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(238, 125);
            this.panelAdd.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Correction Tape", 11F);
            this.btnAdd.Location = new System.Drawing.Point(130, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNomAdd
            // 
            this.lblNomAdd.AutoSize = true;
            this.lblNomAdd.Font = new System.Drawing.Font("Correction Tape", 15F);
            this.lblNomAdd.Location = new System.Drawing.Point(3, 13);
            this.lblNomAdd.Name = "lblNomAdd";
            this.lblNomAdd.Size = new System.Drawing.Size(57, 23);
            this.lblNomAdd.TabIndex = 1;
            this.lblNomAdd.Text = "Nom:";
            // 
            // txboxNomAdd
            // 
            this.txboxNomAdd.Font = new System.Drawing.Font("Correction Tape", 12F);
            this.txboxNomAdd.Location = new System.Drawing.Point(66, 13);
            this.txboxNomAdd.Name = "txboxNomAdd";
            this.txboxNomAdd.Size = new System.Drawing.Size(150, 26);
            this.txboxNomAdd.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Correction Tape", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 288);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(238, 36);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Commencez";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listViewUsername
            // 
            this.listViewUsername.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewUsername.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewUsername.BackColor = System.Drawing.Color.Silver;
            this.listViewUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUsername.Font = new System.Drawing.Font("Correction Tape", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUsername.ForeColor = System.Drawing.Color.Transparent;
            this.listViewUsername.HideSelection = false;
            this.listViewUsername.HotTracking = true;
            this.listViewUsername.HoverSelection = true;
            this.listViewUsername.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewUsername.Location = new System.Drawing.Point(448, 9);
            this.listViewUsername.Name = "listViewUsername";
            this.listViewUsername.Size = new System.Drawing.Size(349, 312);
            this.listViewUsername.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewUsername.TabIndex = 6;
            this.listViewUsername.TileSize = new System.Drawing.Size(5, 5);
            this.listViewUsername.UseCompatibleStateImageBehavior = false;
            this.listViewUsername.SelectedIndexChanged += new System.EventHandler(this.listViewUsername_SelectedIndexChanged);
            // 
            // btnListVillageois
            // 
            this.btnListVillageois.Font = new System.Drawing.Font("Correction Tape", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListVillageois.Location = new System.Drawing.Point(517, 327);
            this.btnListVillageois.Name = "btnListVillageois";
            this.btnListVillageois.Size = new System.Drawing.Size(190, 23);
            this.btnListVillageois.TabIndex = 8;
            this.btnListVillageois.Text = "Liste des villageois";
            this.btnListVillageois.UseVisualStyleBackColor = true;
            this.btnListVillageois.Click += new System.EventHandler(this.btnListVillageois_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Correction Tape", 10F);
            this.button1.Location = new System.Drawing.Point(3, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ajouter X14";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoupGarou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 361);
            this.Controls.Add(this.btnListVillageois);
            this.Controls.Add(this.listViewUsername);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.lblYourRole);
            this.Controls.Add(this.btnAjouterJoueur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(824, 400);
            this.MinimumSize = new System.Drawing.Size(824, 400);
            this.Name = "LoupGarou";
            this.ShowIcon = false;
            this.Text = "Loups-garoups";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterJoueur;
        private System.Windows.Forms.Timer timerRefreshList;
        private System.Windows.Forms.Label lblYourRole;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TextBox txboxNomAdd;
        private System.Windows.Forms.Label lblNomAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView listViewUsername;
        private System.Windows.Forms.Button btnListVillageois;
        private System.Windows.Forms.Button button1;
    }
}

