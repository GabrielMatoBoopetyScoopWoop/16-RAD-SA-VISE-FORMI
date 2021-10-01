using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSaViseFormiGabrielMatosevic01102021
{
    public partial class FormStudenti : Form
    {
        private List<Studenti> ListStudenti = new List<Studenti>();
        public FormStudenti()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }
        
        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta NoviStudent = new FormUnosNovogStudenta();
            NoviStudent.ShowDialog();
        }

        private void ListBoxStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
