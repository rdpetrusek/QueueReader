using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MsmqQueue;
using MsmqReader;

namespace QueueReader
{
    public partial class Reports : Form
    {
        private readonly IEnumerable<MessageInfo> _messages;

        public Reports(string reportName, IEnumerable<MessageInfo> messages)
        {
            _messages = messages;
            InitializeComponent();

            groupingComboBox.Items.Add(CreateGrouping("Stack Trace", x => x.ExceptionStackTrace));
            groupingComboBox.Items.Add(CreateGrouping("Message Type", x => x._MessageType));
            groupingComboBox.Items.Add(CreateGrouping("Exception Message", x => x.ExceptionMessage));

            groupingComboBox.SelectedItem = groupingComboBox.Items[0];
            this.Text = "Report: " + reportName;
        }

        public Grouping CreateGrouping(string name, Func<MessageInfo, string> property)
        {
            return new Grouping(name, _messages, property);
        }

        public Grouping GetComboBoxGrouping()
        {
            return groupingComboBox.SelectedItem as Grouping;
        }

        public Group GetSelectedGroup()
        {
            return groupListBox.SelectedItem as Group;
        }

        public void SetDisplayText(Group group)
        {
            GroupValueTextBox.Text = string.Empty;

            if (group == null || group.Value == null)
            {
                GroupValueTextBox.Text = string.Empty;
                return;
            };
            GroupValueTextBox.Text = group.Value;
        }

        public void ClearGroupsList()
        {
            groupListBox.Items.Clear();
        }

        public void SetDisplayedGroups(IEnumerable<Group> groups)
        {
            ClearGroupsList();
            foreach (var group in groups.OrderByDescending(x => x.Count))
            {
                groupListBox.Items.Add(group);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGrouping = GetComboBoxGrouping();
            SetDisplayedGroups(selectedGrouping.Groups.Value);
        }

        private void groupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var group = GetSelectedGroup();
            SetDisplayText(group);
        }
    }
}
