using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace Office2007FormCS
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ApplyAeroTheme = false;

            this.UseOffice2007SchemeBackColor = true;

            Syncfusion.Windows.Forms.Office2007Colors.ApplyManagedColors(this, Color.FromArgb(255, 150, 200, 0));
        }
    }
}
