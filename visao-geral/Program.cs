// See https://aka.ms/new-console-template for more information


//NAMESPACES
/*
    - Usado para prover um nível de separação de código fonte
    - Pose se Considerad como um "container"
    - Pode conter os seguintes membros:
        - Classes
        - Interfaces
        - Estruturas
        - Delegates
 */

using SistemaBancario;

namespace ProgramaPrincipal { 
    public class ClasseUm
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ClasseDois
    {
        public int Id { get; set; }
        public int Nome { get; set;}
    }

  

    public class Instancia_objeto
    {
        public static void Main()
        {
            var objetoGerente = new Gerente();
            
        }
    }


}




//CLASSES
/*
    A classe é uma abstração do mundo real em programação. 
    Ela vai modelar no sistema quais atores
    ou processos existirão e como eles se comportam. Esses atores
    possuem características comuns tais como nome, idade e certamente um número de CPF, dessa forma, a classe também precisará
    refletir essas propriedades.
 */



namespace SistemaBancario { 
    public class Gerente
    {
        public string Nome { get; set; }
        public int Idadae { get; set; }
        public int Cpf { get; set; }
    public void Aprovar_horas_funcionario(int cpf) {
            //logica de implementação
        }

    }


    public class variaveis { 
        public void main()
        {
            int cpf = 323123123;
            string nome = "Caio Martins";
            decimal salario = 100;
            bool funcionarioAtivo = true;
        }
    }

}

