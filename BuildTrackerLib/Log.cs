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
        public List<Message> t = new List<Message>();



        public void WriteMessage(string _msg, msg_type _type, string _source) {
            t.Add(new Message(_msg, _type, _source));
            OnNewMessage();
        }


        //Initiate EventHandler
        public delegate void LogEventHandler(object source, EventArgs args);
        //Register NewMessage Event
        public event LogEventHandler NewMessage;

        //Alert Event-Subscribers
        protected virtual void OnNewMessage() {
            if (NewMessage != null)
                NewMessage(this, EventArgs.Empty);
        }




        public enum msg_type {
            INFO,
            WARNING,
            CRITICAL,
            HIGHLIGHTED
        };

        //Class to offer an Object for every single message.
        public class Message {
            private string Date_Send;
            private string Source;
            private string Msg;
            private msg_type Type;

            public Message(string _msg, msg_type _type, string _source) {
                Msg = _msg;
                Type = _type;
                Source = _source;
                Date_Send = DateTime.Now.ToString("HH:MM:SS");
            }

        }
    }
}
