using System.ComponentModel.DataAnnotations;

namespace New_API.Models
{
    public class Values
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}