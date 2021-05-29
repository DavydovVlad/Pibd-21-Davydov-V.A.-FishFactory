using CannedFactoryBusinessLogic.BusinessLogics;
using System;
using System.Windows.Forms;

namespace CannedFactoryView
{
    public partial class FormMails : Form
    {
        private readonly MailLogic logic;

        public FormMails(MailLogic mailLogic)
        {
            logic = mailLogic;
            InitializeComponent();
        }

        private void FormMails_Load(object sender, EventArgs e)
        {
            try
            {
                Program.ConfigGrid(logic.Read(null), dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
