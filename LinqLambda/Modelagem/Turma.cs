using System.Collections.Generic;

namespace LinqLambda
{
    public class Turma
    {
        public int Id { get; set; }
        public string NomeDaTurma { get; set; }
        public int IdCurso { get; set; }
        public int IdProfessor { get; set; }
        public List<int> Alunos { get; set; }
    }
}
