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
    public partial class UserControl1 : UserControl
    {
        tickerContext context = new tickerContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            basicCompanyInfoBindingSource.DataSource = context.BasicCompanyInfos.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var n = (from x in context.BasicCompanyInfos
                     where x.Industry.Contains(textBox1.Text) || x.Description.Contains(textBox1.Text)
                     select x).ToList();

            basicCompanyInfoBindingSource.DataSource = n;
        }
    }
}
