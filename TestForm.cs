using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            var items = new List<TestItem>();
            items.Add(new TestItem
            {
                ID = 1,
                Text = "Bir"
            });
            items.Add(new TestItem
            {
                ID = 2,
                Text = "İki"
            });
            items.Add(new TestItem
            {
                ID = 3,
                Text = "Üç"
            });
            
            comboBox1.DataSource = items;
            comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember="Text";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString());

        }
    }
    class TestItem
    {
        public int ID { get; set; }
        public string Text { get; set; }
        
    }
   
}
