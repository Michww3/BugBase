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

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string description = DescriptionTextBox.Text;
            string priority = PriorityComboBox.Text;
            DateTime end = EndDatePicker.Value;
            bool isComplete = StatusCheckBox.Checked;

            using (AppDbContext context = new AppDbContext())
            {
                context.Bugs.Add(new Bug(name, description, priority, end, isComplete));
                await context.SaveChangesAsync();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            PriorityComboBox.Text = string.Empty;
            EndDatePicker.Value = DateTime.Now;
            StatusCheckBox.Checked = false;
        }
    }
}
