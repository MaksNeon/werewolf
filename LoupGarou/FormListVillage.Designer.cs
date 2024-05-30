namespace LoupGarou
{
    partial class FormListVillage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lsbVillage = new System.Windows.Forms.ListBox();
            this.timerUpdateList = new System.Windows.Forms.Timer(this.components);
            this.villageoisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.villageoisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbVillage
            // 
            this.lsbVillage.FormattingEnabled = true;
            this.lsbVillage.Location = new System.Drawing.Point(12, 9);
            this.lsbVillage.Name = "lsbVillage";
            this.lsbVillage.Size = new System.Drawing.Size(438, 433);
            this.lsbVillage.TabIndex = 0;
            // 
            // timerUpdateList
            // 
            this.timerUpdateList.Enabled = true;
            // 
            // FormListVillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.lsbVillage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListVillage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormListVillage";
            this.Load += new System.EventHandler(this.FormListVillage_Load);
            this.Enter += new System.EventHandler(this.FormListVillage_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.villageoisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbVillage;
        private System.Windows.Forms.Timer timerUpdateList;
        private System.Windows.Forms.BindingSource villageoisBindingSource;
    }
}