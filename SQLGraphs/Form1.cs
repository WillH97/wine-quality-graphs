using DbUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLGraphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();
            
            for (int i = 0; i < subjects.Count; i++)
                subjects[i].print();
            
            Form2 Graphs = new Form2();
            Graphs.Show();
            //this.Close();
        }
    }
}
