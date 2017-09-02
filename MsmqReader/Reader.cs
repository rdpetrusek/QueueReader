using System;
using System.Messaging;
using System.Threading.Tasks;
using MsmqQueue;

namespace MsmqReader
{
    public class Reader
    {
        public string MachineName { get; private set; }
        public Reader(string machineName)
        {
            MachineName = machineName;
        }

        public void LoadQueues(Action<Queue> whenLoadedFunction, out int count)
        {
            var allPrivateQueues = MessageQueue.GetPrivateQueuesByMachine(MachineName);
            count = allPrivateQueues.Length;
            foreach (var queue in allPrivateQueues)
            {
                Task.Factory.StartNew(() =>
                {
                    if (!queue.CanRead)
                        return;
                    var queueObj = Queue.Create(queue);
                    queue.Close();
                    queue.Dispose();
                    whenLoadedFunction(queueObj);
                });
            }
        }
    }
}
