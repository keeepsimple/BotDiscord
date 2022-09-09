namespace BotUnunin.Models
{
    public class ImageOfUs
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public int LoveId { get; set; }

        public Love Love { get; set; }
    }
}