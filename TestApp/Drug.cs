
namespace TestApp
{
    public partial class Drug : UserControl
    {
        //UI Controls
        private Label drugName;
        private Label Counter;
        private Button Increment;

        //Fields
        private string name;
        private int count;
        private StreamWriter writer;

        //Properties
        public StreamWriter logWriter 
        { 
            get { return writer; }
            set { writer = value; } 
        }

        public int Count
        {
            get { return this.count; }
            set { count = value; }
        }

        //Constructor
        public Drug(string name, Point location, StreamWriter logWriter)
        {
            this.logWriter = logWriter;
            this.name = name;

            count = 0;
            Location = location;

            InitializeComponent();
        }

        //instance Methods

        //Logs update and updates UI
        private void UpdateCounter(int prev)
        {
            logWriter.Write($"{DateTime.Now} Name: {name} : {prev} -> {Count} {Environment.NewLine}");

            Counter.Text = count.ToString();
        }

        private void IncrementCounter(object sender, EventArgs e)
        {
            int prevCount = Count;
            Count++;
            UpdateCounter(prevCount); 
        }

        public void ResetCounter()
        {
            int prevCount = Count;
            Count = 0;
            UpdateCounter(prevCount);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
