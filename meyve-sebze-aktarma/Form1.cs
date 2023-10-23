using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meyve_sebze_aktarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstyiyecekler.Items.Count; i++)
            {
                if (lstyiyecekler.Items[i].ToString() == "kiraz" ||
                lstyiyecekler.Items[i].ToString() == "ayva" ||
                lstyiyecekler.Items[i].ToString() == "karpuz" ||
                lstyiyecekler.Items[i].ToString() == "çilek" ||
                lstyiyecekler.Items[i].ToString() == "elma") 
                {
                    lstmeyve.Items.Add(lstyiyecekler.Items[i]);
                }
                else
                {
                    lstsebze.Items.Add(lstyiyecekler.Items[i]);
                }
            }
        }
    }
}
