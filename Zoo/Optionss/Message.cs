namespace Zoo.Optionss
{
    public class Message
    {
        public string Text { get; set; }

        public string SenderName { get; set; }

        public string SenderType { get; set; }

        public MessageType MessageType { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Message message &&
                   Text == message.Text &&
                   SenderName == message.SenderName &&
                   SenderType == message.SenderType &&
                   MessageType == message.MessageType;
        }

        public override string ToString()
        {
            return $"{SenderType} {SenderName}:{MessageType} {Text}";
        }
    }
}
