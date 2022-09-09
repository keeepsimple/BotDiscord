using System.ComponentModel.DataAnnotations.Schema;

namespace BotUnunin.Models
{
    public class Love
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual IEnumerable<ImageOfUs> ImageOfUss { get; set; }
    } 
}