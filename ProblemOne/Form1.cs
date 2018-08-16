using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            string text1 = txtText1.Text;
            string text2 = txtText2.Text;

            SearchWordCount(text1,text2);
        }

        private void SearchWordCount(string text1,string text2)
        {
            int textLength1 = text1.Length;
            int textLength2 = text2.Length;

            MatchCollection collection = textLength1 > textLength2 ? Regex.Matches(text1, text2) : Regex.Matches(text2, text1);
            int count = collection.Count;
            MessageBox.Show("Aradığınız kısa kelime uzun yazı içerisinde : " + count.ToString() + " kez geçmektedir.");
        }
    }
}
