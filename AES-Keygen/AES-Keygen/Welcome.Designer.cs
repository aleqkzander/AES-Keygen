

namespace AES_Keygen
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GenerateButton = new Button();
            SuspendLayout();
            // 
            // GenerateButton
            // 
            GenerateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateButton.Location = new Point(12, 12);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(80, 57);
            GenerateButton.TabIndex = 1;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(104, 81);
            Controls.Add(GenerateButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Welcome";
            Text = "AES-Keygen";
            ResumeLayout(false);
        }

        #endregion
        private Button GenerateButton;
    }
}
