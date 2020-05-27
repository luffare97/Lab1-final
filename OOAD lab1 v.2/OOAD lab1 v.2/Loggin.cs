using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busineslayer;

namespace OOAD_lab1_v._2
{
    public partial class Loggin : Form
    {
        internal Businesmanager Businesmanager { get; }
        public Loggin()
        {
            Businesmanager = new Businesmanager();
            InitializeComponent();
        }

        private void LoggaInKnapp_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDtext.Text);
            Anställd A = Businesmanager.LoggaIn(ID, Lösenordtext.Text);

            if (A == null)
            {
                MessageBox.Show("Inloggningen misslyckades","Error");
            }
            else
            {
                Start start = new Start(Businesmanager);
                this.Hide();
                start.ShowDialog();
                this.Close();
            }
        }
    }
}
