Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.Yellow);
Clientes clientes = new Clientes(tela);

string op;

List<string> opcoes = new List<string>();

opcoes.Add("1 - cadastro de clientes");
opcoes.Add("2 - cadastro de contas  ");
opcoes.Add("3 - registrar movimento ");
opcoes.Add("4 - emitir extrato      ");
opcoes.Add("0 - sair do sistema     ");

while(true){

    tela.montarMoldura(0,0,79,24);
    op = tela.mostrarMenu(opcoes, 15, 8);

    if (op=="0") break;

    if (op=="1") clientes.executarCRUD();

}

Console.Clear();

/*tela.montarMoldura(0,0,80,24);
tela.montarMoldura(3,1,20,7);
tela.montarMoldura(15,10,50,20);*/