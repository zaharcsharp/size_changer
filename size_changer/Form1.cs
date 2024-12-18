using System.DirectoryServices;
using System.Net.Http.Headers;

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

        private async void change_Click(object sender, EventArgs e)
        {
            await Changer.change_images(directory.Text, integr.Text, Convert.ToInt32(numericUpDown1.Value));
            integr.Text = null;
            numericUpDown1.Value = 100;
        }

        private void integr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
