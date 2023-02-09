namespace Heranca3.Classes
{
    public class Arquitetura : Matricula
    {
        public Arquitetura
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
            Console.WriteLine($"O Aluno: {this.Nome} Pagara R$ {400 - (450 / 100) * this.BolsaEstudos}");
        }
    }
}