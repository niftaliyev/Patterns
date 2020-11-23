using System;
using System.Collections.Generic;

namespace MyChat
{
    interface IChatForm
    {
         event Action<ChatForm> click;
         event Action send;
        string NameLabel { get; set; }
        string mesage { get; }
        void UpdateList(List<string> mesages);

    }
}
