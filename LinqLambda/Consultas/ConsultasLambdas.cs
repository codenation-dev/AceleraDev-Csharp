using System.Collections.Generic;
using System.Linq;

namespace LinqLambda
{
    public class ConsultasLambdas
    {
        private List<Aluno> TabelaAlunos { get; set; }
        private List<Curso> TabelaCursos { get; set; }
        private List<Professor> TabelaProfessores { get; set; }
        private List<Turma> TabelaTurmas { get; set; }

        public ConsultasLambdas()
        {
            TabelaAlunos = PreenchimentoDeDados.CriarAlunos();
            TabelaCursos = PreenchimentoDeDados.CriarCursos();
            TabelaProfessores = PreenchimentoDeDados.CriarProfessores();
            TabelaTurmas = PreenchimentoDeDados.CriarTurma();
        }

        public List<string> SelecionarNomeDosAlunos()
        {
            return TabelaAlunos.Select(x => x.Nome).ToList();
        }

        public List<string> SelecionarProfessorPorCurso(int idCurso)
        {
            return TabelaProfessores
                    .Where(x => x.AptoParaCursos.Contains(idCurso))
                    .Select(x => x.Nome).ToList();
        }

        public bool VerificarSeCursoExiste(string palavraChave)
        {
            return TabelaCursos.Any(x => x.Descricao.Contains(palavraChave));
        }

        public object SelecionarDadosDaTurma()
        {
            return TabelaTurmas.Join(
                TabelaProfessores, 
                turma => turma.IdProfessor, 
                prof => prof.Id, 
                (turma, prof) => new { Turma = turma, Prof = prof });
        }
    }
}
