namespace API.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string To { get; set; }
        public DateTime DateSent { get; set; }
    }
}