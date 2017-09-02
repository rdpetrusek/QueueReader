using System.Collections.Generic;
using System.Messaging;
using System.Threading.Tasks;

namespace MsmqQueue
{
    public class Queue
    {
        private IEnumerable<Message> _messages;
        public IEnumerable<Message> Messages
        {
            get
            {
                ReadMessages();
                return _messages;
            } 
        }

        public void ReadMessages()
        {
            if (_messages != null)
                return;
            var allMessages = new List<Message>(1000);
            using (var queue = new MessageQueue(FullQueueName, QueueAccessMode.Peek))
            {
                if (!queue.CanRead)
                    return;
                queue.MessageReadPropertyFilter = new MessagePropertyFilter
                {
                    Extension = true,
                    Body = true
                };
                foreach (var message in queue.GetAllMessages())
                {
                    allMessages.Add(new Message(message));
                    message.Dispose();
                }
                queue.Close();
            }
            _messages = allMessages;
        }

        private void SetMessages(IEnumerable<Message> messages)
        {
            _messages = messages;
        }

        public string Name { get; private set; }
        public int MessageCount { get; private set; }
        public string MachineName { get; private set; }
        public string FullQueueName { get; private set; }

        private Queue(string queueName, string machineName, int messageCount)
        {
            Name = queueName;
            MachineName = machineName;
            MessageCount = messageCount;
            FullQueueName = string.Format("FormatName:DIRECT=OS:{0}\\{1}", machineName, queueName);
        }

        public override string ToString()
        {
            var queueTypeStringIndex = Name.IndexOf("private$");
            var messageCount = string.Format(" ({0})", MessageCount);
            return (queueTypeStringIndex > -1 
                       ? Name.Substring(9)
                       : Name) + messageCount;
        }

        public static Queue Create(string name, string machineName, int messageCount)
        {
            return new Queue(name, machineName, messageCount);
        }

        public static Queue Create(MessageQueue queue)
        {
            var messages = GetMessages(queue);
            var newQueue = Create(queue.QueueName, queue.MachineName, messages.Count);
            if(messages.Count > 0)
                newQueue.SetMessages(messages);
            return newQueue;
        }

        protected static List<Message> GetMessages(MessageQueue q)
        {
            q.MessageReadPropertyFilter = new MessagePropertyFilter
            {
                Extension = true,
                Body = true
            };
            var allMessagesList = new List<Message>();
            foreach (var message in q.GetAllMessages())
            {
                allMessagesList.Add(new Message(message));
            }

            return allMessagesList;
        }

    }
}