namespace ArchivDrucker
{
    partial class Form2
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
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonAbort2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSet2
            // 
            this.buttonSet2.Location = new System.Drawing.Point(49, 180);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(88, 32);
            this.buttonSet2.TabIndex = 0;
            this.buttonSet2.Text = "Setzen";
            this.buttonSet2.UseVisualStyleBackColor = true;
            this.buttonSet2.Click += new System.EventHandler(this.ButtonSet2_Click);
            // 
            // buttonAbort2
            // 
            this.buttonAbort2.Location = new System.Drawing.Point(232, 180);
            this.buttonAbort2.Name = "buttonAbort2";
            this.buttonAbort2.Size = new System.Drawing.Size(84, 32);
            this.buttonAbort2.TabIndex = 1;
            this.buttonAbort2.Text = "Abbrechen";
            this.buttonAbort2.UseVisualStyleBackColor = true;
            this.buttonAbort2.Click += new System.EventHandler(this.ButtonAbort2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(272, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(c) ToMaSch 2022";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumber1.Location = new System.Drawing.Point(49, 87);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(267, 46);
            this.textBoxNumber1.TabIndex = 3;
            this.textBoxNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Setzen Sie bitte die laufende Aktennummer";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(363, 245);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAbort2);
            this.Controls.Add(this.buttonSet2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonAbort2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.Label label3;
    }
}