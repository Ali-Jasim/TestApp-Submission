namespace TestApp
{
    public partial class MainForm : Form
    {

        //Constants
        private const string LOGFILE = "DrugIncrementTest.log";

        //UI Components
        private Form log;
        private Drug[] drugs;

        //UI Constrols
        private Button Reset;
        private Button displayLog;
        private Button Exit;
        
        //Fields
        private StreamWriter logWriter;

        //Constructor
        public MainForm()
        {
            logWriter = new StreamWriter(LOGFILE, true);
            
            try
            {
                logWriter.Write($"{DateTime.Now} START {Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }
            
            //initialize UI components
            initializeDrugs();
            InitializeComponent();
        }

        //Creates UI controls for each drug
        private void initializeDrugs()
        {
            drugs = new Drug[3];

            drugs[0] = new Drug("Acetaminophen", new Point(3, 10), logWriter);
            drugs[1] = new Drug("Oxycotin", new Point(3, 40), logWriter);
            drugs[2] = new Drug("Ibuprofen", new Point(3, 70), logWriter);

            foreach (Drug drug in drugs)
            {
                Controls.Add(drug);
            }
        }

        //Resets all drug counts to 0
        private void ResetDrugCount(object sender, EventArgs e)
        {

            logWriter.Write($"{DateTime.Now} RESET {Environment.NewLine}");
            

            foreach (Drug drug in drugs)
            {
                drug.ResetCounter();
            }
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void DisplayLog(object sender, EventArgs e)
        {
            //Free the StreamWriter to avoid collision
            logWriter.Close();
            logWriter.Dispose();

            log = new LogFileForm(LOGFILE);
            log.ShowDialog();

            //Create new StreamWriter
            logWriter = new StreamWriter(LOGFILE, true);

            foreach (Drug drug in drugs)
            {
                drug.logWriter = logWriter;
            }

        }

        //Free resources on exit
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            //close and free the StreamWriter
            logWriter.Close();
            logWriter.Dispose();

            //Delete log file on exit
            if (File.Exists(LOGFILE))
            {
                File.Delete(LOGFILE);
            }

            base.Dispose(disposing);
        }


    }
}
