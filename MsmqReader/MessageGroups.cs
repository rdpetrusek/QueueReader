using System;
using System.Collections.Generic;
using System.Linq;
using MsmqQueue;

namespace MsmqReader
{
    public class Grouping
    {
        public Lazy<IEnumerable<Group>> Groups;
        public string Name { get; private set; }
        public Grouping(string displayName, IEnumerable<MessageInfo> messages, Func<MessageInfo, string> property)
        {
            var test = messages.GroupBy(x => x._MessageType);

            Groups = new Lazy<IEnumerable<Group>>(() =>
            {
                return messages.GroupBy(property).Select(x => new Group(x.Key, x.ToList(), property));
            });
            Name = displayName;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Group
    {
        public int Count { get; protected set; }
        public IEnumerable<MessageInfo> Messages { get; protected set; }
        public string Name { get; private set; }
        public string Value { get; private set; }

        public override string ToString()
        {
            var shortName = Name.Length > 103 ? Name.Substring(0, 100) + "..." : Name;
            return string.Format("({0}) {1}", Count, shortName);
        }

        public Group(string name, IEnumerable<MessageInfo> messages, Func<MessageInfo, string> property)
        {
            Count = messages.Count();
            Messages = messages;
            Name = name ?? "None";
            Value = messages.Select(property).First();
        }
    }
}
