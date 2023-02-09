using Heranca3.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        Matricula Matricula = new Arquitetura
        (
            nome:"Leonardo Dias Correa"
            ,dataNascimento: "02/09/2004"
            ,bolsaEstudos: 100
        );
        Matricula.CalcularGraduacao();
    }
}