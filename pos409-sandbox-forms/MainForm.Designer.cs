namespace pos409_sandbox_forms
{
    partial class MainForm
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
            this.btnOverdraft = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOverdraft
            // 
            this.btnOverdraft.Location = new System.Drawing.Point(25, 27);
            this.btnOverdraft.Name = "btnOverdraft";
            this.btnOverdraft.Size = new System.Drawing.Size(152, 55);
            this.btnOverdraft.TabIndex = 0;
            this.btnOverdraft.Text = "Overdraft Account";
            this.btnOverdraft.UseVisualStyleBackColor = true;
            this.btnOverdraft.Click += new System.EventHandler(this.btnOverdraft_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(218, 118);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(75, 23);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 376);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnOverdraft);
            this.Name = "MainForm";
            this.Text = "C# Forms Sandbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOverdraft;
        private System.Windows.Forms.Button btnEvents;
    }
}

