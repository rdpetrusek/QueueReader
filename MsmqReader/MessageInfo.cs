using System.Text.RegularExpressions;

namespace MsmqQueue
{
    public class MessageInfo
    {
        public void SetValue(string key, string value)
        {
            switch (key)
            {
                case "NServiceBus.EnclosedMessageTypes":
                    _MessageType = value.Split(',')[0];
                    break;
                case "SubscriptionMessageType":
                    _MessageType = value.Split(',')[0];
                    break;
                case "NServiceBus.MessageId":
                    MessageId = value;
                    break;
                case "NServiceBus.CorrelationId":
                    CorrelationId = value;
                    break;
                case "NServiceBus.MessageIntent":
                    MessageIntent = value;
                    break;
                case "NServiceBus.ProcessingEndpoint":
                    ProcessingEndpoint = value;
                    break;
                case "NServiceBus.ProcessingMachine":
                    ProcessingMachine = value;
                    break;
                case "NServiceBus.ProcessingStarted":
                    ProcessingStarted = value;
                    break;
                case "NServiceBus.ContentType":
                    ContentType = value;
                    break;
                case "NServiceBus.ProcessingEnded":
                    ProcessingEnded = value;
                    break;
                case "NServiceBus.ExceptionInfo.ExceptionType":
                    _ExceptionType = value;
                    break;
                case "NServiceBus.ExceptionInfo.InnerExceptionType":
                    InnerExceptionType = value;
                    break;
                case "NServiceBus.ExceptionInfo.Message":
                    ExceptionMessage = value;
                    break;
                case "NServiceBus.ExceptionInfo.Source":
                    ExceptionSource = value;
                    break;
                case "NServiceBus.ExceptionInfo.StackTrace":
                    ExceptionStackTrace = value;
                    break;
                case "NServiceBus.FailedQ":
                    FailedQ = value;
                    break;
                case "NServiceBus.TimeOfFailure":
                    TimeOfFailure = value;
                    break;
                default:
                    break;
            }
        }

        public void ClearValues()
        {
            _MessageType = null;
            CorrelationId = null;
            MessageIntent = null;
            ProcessingEndpoint = null;
            ProcessingMachine = null;
            ProcessingStarted = null;
            ContentType = null;
            ProcessingEnded = null;
            _ExceptionType = null;
            InnerExceptionType = null;
            ExceptionMessage = null;
            ExceptionSource = null;
            ExceptionStackTrace = null;
            FailedQ = null;
            TimeOfFailure = null;
            MessageId = null;
        }

        public string _MessageType { get; set; }

        public string CorrelationId { get; set; }

        public string MessageIntent { get; set; }

        public string ProcessingEndpoint { get; set; }

        public string ProcessingMachine { get; set; }

        public string ProcessingStarted { get; set; }

        public string ContentType { get; set; }

        public string ProcessingEnded { get; set; }

        public string _ExceptionType { get; set; }

        public string InnerExceptionType { get; set; }

        public string ExceptionMessage { get; set; }

        public string ExceptionSource { get; set; }

        public string ExceptionStackTrace { get; set; }

        public string FailedQ { get; set; }

        public string TimeOfFailure { get; set; }

        public string MessageId { get; set; }
        
        private static string extensionRegex = @"<HeaderInfo>.*?<Key>(.*?)</Key>.*?<Value>(.*?)</Value>.*?</HeaderInfo>";
        private static Regex headerInfoRegex = new Regex(extensionRegex, RegexOptions.Singleline);

        public static MessageInfo Parse(string extensionString)
        {
            var infoToReturn = new MessageInfo();
            if (string.IsNullOrWhiteSpace(extensionString))
                return infoToReturn;
            foreach (Match match in headerInfoRegex.Matches(extensionString))
            {
                if (match.Groups.Count != 3)
                    continue;
                var key = match.Groups[1].Value;
                var value = match.Groups[2].Value;
                infoToReturn.SetValue(key, value);
            }

            return infoToReturn;
        }
    }
}