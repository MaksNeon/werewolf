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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoupGarou));
            this.btnAjouterJoueur = new System.Windows.Forms.Button();
            this.timerRefreshList = new System.Windows.Forms.Timer(this.components);
            this.lblYourRole = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNomAdd = new System.Windows.Forms.Label();
            this.txboxNomAdd = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnListVillageois = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnTour = new Guna.UI2.WinForms.Guna2Button();
            this.panelAdd.SuspendLayout();
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouterJoueur
            // 
            this.btnAjouterJoueur.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAjouterJoueur, "btnAjouterJoueur");
            this.btnAjouterJoueur.Name = "btnAjouterJoueur";
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
            resources.ApplyResources(this.lblYourRole, "lblYourRole");
            this.lblYourRole.BackColor = System.Drawing.Color.Transparent;
            this.lblYourRole.ForeColor = System.Drawing.Color.Gold;
            this.lblYourRole.Name = "lblYourRole";
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Teal;
            this.panelAdd.Controls.Add(this.button1);
            this.panelAdd.Controls.Add(this.btnAdd);
            this.panelAdd.Controls.Add(this.lblNomAdd);
            this.panelAdd.Controls.Add(this.txboxNomAdd);
            resources.ApplyResources(this.panelAdd, "panelAdd");
            this.panelAdd.Name = "panelAdd";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNomAdd
            // 
            resources.ApplyResources(this.lblNomAdd, "lblNomAdd");
            this.lblNomAdd.Name = "lblNomAdd";
            // 
            // txboxNomAdd
            // 
            resources.ApplyResources(this.txboxNomAdd, "txboxNomAdd");
            this.txboxNomAdd.Name = "txboxNomAdd";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnListVillageois
            // 
            resources.ApplyResources(this.btnListVillageois, "btnListVillageois");
            this.btnListVillageois.Name = "btnListVillageois";
            this.btnListVillageois.UseVisualStyleBackColor = true;
            this.btnListVillageois.Click += new System.EventHandler(this.btnListVillageois_Click);
            // 
            // panelBar
            // 
            this.panelBar.Controls.Add(this.lblTitle);
            this.panelBar.Controls.Add(this.guna2CircleButton1);
            this.panelBar.Controls.Add(this.btnClose);
            resources.ApplyResources(this.panelBar, "panelBar");
            this.panelBar.Name = "panelBar";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.guna2CircleButton1, "guna2CircleButton1");
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.PressedDepth = 50;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.TextFormatNoPrefix = true;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedDepth = 50;
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.BorderRadius = 10;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.ShadowColor = System.Drawing.Color.DarkSlateGray;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // DragControl
            // 
            this.DragControl.DockForm = true;
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.panelBar;
            this.DragControl.UseTransparentDrag = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // btnTour
            // 
            this.btnTour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnTour, "btnTour");
            this.btnTour.ForeColor = System.Drawing.Color.White;
            this.btnTour.Name = "btnTour";
            this.btnTour.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // LoupGarou
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.btnListVillageois);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.lblYourRole);
            this.Controls.Add(this.btnAjouterJoueur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoupGarou";
            this.ShowIcon = false;
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
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
        private System.Windows.Forms.Button btnListVillageois;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelBar;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTour;
        private System.Windows.Forms.Label lblTitle;
    }
}

