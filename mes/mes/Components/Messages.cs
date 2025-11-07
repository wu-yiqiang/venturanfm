using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mes.Components
{
    public partial class Messages : Component
    {
        public Messages()
        {
            InitializeComponent();
        }

        public Messages(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public static void Error(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        public static void Success(string message)
        {
            MessageBox.Show(message, "Successful", MessageBoxButtons.OK);
        }
        public static void Warning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void Info(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
