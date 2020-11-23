using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChat
{
    interface IForm
    {
        event Action<string> addClick;
    }
    public partial class Form1 : Form , IForm
    {
        public event Action<string> addClick;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addClick?.Invoke(textBox.Text);

        }


    }
}
