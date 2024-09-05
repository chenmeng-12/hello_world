using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForXiaoxiang
{
    public partial class FrmCreateFormula : Form
    {
        public FrmCreateFormula()
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
