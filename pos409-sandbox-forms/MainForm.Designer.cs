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
            this.btnPopulating = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOverdraft
            // 
            this.btnOverdraft.Location = new System.Drawing.Point(12, 12);
            this.btnOverdraft.Name = "btnOverdraft";
            this.btnOverdraft.Size = new System.Drawing.Size(152, 33);
            this.btnOverdraft.TabIndex = 0;
            this.btnOverdraft.Text = "Overdraft Account";
            this.btnOverdraft.UseVisualStyleBackColor = true;
            this.btnOverdraft.Click += new System.EventHandler(this.btnOverdraft_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(170, 12);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(152, 33);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnPopulating
            // 
            this.btnPopulating.Location = new System.Drawing.Point(12, 51);
            this.btnPopulating.Name = "btnPopulating";
            this.btnPopulating.Size = new System.Drawing.Size(152, 33);
            this.btnPopulating.TabIndex = 2;
            this.btnPopulating.Text = "Populating";
            this.btnPopulating.UseVisualStyleBackColor = true;
            this.btnPopulating.Click += new System.EventHandler(this.btnPopulating_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(170, 51);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(152, 33);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 376);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnPopulating);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnOverdraft);
            this.Name = "MainForm";
            this.Text = "C# Forms Sandbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOverdraft;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnPopulating;
        private System.Windows.Forms.Button btnWhere;
    }
}

