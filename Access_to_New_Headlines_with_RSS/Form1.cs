using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Access_to_New_Headlines_with_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void list(string link)
        {
            listBox1.Items.Clear();
            XmlTextReader xml = new XmlTextReader(link);
            while (xml.Read())
            {   if(xml.Name=="title")
                {
                    listBox1.Items.Add(xml.ReadString());
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            list("http://www.hurriyet.com.tr/rss/anasayfa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list("http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list("https://www.fotomac.com.tr/rss/anasayfa.xml");
        }
        //http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml
        //https://www.fotomac.com.tr/rss/anasayfa.xml
    }
}
