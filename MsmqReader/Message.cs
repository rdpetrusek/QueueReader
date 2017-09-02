using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MsmqQueue
{
    public class Message
    {
        public string Body { get; set; }
        public string Extension { get; set; }
        public string Name { get; set; }

        public Message(System.Messaging.Message message)
        {
            Extension = Encoding.UTF8.GetString(message.Extension);
            using (var reader = new StreamReader(message.BodyStream))
            {
                Body = reader.ReadToEnd();
            }
            Name = MessageInfo.Parse(Extension)._MessageType ?? "No Type";
            message.Dispose();
        }

        public static IEnumerable<Message> Create(System.Messaging.Message[] messages)
        {
            foreach (var message in messages)
            {
                yield return new Message(message);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}