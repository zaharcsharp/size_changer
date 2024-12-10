namespace size_changer
{
    partial class Form1
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
            saveFileDialog1 = new SaveFileDialog();
            Get_directory = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            directory = new TextBox();
            change = new Button();
            integr = new TextBox();
            SuspendLayout();
            // 
            // Get_directory
            // 
            Get_directory.Location = new Point(336, 14);
            Get_directory.Name = "Get_directory";
            Get_directory.Size = new Size(94, 29);
            Get_directory.TabIndex = 1;
            Get_directory.Text = "Файл";
            Get_directory.UseVisualStyleBackColor = true;
            Get_directory.Click += button1_Click;
            // 
            // directory
            // 
            directory.Location = new Point(12, 14);
            directory.Name = "directory";
            directory.Size = new Size(318, 27);
            directory.TabIndex = 2;
            // 
            // change
            // 
            change.Location = new Point(143, 68);
            change.Name = "change";
            change.Size = new Size(94, 29);
            change.TabIndex = 3;
            change.Text = "Изменить";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // integr
            // 
            integr.Location = new Point(12, 68);
            integr.Name = "integr";
            integr.Size = new Size(125, 27);
            integr.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(integr);
            Controls.Add(change);
            Controls.Add(directory);
            Controls.Add(Get_directory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Button Get_directory;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox directory;
        private Button change;
        private TextBox integr;
    }
}
