using AES_Keygen.Utility;

namespace AES_Keygen
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string key = Generator.GenerateRandomKey();
            MessageBox.Show($"Following key was copied to the clipboard:\n\n{key}");
            Clipboard.SetText(key);
        }
    }
}