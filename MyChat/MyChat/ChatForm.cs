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
    public partial class ChatForm : Form , IChatForm
    {

      

        public event Action<ChatForm> click;
        public event Action send;

        public string mesage { get; set; }


        public string NameLabel { get; set; }


        public ChatForm()
        {           
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

            mesage = textBox1.Text;
            textBox1.Clear();
            click?.Invoke(this);
            send?.Invoke();

        }

        public void UpdateList (List<string> mesages)
        {
            

            listBox1.Items.Clear();
            labelName.Text = NameLabel;
            listBox1.Items.AddRange(mesages.ToArray());
            
            
        }

    }
}
