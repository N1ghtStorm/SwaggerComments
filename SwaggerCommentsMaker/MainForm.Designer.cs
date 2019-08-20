namespace SwaggerCommentsMaker
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
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.TransferButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.PhraseTextBox = new System.Windows.Forms.TextBox();
            this.AcceptAddPhrButton = new System.Windows.Forms.Button();
            this.PhrPreviewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputTextBox.Location = new System.Drawing.Point(64, 122);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(596, 622);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextBox.Location = new System.Drawing.Point(1068, 122);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(700, 622);
            this.OutputTextBox.TabIndex = 1;
            this.OutputTextBox.Text = "";
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(756, 797);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(200, 71);
            this.TransferButton.TabIndex = 2;
            this.TransferButton.Text = "Перевести";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(1606, 842);
            this.CleanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(176, 71);
            this.CleanButton.TabIndex = 3;
            this.CleanButton.Text = "Очистить";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // PhraseTextBox
            // 
            this.PhraseTextBox.Location = new System.Drawing.Point(783, 405);
            this.PhraseTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhraseTextBox.Name = "PhraseTextBox";
            this.PhraseTextBox.Size = new System.Drawing.Size(148, 26);
            this.PhraseTextBox.TabIndex = 4;
            this.PhraseTextBox.TextChanged += new System.EventHandler(this.PhraseTextBox_TextChanged);
            // 
            // AcceptAddPhrButton
            // 
            this.AcceptAddPhrButton.Location = new System.Drawing.Point(765, 466);
            this.AcceptAddPhrButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AcceptAddPhrButton.Name = "AcceptAddPhrButton";
            this.AcceptAddPhrButton.Size = new System.Drawing.Size(200, 71);
            this.AcceptAddPhrButton.TabIndex = 5;
            this.AcceptAddPhrButton.Text = "Применить";
            this.AcceptAddPhrButton.UseVisualStyleBackColor = true;
            this.AcceptAddPhrButton.Click += new System.EventHandler(this.AcceptAddPhrButton_Click);
            // 
            // PhrPreviewLabel
            // 
            this.PhrPreviewLabel.AutoSize = true;
            this.PhrPreviewLabel.Location = new System.Drawing.Point(830, 360);
            this.PhrPreviewLabel.Name = "PhrPreviewLabel";
            this.PhrPreviewLabel.Size = new System.Drawing.Size(21, 20);
            this.PhrPreviewLabel.TabIndex = 6;
            this.PhrPreviewLabel.Text = "///";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1824, 955);
            this.Controls.Add(this.PhrPreviewLabel);
            this.Controls.Add(this.AcceptAddPhrButton);
            this.Controls.Add(this.PhraseTextBox);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "SwaggerComments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.TextBox PhraseTextBox;
        private System.Windows.Forms.Button AcceptAddPhrButton;
        private System.Windows.Forms.Label PhrPreviewLabel;
    }
}

