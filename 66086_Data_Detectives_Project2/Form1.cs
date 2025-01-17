namespace _66086_Data_Detectives_Project2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCustomer showCustomer = new ShowCustomer();
            showCustomer.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowStaff showStaff = new ShowStaff();
            showStaff.Show();
            this.Hide();
        }
    }
}
