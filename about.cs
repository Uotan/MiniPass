using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("UH.gif");
        }
    }
}
