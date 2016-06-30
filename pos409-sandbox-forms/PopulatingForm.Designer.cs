namespace pos409_sandbox_forms
{
    partial class PopulatingForm
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
            this.cmbFruits = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbFruits
            // 
            this.cmbFruits.FormattingEnabled = true;
            this.cmbFruits.Location = new System.Drawing.Point(61, 57);
            this.cmbFruits.Name = "cmbFruits";
            this.cmbFruits.Size = new System.Drawing.Size(242, 21);
            this.cmbFruits.TabIndex = 0;
            // 
            // PopulatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 309);
            this.Controls.Add(this.cmbFruits);
            this.Name = "PopulatingForm";
            this.Text = "PopulatingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFruits;

    }
}