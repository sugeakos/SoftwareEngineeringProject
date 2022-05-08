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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewPersonBtn_Click(object sender, EventArgs e)
        {
            CreateOrUpdateAPerson createOrUpdateAPerson = new CreateOrUpdateAPerson();
            createOrUpdateAPerson.Tag = this;
            createOrUpdateAPerson.Show(this);
            Hide();
        }

        private void addNewTvCategoryBtn_Click(object sender, EventArgs e)
        {
            CreateOrUpdateTvCategory createOrUpdateTvCategory = new CreateOrUpdateTvCategory();
            createOrUpdateTvCategory.Tag = this;
            createOrUpdateTvCategory.Show(this);
            Hide();
        }

        private void addNewTvBtn_Click(object sender, EventArgs e)
        {
            CreateOrEditTv createOrEditTv = new CreateOrEditTv();
            createOrEditTv.Tag = this;
            createOrEditTv.Show(this);
            Hide();
        }
    }
}
