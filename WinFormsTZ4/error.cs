using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTZ4
{
    public partial class error : Form
    {
        string msg;
        public error(string msg)
        {
            InitializeComponent();
            this.msg = msg;
            message.Text = msg;
        }
    }
}
