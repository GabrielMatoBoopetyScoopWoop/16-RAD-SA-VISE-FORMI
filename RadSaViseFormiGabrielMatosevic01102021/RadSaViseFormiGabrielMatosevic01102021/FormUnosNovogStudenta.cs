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
    public partial class FormUnosNovogStudenta : Form
    {
        private List<Studenti> ListStudenti;
        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSnimi_Click(object sender, EventArgs e)
        {
            Studenti Student = new Studenti(textBoxIme.Text,textBoxPrezime.Text,textBoxBrojIndeksa.Text,comboBoxSmjer.Text, dateTimePickerDatumRodenja.Value);
            ListStudenti.Add(Student);
            this.Close();
        }
    }
}
