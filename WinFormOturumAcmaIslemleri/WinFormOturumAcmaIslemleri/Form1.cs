using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormOturumAcmaIslemleri.Models;

namespace WinFormOturumAcmaIslemleri
{
    public partial class Form1 : Form
    {
        WinFormOturumAcmaIslemleriEntitiesConnectionDb db = new WinFormOturumAcmaIslemleriEntitiesConnectionDb();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static int Id;

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Durum = db.PersonelGirisTablosu.FirstOrDefault(x => x.MailAdress == MailKontrol.Text && x.Password == SifreKontrol.Text);
            if (Durum != null)
            {
                Id = Durum.Id;
                GirisBasarili gb = new GirisBasarili();
                gb.ShowDialog();

            }
            else
            {
                MessageBox.Show("Girilen bilgiler hatalıdır", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ŞİfreSıfırlama st= new ŞİfreSıfırlama();
            st.ShowDialog();
        }
    }
}
