using System;

namespace TaskManager.Models
{
    public class TarefaModel
    {
        // Construtor para inicializar as propriedades
        public TarefaModel()
        {
            Nome = string.Empty;  // Inicializa com uma string vazia
            Descricao = string.Empty;  // Inicializa com uma string vazia
        }

        // Propriedade Id para identificar a tarefa
        public int Id { get; set; }

        // Propriedade Nome da tarefa
        public string Nome { get; set; }

        // Propriedade Descrição da tarefa
        public string Descricao { get; set; }

        // Data de criação da tarefa
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        // Indica se a tarefa está concluída
        public bool Concluida { get; set; }
    }
}
