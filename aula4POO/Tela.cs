class Tela {
    //atributos
    private ConsoleColor corFundo;
    private ConsoleColor corTexto;


    //metodos
    public Tela(ConsoleColor Fundo, ConsoleColor Texto) {

        this.corFundo = Fundo;
        this.corTexto = Texto;
        this.prepararTela();

    }

    public Tela(){

        this.corFundo = ConsoleColor.Black;
        this.corTexto = ConsoleColor.White;
        this.prepararTela();
        
    }

    public void prepararTela(){

        Console.BackgroundColor = this.corFundo;
        Console.ForegroundColor = this.corTexto;
        Console.Clear();

    }


    public void montarMoldura(int cI, int lI, int cF, int lF){

        int coluna, linha;

        this.limparArea(cI, cF, lI, lF);
        
        for(coluna=cI; coluna<=cF; coluna++){

            Console.SetCursorPosition(coluna, lI);
            Console.Write("-");

            Console.SetCursorPosition(coluna, lF);
            Console.Write("-");

        }

        for(linha=lI; linha<=lF; linha++){

            Console.SetCursorPosition(cI, linha);
            Console.Write("|");

            Console.SetCursorPosition(cF, linha);
            Console.Write("|");

        }

        Console.SetCursorPosition(cI, lI); Console.Write("+");
        Console.SetCursorPosition(cI, lF); Console.Write("+");
        Console.SetCursorPosition(cF, lI); Console.Write("+");
        Console.SetCursorPosition(cF, lF); Console.Write("+");

    }

    public void limparArea(int cI, int cF, int lI, int lF){

        for(int x = cI; x <= cF; x++){

            for(int y = lI; y <= lF; y++){

                Console.SetCursorPosition(x,y);
                Console.Write(" ");

            }

        }

    }

    public string mostrarMenu(List<string> itens, int cI, int lI){

        string op;
        int x, cF, lF;

        cF = cI + itens[0].Count() + 1;
        lF = lI + itens.Count() + 2;

        this.montarMoldura(cI,lI,cF,lF);
        for(x = 0; x < itens.Count(); x++){

            Console.SetCursorPosition(cI+1, lI+1+x);
            Console.Write(itens[x]);

        }

        Console.SetCursorPosition(cI+1, lI+1+x);
        Console.Write("opcao : ");
        op = Console.ReadLine();
        return op;

    }

}