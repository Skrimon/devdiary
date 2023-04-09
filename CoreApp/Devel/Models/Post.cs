using System.ComponentModel.DataAnnotations;

namespace Devel.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostedDateTime { get; set; }

        public string? Content { get; set; }
    }
}
