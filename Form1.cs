using BugBase.DTOs;
using BugBase.Helpers;
using System;
using System.Windows.Forms;

namespace BugBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                Bug bug = new Bug("1","2","3", DateTime.Now, true);
                dbContext.Bugs.Add(bug);
                dbContext.SaveChanges();
            }
        }
    }
}
