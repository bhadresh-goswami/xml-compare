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
            #region Code for xml compaire

            
            string path1 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\xml1.xml";
            string path2 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\xml2.xml";
            //MessageBox.Show(path, "hi", MessageBoxButtons.OK);
            DataSet ds1 = new DataSet();
            ds1.ReadXml(path1);


            DataSet ds2 = new DataSet();
            ds2.ReadXml(path2);
            string colsname = "";
            foreach (DataColumn cols in ds1.Tables[0].Columns)
            {
                bool isnot = true;
                foreach (DataColumn cols2 in ds2.Tables[0].Columns)
                {
                    //colsname += "->" + cols.ColumnName + "<-\n";
                    if (cols.ColumnName == cols2.ColumnName)
                    {
                        isnot = false;
                        break;
                    }
                }
                if (isnot == true)
                {
                    colsname += "->" + cols.ColumnName + "<-\n";
                }
            }
            MessageBox.Show(colsname, "hi!", MessageBoxButtons.OK);


            colsname = "";
            foreach (DataColumn cols in ds2.Tables[0].Columns)
            {
                bool isnot = true;


                foreach (DataColumn cols2 in ds1.Tables[0].Columns)
                {
                    if (cols.ColumnName == cols2.ColumnName)
                    {
                        isnot = false;
                        break;
                    }
                }
                if (isnot == true)
                {
                    colsname += "->" + cols.ColumnName + "<-\n";
                }
            }
            MessageBox.Show(colsname, "hi!", MessageBoxButtons.OK);

            string valueDiff = "";
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                DataRow dr1 = ds1.Tables[0].Rows[i];
                DataRow dr2 = ds2.Tables[0].Rows[i];

                for (int j = 0; j < ds1.Tables[0].Columns.Count; j++)
                {
                    if (ds1.Tables[0].Columns[j].ColumnName == ds2.Tables[0].Columns[j].ColumnName)
                    {
                        if (dr1[ds1.Tables[0].Columns[j].ColumnName].ToString() != dr2[ds2.Tables[0].Columns[j].ColumnName].ToString())
                        {
                            valueDiff += "ColName xml1: ";
                            valueDiff += ds1.Tables[0].Columns[j].ColumnName;
                            valueDiff += " ColName xml1 value: ";
                            valueDiff += dr1[ds1.Tables[0].Columns[j].ColumnName];
                            valueDiff += " && ColName xml2: ";
                            valueDiff += ds2.Tables[0].Columns[j].ColumnName;
                            valueDiff += " ColName xml2 value: ";
                            valueDiff += dr2[ds2.Tables[0].Columns[j].ColumnName];


                            valueDiff += "\n\n";


                        }
                    }
                }
            }

            MessageBox.Show(valueDiff);

            //            dataGridView1.DataSource = dtIntersect;

            #endregion
        }
    }
}
