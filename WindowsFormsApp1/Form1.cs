using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //#region Code for xml compaire


            //string path1 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\xml1.xml";
            //string path2 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\xml2.xml";
            ////MessageBox.Show(path, "hi", MessageBoxButtons.OK);
            //DataSet ds1 = new DataSet();
            //ds1.ReadXml(path1);


            //DataSet ds2 = new DataSet();
            //ds2.ReadXml(path2);
            //string colsname = "";
            //foreach (DataColumn cols in ds1.Tables[0].Columns)
            //{
            //    bool isnot = true;
            //    foreach (DataColumn cols2 in ds2.Tables[0].Columns)
            //    {
            //        //colsname += "->" + cols.ColumnName + "<-\n";
            //        if (cols.ColumnName == cols2.ColumnName)
            //        {
            //            isnot = false;
            //            break;
            //        }
            //    }
            //    if (isnot == true)
            //    {
            //        colsname += "->" + cols.ColumnName + "<-\n";
            //    }
            //}
            //MessageBox.Show(colsname, "hi!", MessageBoxButtons.OK);


            //colsname = "";
            //foreach (DataColumn cols in ds2.Tables[0].Columns)
            //{
            //    bool isnot = true;


            //    foreach (DataColumn cols2 in ds1.Tables[0].Columns)
            //    {
            //        if (cols.ColumnName == cols2.ColumnName)
            //        {
            //            isnot = false;
            //            break;
            //        }
            //    }
            //    if (isnot == true)
            //    {
            //        colsname += "->" + cols.ColumnName + "<-\n";
            //    }
            //}
            //MessageBox.Show(colsname, "hi!", MessageBoxButtons.OK);

            //string valueDiff = "";
            //for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            //{
            //    DataRow dr1 = ds1.Tables[0].Rows[i];
            //    DataRow dr2 = ds2.Tables[0].Rows[i];

            //    for (int j = 0; j < ds1.Tables[0].Columns.Count; j++)
            //    {
            //        if (ds1.Tables[0].Columns[j].ColumnName == ds2.Tables[0].Columns[j].ColumnName)
            //        {
            //            if (dr1[ds1.Tables[0].Columns[j].ColumnName].ToString() != dr2[ds2.Tables[0].Columns[j].ColumnName].ToString())
            //            {
            //                valueDiff += "ColName xml1: ";
            //                valueDiff += ds1.Tables[0].Columns[j].ColumnName;
            //                valueDiff += " ColName xml1 value: ";
            //                valueDiff += dr1[ds1.Tables[0].Columns[j].ColumnName];
            //                valueDiff += " && ColName xml2: ";
            //                valueDiff += ds2.Tables[0].Columns[j].ColumnName;
            //                valueDiff += " ColName xml2 value: ";
            //                valueDiff += dr2[ds2.Tables[0].Columns[j].ColumnName];


            //                valueDiff += "\n\n";


            //            }
            //        }
            //    }
            //}

            //MessageBox.Show(valueDiff);

            ////            dataGridView1.DataSource = dtIntersect;

            //#endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            lblFile1Name.Text = openFileDialog1.FileName;
            string xml1 = File.ReadAllText(openFileDialog1.FileName);
            xmlText1.Text = xml1;

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            lblFile2Name.Text = openFileDialog2.FileName;
            string xml2 = File.ReadAllText(openFileDialog2.FileName);
            xmlText2.Text = xml2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string xml1 = File.ReadAllText(openFileDialog1.FileName);
            string xml2 = File.ReadAllText(openFileDialog2.FileName);

            XmlReader node1 = XElement.Parse(xml1).CreateReader();
            XmlReader node2 = XElement.Parse(xml2).CreateReader();

            XDocument result = new XDocument();
            XmlWriter writer = result.CreateWriter();

            Microsoft.XmlDiffPatch.XmlDiff diff = new Microsoft.XmlDiffPatch.XmlDiff();
            diff.Compare(node1, node2, writer);
            writer.Flush();
            writer.Close();

            xmlText1.Text = xml1;
            xmlText2.Text = xml2;

            xmlTextDiff.Text = result.Document.ToString();
            
            foreach (XName name in result.Document.Root.DescendantNodes().OfType<XElement>()
        .Select(x => x.Name).Distinct())
            {
                int sindex = 0;
                while (sindex<xmlText1.Text.Length)
                {
                   // Console.WriteLine(result.Document.Element(name.LocalName).Value);
                    int windex = xmlText1.Find("Name", sindex, RichTextBoxFinds.None);
                    if (windex != -1)
                    {
                        xmlText1.SelectionStart = windex;
                        xmlText1.SelectionLength = name.LocalName.Length;
                        xmlText1.SelectionBackColor = Color.Yellow;
                        xmlText2.SelectionStart = windex;
                        xmlText2.SelectionLength = name.LocalName.Length;
                        xmlText2.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;

                    sindex += windex + name.LocalName.Length;
                }
                //Console.WriteLine(name);
            }
        }
    }
}
