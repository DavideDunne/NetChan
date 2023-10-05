using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Imageboard.Models
{
    public class OriginalPoster : Post
    {
        public char Board {  get; set; }
    }
}
