using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class CreateParamter : Form
    {
        public CreateParamter()
        {
            InitializeComponent();
        }
        public byte Index
        {
            get
            {
                byte.TryParse(txtID.Text, out var number);
                return number;
            }
        }

        public string FormulaName => txtName.Text;
    }
}
