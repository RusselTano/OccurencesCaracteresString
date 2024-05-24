namespace OccurencesCaracteresString
{
    partial class OccurencesCaracteresStringForm
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.programmesListBox = new System.Windows.Forms.ListBox();
            this.nombreEmplyesLabel = new System.Windows.Forms.Label();
            this.programmesTextBox = new System.Windows.Forms.TextBox();
            this.rechercherButton = new System.Windows.Forms.Button();
            this.occurenceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            this.nombreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreLabel.Location = new System.Drawing.Point(271, 131);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(184, 25);
            this.nombreLabel.TabIndex = 0;
            // 
            // programmesListBox
            // 
            this.programmesListBox.FormattingEnabled = true;
            this.programmesListBox.ItemHeight = 16;
            this.programmesListBox.Location = new System.Drawing.Point(27, 82);
            this.programmesListBox.Name = "programmesListBox";
            this.programmesListBox.Size = new System.Drawing.Size(215, 260);
            this.programmesListBox.TabIndex = 1;
            this.programmesListBox.SelectedIndexChanged += new System.EventHandler(this.programmesListBox_SelectedIndexChanged);
            // 
            // nombreEmplyesLabel
            // 
            this.nombreEmplyesLabel.AutoSize = true;
            this.nombreEmplyesLabel.Location = new System.Drawing.Point(268, 97);
            this.nombreEmplyesLabel.Name = "nombreEmplyesLabel";
            this.nombreEmplyesLabel.Size = new System.Drawing.Size(176, 20);
            this.nombreEmplyesLabel.TabIndex = 2;
            this.nombreEmplyesLabel.Text = "Nombre d\'empployes:";
            // 
            // programmesTextBox
            // 
            this.programmesTextBox.Location = new System.Drawing.Point(271, 195);
            this.programmesTextBox.Name = "programmesTextBox";
            this.programmesTextBox.Size = new System.Drawing.Size(184, 22);
            this.programmesTextBox.TabIndex = 3;
            // 
            // rechercherButton
            // 
            this.rechercherButton.Location = new System.Drawing.Point(271, 238);
            this.rechercherButton.Name = "rechercherButton";
            this.rechercherButton.Size = new System.Drawing.Size(102, 32);
            this.rechercherButton.TabIndex = 4;
            this.rechercherButton.Text = "Rechercher";
            this.rechercherButton.UseVisualStyleBackColor = true;
            this.rechercherButton.Click += new System.EventHandler(this.rechercherButton_Click);
            // 
            // occurenceButton
            // 
            this.occurenceButton.Location = new System.Drawing.Point(274, 292);
            this.occurenceButton.Name = "occurenceButton";
            this.occurenceButton.Size = new System.Drawing.Size(98, 29);
            this.occurenceButton.TabIndex = 5;
            this.occurenceButton.Text = "Occurence";
            this.occurenceButton.UseVisualStyleBackColor = true;
            this.occurenceButton.Click += new System.EventHandler(this.occurenceButton_Click);
            // 
            // OccurencesCaracteresStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.occurenceButton);
            this.Controls.Add(this.rechercherButton);
            this.Controls.Add(this.programmesTextBox);
            this.Controls.Add(this.nombreEmplyesLabel);
            this.Controls.Add(this.programmesListBox);
            this.Controls.Add(this.nombreLabel);
            this.Name = "OccurencesCaracteresStringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.OccurencesCaracteresStringForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.ListBox programmesListBox;
        private System.Windows.Forms.Label nombreEmplyesLabel;
        private System.Windows.Forms.TextBox programmesTextBox;
        private System.Windows.Forms.Button rechercherButton;
        private System.Windows.Forms.Button occurenceButton;
    }
}

