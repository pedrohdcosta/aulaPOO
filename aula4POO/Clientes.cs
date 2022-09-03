class Clientes{

    Tela tela;
    List<ClienteData> registros = new List<ClienteData>();

    public Clientes(Tela t){

        this.tela = t;

        this.registros.Add(new ClienteData("1","xunda","x@b.com","123"));
        this.registros.Add(new ClienteData("2","babalu","b@b.com","456"));
    }

    public void executarCRUD(){

        string cod, nom, eml, tel;
        int cI, lI;
        bool found = false;

        cI = 10;
        lI = 8;
        this.montarTela(10,8);
        cI += 11;

        Console.SetCursorPosition(cI, lI+2);
        cod = Console.ReadLine();

        for(int x = 0; x < this.registros.Count; x++){

            if(this.registros[x].codigo == cod){

                found = true;
                break;
            }
        }
        Console.SetCursorPosition(cI, lI+3);
        if(found) Console.Write("Codigo ja Cadastrado!");
        else Console.Write("Codigo ainda nao usado");
        Console.ReadKey();
    }

    public void montarTela(int cI, int lI){

        int cF, lF;
        cF = cI + 40 + 1;
        lF = lI + 6 + 1;

        this.tela.montarMoldura(cI, lI, cF, lF);
        
        Console.SetCursorPosition(cI+1,lI+1);
        Console.Write("Cadastro de Clientes");

        Console.SetCursorPosition(cI+1, lI+2);
        Console.Write("codigo   :");

        Console.SetCursorPosition(cI+1, lI+3);
        Console.Write("nome     :");
        
        Console.SetCursorPosition(cI+1, lI+4);
        Console.Write("Email    :");
        
        Console.SetCursorPosition(cI+1, lI+5);
        Console.Write("Telefone :");

        Console.SetCursorPosition(cI+1,lI+6);
        Console.Write("Confirma (s/n):");

    }
}