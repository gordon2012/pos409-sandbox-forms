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
    public partial class OverdraftForm : Form
    {
        public OverdraftForm()
        {
            InitializeComponent();
        }
    }


    class BankAccount
    {
        public double Balance { get; set; }

    }


}
