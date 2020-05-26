using System;
using System.Collections.Generic;

namespace LinqLambda
{
    public static class PreenchimentoDeDados
    {   
        public static List<Aluno> CriarAlunos()
        {
            return new List<Aluno>()
            {
                new Aluno()
                {
                    Id = 1,
                    Nome = "Joao",
                    Telefone = "1111-1111",
                    DataNasc = new DateTime(1990, 05, 20),
                    Email = "joao@gmail.com"
                },
                new Aluno()
                {                     
                    Id = 2,
                    Nome = "Maria",
                    Telefone = "1111-1112",
                    DataNasc = new DateTime(1990, 05, 30),
                    Email = "maria@gmail.com"
                },
                new Aluno()
                {
                    Id = 3,
                    Nome = "Joana",
                    Telefone = "1111-1113",
                    DataNasc = new DateTime(1990, 09, 30),
                    Email = "joana@gmail.com"
                }
            };            
        }

        public static List<Curso> CriarCursos()
        {
            return new List<Curso>()
            {
                new Curso()
                {
                    Id = 1,
                    NomeDoCurso = "Aceleração de C#",
                    Descricao = "Curso intensivo de C# para iniciantes"
                },
                new Curso()
                {
                    Id = 2,
                    NomeDoCurso = "Aceleração de React",
                    Descricao = "Curso intensivo de React para iniciantes"
                },
                new Curso()
                {
                    Id = 3,
                    NomeDoCurso = "Aceleração de Ciência de Dados",
                    Descricao = "Curso intensivo de Ciência de Dados para iniciantes"
                }
            };
        }

        public static List<Professor> CriarProfessores()
        {
            return new List<Professor>()
            {
                new Professor()
                {
                    Id = 1,
                    DataNasc = new DateTime(1988, 09, 30),
                    Email = "thamirys@gmail.com",
                    Nome = "Thamirys",
                    Telefone = "2222-2222",
                    AptoParaCursos = new List<int>(){1}
                },
                new Professor()
                {
                    Id = 2,
                    DataNasc = new DateTime(1988, 04, 30),
                    Email = "pedro@gmail.com",
                    Nome = "Pedro",
                    Telefone = "2222-2223",
                    AptoParaCursos = new List<int>(){1,2}
                },
                new Professor()
                {
                    Id = 3,
                    DataNasc = new DateTime(1988, 06, 30),
                    Email = "carla@gmail.com",
                    Nome = "Carla",
                    Telefone = "2222-2224",
                    AptoParaCursos = new List<int>(){3}
                },
            };
        }

        public static List<Turma> CriarTurma()
        {
            return new List<Turma>()
            { 
                new Turma()
                {
                    Id = 1,
                    Alunos = new List<int>() { 1, 2, 3 },
                    IdCurso = 1,
                    IdProfessor = 1,
                    NomeDaTurma = "Aceleração de C# Virtual da Thamy"
                } 
            };
        }
    }
}
