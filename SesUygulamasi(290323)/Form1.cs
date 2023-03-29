using System.Reflection;

namespace SesUygulamasi_290323_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void btnNokia_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.SesCal();
        }

        private void btniphone_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone();   
            iphone.SesCal();
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();    
            samsung.SesCal();
        }

        private void btnTelefon_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            phone.SesCal();
        }
    }
}