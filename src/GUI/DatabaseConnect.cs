using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseHelper
{
    public partial class DatabaseConnect : Form
    {
        public string Hostname;
        public int Port;
        public string Username;
        public string Password;

        public DatabaseConnect()
        {
            InitializeComponent();
        }

       
    }
}
