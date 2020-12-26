using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniOS_Simulator
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.help1;
        }
    }
}
