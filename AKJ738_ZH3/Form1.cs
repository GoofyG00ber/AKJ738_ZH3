namespace AKJ738_ZH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 ablak = new UserControl1();
            ablak.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ablak);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl2 ablak = new UserControl2();
            ablak.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ablak);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl3 ablak = new UserControl3();
            ablak.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ablak);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?","Bizti nem bizti", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}