namespace CloudTalkApi.Models
{
    public class Receiver
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string MessageContent { get; set; }

        //this will be a one to one relationship
        public Sender Sender { get; set; }

    }
}
