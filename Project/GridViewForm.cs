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
using System.Xml.Linq;
namespace Project
{
    public partial class GridViewForm : Form
    {

        
        public GridViewForm()
        {
            InitializeComponent();
        }

        //Load xml
        private void GridViewForm_Load(object sender, EventArgs e)
        {
            //Create xml reader
            XmlReader xmlFile = XmlReader.Create("Serialized.xml", new XmlReaderSettings());
            DataSet dataSet = new DataSet();

            //Read xml to dataset
            dataSet.ReadXml(xmlFile);
            //Pass empdetails table to datagridview datasource
            dataGridView1.DataSource = dataSet.Tables["ABooks"];
        }
    }
}
