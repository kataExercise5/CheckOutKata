using ScannerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckOut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myInit()
        {
            DateTime purchaseDate = new DateTime(2018, 11, 19);
            Scanner scanner = new Scanner(purchaseDate);
        }
    }
}
