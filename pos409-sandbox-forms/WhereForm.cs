using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos409_sandbox_forms
{
    public partial class WhereForm : Form
    {
        public WhereForm()
        {
            InitializeComponent();

            //System.Data.Common.DbCommand
            //System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection();
            //cn.Open();
            //System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

            //List<string> slist = new List<string>();

            //slist.con
            //System.Data.SqlClient.SqlCommand

            List<int> iList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                iList.Add(i);
            }


            List<int> jList = new List<int>();
            jList.AddRange(from i in iList where iList.Contains(i % 2) select i);
            jList.ForEach(i => Console.WriteLine(i));
            
            //iList.AddRange();

            List<Person> pList = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Thomas",
                    LastName = "Anderson"
                },
                new Person()
                {
                    FirstName = "Zero",
                    LastName = "Cool"
                }
            };

            var firstNames = pList.Select(p => new { p.FirstName });

            foreach (var name in firstNames)
            {
                Console.WriteLine(name.FirstName);
                
            }

            //firstNames.ForEach(i => Console.WriteLine(i));



        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
