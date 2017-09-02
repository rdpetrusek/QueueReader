using System;
using System.Linq;
using System.Windows.Forms;
using MsmqQueue;
using MsmqReader;
using Message = MsmqQueue.Message;

namespace QueueReader
{
    public partial class Main : Form
    {
        public Reader MsmqReader { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void LoadQueues()
        {
            MsmqReader = new Reader(serverNameTextBox.Text);

            queueListBox.Items.Clear();
            int totalQueues = 0;
            int loaded = 0;
            object lockObject = new object();
            MsmqReader.LoadQueues(x =>
            {
                Invoke(new MethodInvoker(delegate
                {
                    queueListBox.Items.Add(x);
                    lock (lockObject)
                    {
                        loaded++;
                        queueLoadProgress.Value = loaded;
                        if (queueLoadProgress.Value == queueLoadProgress.Maximum)
                            queueLoadProgress.Visible = false;
                    }
                }));
            }, out totalQueues);

            queueLoadProgress.Visible = true;
            queueLoadProgress.Maximum = totalQueues;
            queueLoadProgress.Step = 1;
        }

        private void ClearMessageTextBox()
        {
            messageTextBox.Clear();
        }

        private Message GetCurrentMessage()
        {
            return messageListBox.SelectedItem as Message;
        }
        private Queue GetCurrentQueue()
        {
            return queueListBox.SelectedItem as Queue;
        }

        private void LoadMessageBody(Message message)
        {
            messageTextBox.Text = message.Body;
            extensionTextBox.Text = message.Extension;
        }

        private void ClearMessagesList()
        {
            messageListBox.Items.Clear();
            ClearMessageTextBox();
        }

        private void PopulateMessagesList(Queue queue)
        {
            ClearMessagesList();
            foreach (var queueMessage in queue.Messages)
            {
                messageListBox.Items.Add(queueMessage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearMessagesList();
            LoadQueues();
        }

        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var queue = GetCurrentQueue();
            PopulateMessagesList(queue);
        }

        private void messageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var message = GetCurrentMessage();
            LoadMessageBody(message);
        }

        private void serverNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadQueues();
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            var queue = GetCurrentQueue();
            var messageInfos = queue.Messages.Select(x => MessageInfo.Parse(x.Extension)).ToList();
            var newReport = new Reports(queue.ToString(), messageInfos);
            newReport.Show();
        }
    }
}
