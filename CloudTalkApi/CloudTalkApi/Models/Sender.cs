namespace CloudTalkApi.Models
{
    public class Sender
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string MessageContent { get; set; }
        //this will be a one to one relationship
        public Receiver Receiver { get; set; }
    }
}
