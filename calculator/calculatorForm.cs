using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aProtect;
using Newtonsoft.Json;
using System.IO;
using calculatorFonction;

namespace calculator
{
    public partial class calculatorForm : Form
    {

        public static string code;
        public static string type;
        public static string dateAchat;
        public static string codeLicence;
        calculate cal = new calculate();
        keyClass licence = new keyClass();


        public calculatorForm()
        {

            InitializeComponent();
            if(licence.checkLicence())
            {
            }
            else
            {
                disableApp();
            }
        }

        public void disableApp()
        {
            textBoxNumberA.Enabled = false;
            textBoxNumberB.Enabled = false;
            textBoxResult.Enabled = false;
            buttonAddition.Enabled = false;
            buttonSubtraction.Enabled = false;
            buttonMultiplication.Enabled = false;
        }
        private void LabelMenuTitle_Click(object sender, EventArgs e)
        {

        }

        private void LabelNumberA_Click(object sender, EventArgs e)
        {

        }

        private void LabelNumberB_Click(object sender, EventArgs e)
        {

        }

        private void LabelResult_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNumberA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNumberB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAddition_Click(object sender, EventArgs e)
        {

            try
            {
                int i = cal.addition(int.Parse(textBoxNumberA.Text), int.Parse(textBoxNumberB.Text));
                textBoxResult.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonSubtraction_Click(object sender, EventArgs e)
        {
            try
            {
                int i = cal.subtraction(int.Parse(textBoxNumberA.Text), int.Parse(textBoxNumberB.Text));
                textBoxResult.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                int i = cal.multiplication(int.Parse(textBoxNumberA.Text), int.Parse(textBoxNumberB.Text));
                textBoxResult.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void initLicence()
        {
            keyClass licence = new keyClass();
            string resultAPI = licence.callAPI();
            string res = resultAPI;

            code = res[37].ToString() + res[38].ToString() + res[39].ToString() + res[40].ToString() + res[41].ToString();
            type = res[77].ToString();
            dateAchat = res[112].ToString() + res[113].ToString() + res[114].ToString() + res[115].ToString() + res[116].ToString() + res[117].ToString() + res[118].ToString()+ res[119].ToString()+ res[120].ToString()+ res[121].ToString();
            codeLicence = res[158].ToString() + res[159].ToString() + res[160].ToString() + res[161].ToString()
                                              + res[162].ToString() + res[163].ToString() + res[164].ToString() + res[165].ToString() + res[166].ToString() + res[167].ToString() + res[168].ToString() + res[169].ToString()
                                              + res[170].ToString() + res[171].ToString() + res[172].ToString() + res[173].ToString() + res[174].ToString() + res[175].ToString();
            string[] text = {code, type, dateAchat, codeLicence};

            licence.writeFile(text);
            StreamReader dataRead = licence.readFile();
            Console.WriteLine("DATA READ :" + dataRead);
        }
    }
}