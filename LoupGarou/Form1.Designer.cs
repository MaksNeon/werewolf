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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.btnAjouterJoueur = new System.Windows.Forms.Button();
            this.timerRefreshList = new System.Windows.Forms.Timer(this.components);
            this.listViewVillage = new System.Windows.Forms.ListView();
            this.lblYourRole = new System.Windows.Forms.Label();
            this.lblRoleSelect = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNomAdd = new System.Windows.Forms.Label();
            this.txboxNomAdd = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouterJoueur
            // 
            this.btnAjouterJoueur.Location = new System.Drawing.Point(12, 115);
            this.btnAjouterJoueur.Name = "btnAjouterJoueur";
            this.btnAjouterJoueur.Size = new System.Drawing.Size(131, 23);
            this.btnAjouterJoueur.TabIndex = 0;
            this.btnAjouterJoueur.Text = "Ajouter un joueur";
            this.btnAjouterJoueur.UseVisualStyleBackColor = true;
            this.btnAjouterJoueur.Click += new System.EventHandler(this.btnAjouterJoueur_Click);
            // 
            // timerRefreshList
            // 
            this.timerRefreshList.Enabled = true;
            this.timerRefreshList.Interval = 150;
            this.timerRefreshList.Tick += new System.EventHandler(this.timerRefreshList_Tick_1);
            // 
            // listViewVillage
            // 
            this.listViewVillage.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewVillage.HideSelection = false;
            this.listViewVillage.HotTracking = true;
            this.listViewVillage.HoverSelection = true;
            this.listViewVillage.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listViewVillage.Location = new System.Drawing.Point(586, 12);
            this.listViewVillage.Name = "listViewVillage";
            this.listViewVillage.Size = new System.Drawing.Size(202, 426);
            this.listViewVillage.TabIndex = 1;
            this.listViewVillage.UseCompatibleStateImageBehavior = false;
            this.listViewVillage.SelectedIndexChanged += new System.EventHandler(this.listViewVillage_SelectedIndexChanged);
            // 
            // lblYourRole
            // 
            this.lblYourRole.AutoSize = true;
            this.lblYourRole.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourRole.Location = new System.Drawing.Point(9, 9);
            this.lblYourRole.Name = "lblYourRole";
            this.lblYourRole.Size = new System.Drawing.Size(100, 31);
            this.lblYourRole.TabIndex = 2;
            this.lblYourRole.Text = "Vous: ...";
            // 
            // lblRoleSelect
            // 
            this.lblRoleSelect.AutoSize = true;
            this.lblRoleSelect.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleSelect.Location = new System.Drawing.Point(9, 50);
            this.lblRoleSelect.Name = "lblRoleSelect";
            this.lblRoleSelect.Size = new System.Drawing.Size(145, 31);
            this.lblRoleSelect.TabIndex = 3;
            this.lblRoleSelect.Text = "Role: Aucun";
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelAdd.Controls.Add(this.btnAdd);
            this.panelAdd.Controls.Add(this.lblNomAdd);
            this.panelAdd.Controls.Add(this.txboxNomAdd);
            this.panelAdd.Location = new System.Drawing.Point(12, 157);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(568, 125);
            this.panelAdd.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(490, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNomAdd
            // 
            this.lblNomAdd.AutoSize = true;
            this.lblNomAdd.Location = new System.Drawing.Point(3, 13);
            this.lblNomAdd.Name = "lblNomAdd";
            this.lblNomAdd.Size = new System.Drawing.Size(32, 13);
            this.lblNomAdd.TabIndex = 1;
            this.lblNomAdd.Text = "Nom:";
            // 
            // txboxNomAdd
            // 
            this.txboxNomAdd.Location = new System.Drawing.Point(44, 10);
            this.txboxNomAdd.Name = "txboxNomAdd";
            this.txboxNomAdd.Size = new System.Drawing.Size(100, 20);
            this.txboxNomAdd.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(424, 115);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 36);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Commencez";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // LoupGarou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.lblRoleSelect);
            this.Controls.Add(this.lblYourRole);
            this.Controls.Add(this.listViewVillage);
            this.Controls.Add(this.btnAjouterJoueur);
            this.Name = "LoupGarou";
            this.ShowIcon = false;
            this.Text = "Loup Garou";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterJoueur;
        private System.Windows.Forms.Timer timerRefreshList;
        private System.Windows.Forms.ListView listViewVillage;
        private System.Windows.Forms.Label lblYourRole;
        private System.Windows.Forms.Label lblRoleSelect;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TextBox txboxNomAdd;
        private System.Windows.Forms.Label lblNomAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStart;
    }
}

