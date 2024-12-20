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
    public partial class UserControl2 : UserControl
    {
        tickerContext context = new tickerContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            tickerBindingSource.DataSource = context.Tickers.ToList();
            comboBox1.SelectedIndex = 0;
            changer();
        }

        private void changer()
        {
            var n = (from x in context.DailyPrices
                     where x.TickerId == comboBox1.SelectedIndex + 1
                     select x.OpenPrice).FirstOrDefault();

            label1.Text = n.ToString();


            var m = (from x in context.DailyPrices
                     where x.TickerId == comboBox1.SelectedIndex + 1
                     select x.ClosePrice).FirstOrDefault();

            label2.Text = m.ToString();

            var b = (from x in context.DailyPrices
                     where x.TickerId == comboBox1.SelectedIndex + 1
                     select x.TradeDate).FirstOrDefault();

            label8.Text = b.ToString();

            var v = (from x in context.BasicCompanyInfos
                     where x.TickerId == comboBox1.SelectedIndex + 1
                     select x.Description).FirstOrDefault();

            label9.Text = v.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changer();
        }
    }
}
