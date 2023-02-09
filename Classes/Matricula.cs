namespace Heranca3.Classes
{
    public abstract class Matricula
    {
        public Matricula(string nome, string dataNascimento, int bolsaEstudos)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.BolsaEstudos = bolsaEstudos;
        }
      public string Nome { get ;protected set ;}
      public string DataNascimento {get ;protected set ;}
      public int BolsaEstudos {get ;protected set ;}

      public abstract void CalcularGraduacao();

    
    }
}