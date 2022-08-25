using System.ComponentModel.DataAnnotations;

namespace Portfalio.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string Details { get; set; }

    }
}
