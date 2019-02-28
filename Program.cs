using System;

namespace myApp
{
    class Student {
        public string name;
        public float[] notes;
        public float media;
        
        public void SetName()
        {
            Console.WriteLine("Nome do aluno:");
            name = Console.ReadLine();
        }

        public void SetNotes()
        {
            notes = new float[4];
            for (int i = 0;i < notes.Length;i++) {
                Console.WriteLine($"Escreva a nota {i + 1}");

                float a;
                int x = 0;

                while (x == 0) {
                    string b = Console.ReadLine();
                    if (float.TryParse(b, out a)) {
                        if (a < 0 || a > 10) {
                            Console.WriteLine("Digite um valor entre 0 e 10");
                        } else {
                            notes[i] = a;
                            x++;
                        }
                    }
                    else {
                        Console.WriteLine("Letras, símbolos e espaços não devem ser utilizados - apenas números de 0 a 10. Escreva a nota do aluno");
                    }
                }
            }
        }
        public void CalcMedia()
        {
            for (int i = 0;i < notes.Length;i++) {
                media += notes[i] / 4;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Programa que pega as quatro notas de cada aluno de uma
            //turma de 10 alunos e retorna a média deles

            Console.WriteLine("Digite o número de alunos da turma:");

            int n = 0;
            while (n == 0) {
                string nStudents = Console.ReadLine();
                if (int.TryParse(nStudents, out n)) {
                    CreateClass(n);
                    n++;
                }
            }

            void CreateClass(int studentsNumber) {
                Student[] students = new Student[studentsNumber];
                double media = 0;

                for (int i = 0;i < students.Length;i++) {
                    Student std = new Student();
                    std.SetName();
                    std.SetNotes();
                    std.CalcMedia();
                    Console.WriteLine($"O aluno {std.name} obteve a média {std.media}, a partir das notas {std.notes[0]}, {std.notes[1]}, {std.notes[2]} e {std.notes[3]}.");

                    media += std.media / studentsNumber;
                }
                Console.WriteLine($"A média da classe é {media}");
            }

        }
    }
}