using System.DirectoryServices;

namespace size_changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                directory.Text = dialog.SelectedPath;
            }
        }

        private void change_Click(object sender, EventArgs e)
        { 
            Changer.change_images(directory.Text, Convert.ToInt32(integr.Text));
        }
    }
}
