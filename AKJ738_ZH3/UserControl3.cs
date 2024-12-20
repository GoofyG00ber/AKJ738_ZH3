using AKJ738_ZH3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKJ738_ZH3
{
    public partial class UserControl3 : UserControl
    {
        tickerContext context = new tickerContext();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            dailyPriceBindingSource.DataSource = context.DailyPrices.ToList();
            tickerBindingSource.DataSource = context.Tickers.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dailyPriceBindingSource.DataSource = context.DailyPrices.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var n = (from x in context.DailyPrices
                     where x.Id == listBox1.SelectedIndex
                     select x).ToList();

            dailyPriceBindingSource.DataSource = n;
        }
    }
}
