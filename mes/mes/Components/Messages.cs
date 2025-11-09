using AntdUI;
using System.ComponentModel;
using System.Windows.Forms;

namespace mes.Components
{
    public partial class Messages : UserControl
{
        private AntdUI.Window window;

        public Messages()
        {
            InitializeComponent();
        }

        public Messages(IContainer container, AntdUI.Window _window)
        {
            window = _window;
            container.Add(this);
            InitializeComponent();
        }
        public static void Error(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        public static void Success(string message)
        {
            
        }
        public static void Warning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Info(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Question(string message)
        {
            MessageBox.Show(message, "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
