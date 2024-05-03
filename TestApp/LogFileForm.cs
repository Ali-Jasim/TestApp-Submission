
namespace TestApp
{
    public partial class LogFileForm : Form
    {
        //UI Controls
        private RichTextBox richTextBox1;
        private Button ExitButton;

        //Field
        private StreamReader logReader;
        public LogFileForm(string logFile)
        {
            try
            {
                logReader = new StreamReader(logFile);
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
            
            InitializeComponent();

            FormClosing += ExitButton_Click;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        protected override void Dispose(bool disposing)
        {
            logReader.Close();
            logReader.Dispose();

            if (disposing && (components != null))
            {

                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
