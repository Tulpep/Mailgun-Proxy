namespace Tulpep.Signtul.Entities
{
    public class EmailMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string FromCompany { get; set; }
        public string FromEmailAddress { get; set; }
        public string FromName { get; set; }
    }
}
