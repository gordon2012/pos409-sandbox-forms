using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace pos409_sandbox_forms
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(label2.Text) > 0)
	        {
                label2.Text = (int.Parse(label2.Text)-1).ToString();
		 
	        }

            CancellationTokenSource cts = new CancellationTokenSource();

            //cancellationtoken cts.Token

            CancellationToken token = cts.Token;

            

        }


        //public event 



    }





}
