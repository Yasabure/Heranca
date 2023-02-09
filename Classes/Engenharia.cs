namespace Heranca3.Classes
{
    public class Engenharia : Matricula
    {
        public Engenharia
        (
            string nome
            ,string dataNascimento
            ,int bolsaEstudos
        )
        :
        base
        (
            nome, dataNascimento, bolsaEstudos
        )
        {
            
        }
        public override void CalcularGraduacao()
        {
            Console.WriteLine($"O Aluno: {this.Nome} Pagara R$ {800 - (850 / 100) * this.BolsaEstudos}");
        }
    }
}