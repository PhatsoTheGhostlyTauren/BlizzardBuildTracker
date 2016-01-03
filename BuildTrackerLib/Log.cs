using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace BuildTrackerLib
{
    public class Log
    {
        public List<Message> Messages = new List<Message>();


        public void WriteMessage(string _msg, string _source) {
            addMessage(new Message(_msg, "#000000", _source));
        }

        public void WriteWarning(string _msg, string _source)
        {
            addMessage(new Message(_msg, "#ff0000", _source));
        }

        public int WriteProgress(string _msg, string _source) {
           return addMessage(new Message(_msg, "#000000", _source));
        }



        public void updateProgress(string _msg, int _index) {
            this.Messages[_index].Msg = _msg;
            OnMessageUpdate();
        }

        public int addMessage(Message _msg) {
            Messages.Add(_msg);
            OnNewMessage();
            int id = Messages.IndexOf(Messages.Last());
            return id;
        }

        //Initiate EventHandler
        public delegate void LogEventHandler(object source, EventArgs args);
        //Register NewMessage Event
        public event LogEventHandler NewMessage;
        public event LogEventHandler MessageUpdate;

        //Alert Event-Subscribers
        protected virtual void OnNewMessage() {
            if (NewMessage != null)
                NewMessage(this, EventArgs.Empty);
        }

        protected virtual void OnMessageUpdate() {
            Console.WriteLine("OnMessageUpdate() fired");
            if (MessageUpdate != null)
                MessageUpdate(this, EventArgs.Empty);
        }


        //Class to offer an Object for every single message.
        public class Message {
            public string Date_Send;
            public string Source;
            public string Msg;
            public string color;

            public Message(string _msg,string _color, string _source) {
                Msg = _msg;
                color = _color;
                Source = _source;
                Date_Send = DateTime.Now.ToString("hh:mm:ss");
            }

        }
    }
}
