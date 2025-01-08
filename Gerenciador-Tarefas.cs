using System;
using System.Collections.Generic;

class GerenciadorDeTarefas
{
    static List<string> tarefas = new List<string>();
    static List<bool> statusTarefas = new List<bool>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Gerenciador de Tarefas");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Marcar Tarefa como Concluída");
            Console.WriteLine("3. Visualizar Tarefas");
            Console.WriteLine("4. Sair");
            Console.WriteLine("O que você deseja fazer? (escolha 1-4)");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    AdicionarTarefa();
                    break;
                case "2":
                    ConcluirTarefa();
                    break;
                case "3":
                    VisualizarTarefas();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Escolha inválida, tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarTarefa()
    {
        Console.WriteLine("Digite a descrição da tarefa:");
        string tarefa = Console.ReadLine();
        tarefas.Add(tarefa);
        statusTarefas.Add(false);  // Marcando como não concluída por padrão
        Console.WriteLine("Tarefa adicionada com sucesso.");
    }

    static void ConcluirTarefa()
    {
        Console.WriteLine("Digite o número da tarefa para marcar como concluída:");
        int numeroTarefa = int.Parse(Console.ReadLine()) - 1; // Subtrai 1 para obter o índice correto

        if (numeroTarefa < 0 || numeroTarefa >= tarefas.Count)
        {
            Console.WriteLine("Número de tarefa inválido.");
            return;
        }

        statusTarefas[numeroTarefa] = true; // Marca a tarefa como concluída
        Console.WriteLine($"Tarefa '{tarefas[numeroTarefa]}' marcada como concluída.");
    }

    static void VisualizarTarefas()
    {
        Console.WriteLine("Tarefas:");
        for (int i = 0; i < tarefas.Count; i++)  // Alteração de <= para <
        {
            string status = statusTarefas[i] ? "Concluída" : "Pendente";
            Console.WriteLine($"{i + 1}. {tarefas[i]} - {status}");
        }
    }
}
