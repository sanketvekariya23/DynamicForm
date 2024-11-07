
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Form.Model
{
    public class Forms
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]public int Id { get; set; }
        [Required] public string Title { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}