using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChat
{

    class ChatMediator
    {

        public static List<string> mesages = new List<string>();

        public static List<IChatForm> chatForms = new List<IChatForm>();

        


        public ChatMediator(IForm form)
        {
            
            form.addClick += addClick;
            ChangedMesagesList();

        }

        public void addClick(string name)
        {
            var window = new ChatForm();
            window.NameLabel = name;
            chatForms.Add(window);
            window.click += SendMesage;
            window.send += ChangedMesagesList;
            window.Show();
            mesages.Add($"{name}, is joined");
            ChangedMesagesList();
        }

        static void ChangedMesagesList()
        {
            foreach (var item in chatForms)
            {                
                item.UpdateList(mesages);
                
            }
        }

        public void SendMesage(IChatForm chat)
        {
            
            mesages.Add($"{chat.NameLabel}: {chat.mesage}");
            ChangedMesagesList();


        }

    }
}
