using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _ekransayi1;
        private int _ekransayi2;
        private string _ekransil;
        private string _islem;
        private int _sonuc;


        private void ekranlabel_Click(object sender, EventArgs e)
        {

           
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if(ekranlabel.Text=="0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "3";

        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "9";
        }

        private void rakam0buton_Click(object sender, EventArgs e)
        {

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "0";
        }

        private void cbuton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "";
        }

        private void toplamabutton_Click(object sender, EventArgs e)
        {
            _ekransayi1 = Convert.ToInt32(ekranlabel.Text);
            _islem = "+";
            ekranlabel.Text = "";

        }

        private void çıkartmabuton_Click(object sender, EventArgs e)
        {
            _ekransayi1 = Convert.ToInt32(ekranlabel.Text);
            _islem = "-";
            ekranlabel.Text = "";

        }

        private void çarpmabuton_Click(object sender, EventArgs e)
        {
            _ekransayi1 = Convert.ToInt32(ekranlabel.Text);
            _islem = "*";
            ekranlabel.Text = "";

        }

        private void bölmebuton_Click(object sender, EventArgs e)
        {
            _ekransayi1 =Convert.ToInt32(ekranlabel.Text);
            _islem = "/";
            ekranlabel.Text = "";
        }

        private void eşittirbuton_Click(object sender, EventArgs e)
        {
          _ekransayi2 = Convert.ToInt32(ekranlabel.Text);
            switch(_islem)
            {
                case "+":
                    _sonuc = _ekransayi2 + _ekransayi1;
                    break;
                case "-":
                    _sonuc = _ekransayi1 - _ekransayi2;
                    break;
                case "*":
                    _sonuc = _ekransayi2 * _ekransayi1;
                    break;
                case "/":
                    _sonuc = _ekransayi2 / _ekransayi1;
                    break;
            }
            ekranlabel.Text = Convert.ToString(_sonuc);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
