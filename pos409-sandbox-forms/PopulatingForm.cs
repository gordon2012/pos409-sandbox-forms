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
    public partial class PopulatingForm : Form
    {
        public PopulatingForm()
        {
            InitializeComponent();

            List<Fruit> fruitList = new List<Fruit>();

            fruitList.Add(new Fruit(0, "Apple"));
            fruitList.Add(new Fruit(1, "Banana"));
            fruitList.Add(new Fruit(2, "Cantaloupe"));
            fruitList.Add(new Fruit(3, "Date"));
            fruitList.Add(new Fruit(4, "Elderberry"));

            /*
            cmbFruits.Items.AddRange(fruitList.Select(f => f.Name).ToArray());
            cmbFruits.SelectedIndex = 0;
            //*/

            //*
            cmbFruits.DataSource = fruitList;
            cmbFruits.DisplayMember = "Name";
            cmbFruits.ValueMember = "Id";
            //*/
        }
    }

    class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Fruit(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

}
