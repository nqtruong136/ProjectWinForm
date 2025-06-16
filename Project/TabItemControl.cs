using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class TabItemControl : UserControl
    {
        public event EventHandler OnTabClick;
        public event EventHandler OnTabClose;
        public Button TabButton => btnTab;

        public TabItemControl(string name)
        {
            InitializeComponent();
           
            btnTab.Name = name;
        }

        private void TabItemControl_Load(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            OnTabClose?.Invoke(this, EventArgs.Empty);
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            OnTabClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
