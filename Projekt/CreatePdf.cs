using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class CreatePdf : Form
    {
        public CreatePdf()
        {
            InitializeComponent();
        }

        private void CreatePdf_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
        }

        private void backToStartBtn_Click(object sender, EventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
            Close();
        }
    }
}
