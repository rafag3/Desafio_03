using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos alunos você deseja adicionar?");
        int quantidadeAlunos = int.Parse(Console.ReadLine());

        string nomeAlunoComMaiorNota = "";
        float maiorNota = 0.0f;

        for (int i = 0; i < quantidadeAlunos; i++)
        {
            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a nota do aluno:");
            float nota = float.Parse(Console.ReadLine());

            if (nota > maiorNota)
            {
                maiorNota = nota;
                nomeAlunoComMaiorNota = nome;
            }
        }

        Console.WriteLine("O aluno com a maior nota é: " + nomeAlunoComMaiorNota + " com nota " + maiorNota);
        Console.ReadLine();
    }
}