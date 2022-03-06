using static System.Console;

public class Program
{
    static void Demo7()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Gui"},
            new Pessoa(){Nome = "Jose"},
            new Pessoa(){Nome = "Maria"},
            new Pessoa(){Nome = "Helen"},
            new Pessoa(){Nome = "Joao"},
        };
        WriteLine("Digite a pessoa que deseja localizar:");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        if(encontrado)
        {
            WriteLine("Pessoa localizada!");
        }
        else
        {
            WriteLine("Pessoa não localizada.");
        }
    }
    static void Demo6()
    {
        int[] numeros = new int[]{0,2,4,6,8};
        WriteLine("Digite o numero que deseja encontrar: ");
        var numero = int.Parse(ReadLine());
        var iEncontrado = EncontrarNumero(numeros, numero);
        if(iEncontrado >= 0)
        {
            WriteLine($"O numero digitado está na posição {iEncontrado}");
        }
        else
        {
            WriteLine("Numero não encontrado");
        }
    }
    static void Demo4()
    {
        int[] numeros1 = new int[]{0,2,4,6,8};
        TrocarImpar(numeros1);
        WriteLine($"Os impares {string.Join(",", numeros1)}");
    }
    
    static void Demo3()
    {
        StrucPessoa p1 = new StrucPessoa
       {

            Nome = "Gui",
            Idade = 27,
            Documento = "1234",
       
           
       };
        
            var p2 = p1;

            TrocarNome(p1, "Joao");

            WriteLine($@"
            Nome do p1 : {p1.Nome}
            Nome do p2 : {p2.Nome}");
       
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Gui";
        p1.Idade = 27;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();

        trocarNome(p1,"José");
        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}");
    }
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor da variável é: {a}");
    }

    static void trocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    static int Adicionar20(int x)
    {
    return x + 20;
    }

    static void TrocarNome(StrucPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    static void TrocarImpar(int[] numeros1)
    {
        for (int i = 0; i < numeros1.Length; i++)
        {
            numeros1[i] = numeros1[i] + 1;
        }
    }

    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
            return i;
        }
        return -1;
    }
    
    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if(item.Nome == pessoa.Nome)
            {
                return true;
            }
        }
        return false;
    }
    public static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Gui"},
            new Pessoa(){Nome = "Jose"},
            new Pessoa(){Nome = "Maria"},
            new Pessoa(){Nome = "Helen"},
            new Pessoa(){Nome = "Joao"},
        };
        WriteLine("Digite a pessoa que deseja localizar:");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        if(encontrado)
        {
            WriteLine("Pessoa localizada!");
        }
        else
        {
            WriteLine("Pessoa não localizada.");
        }
    }
}

