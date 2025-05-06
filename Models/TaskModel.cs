using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        public required string Description { get; set; }

        public TaskModel(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public TaskModel() { }
    }
}
