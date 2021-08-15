using System;

namespace SaaS
{
    public partial class Formadd : System.Windows.Forms.Form
    {
        public Formadd()
        {
            InitializeComponent();
        }

        private void Formadd_Load(object sender, EventArgs e)
        {
            Formadd formadd = new Formadd();
            formadd.Show();

            formadd.MdiParent = this;
            formadd.Text = "123";
        }
    }
}
