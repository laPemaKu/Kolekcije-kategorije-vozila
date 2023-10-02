using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kolekcije_Kategorije_vozila_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for(int i = 2023; i > 1769; i--)
            {
                comGodine.Items.Add(i);
            }
        }
        List<Vozilo> voziloList;
        
        private void btnUnos_Click(object sender, EventArgs e)
        {
            
                string model = txtModel.Text;
                int godina_proizvodnje = Convert.ToInt32(comGodine.SelectedItem.ToString()), broj_kotača = Convert.ToInt32(txtBrojKotaca.Text);
                Vozilo vozilo = new Vozilo(model, godina_proizvodnje, broj_kotača);
                voziloList.Add(vozilo);
            
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            /*foreach(Vozilo vozilo in voziloList)
            {

            }*/
        }
    }
}
