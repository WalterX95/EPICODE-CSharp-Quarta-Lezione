using LoginUtente.Models;

var Operation = true;
var ChooseOp = "";

while(Operation)
{

    Console.WriteLine("==================== LOGIN MENU =======================");
    Console.WriteLine("Scegli Operazione da Compiere");
    Console.WriteLine("1) Login");
    Console.WriteLine("2) Logout");
    Console.WriteLine("3) Verifica ora e data di Login");
    Console.WriteLine("4) Lista degli accessi");
    Console.WriteLine("5) Esci");
    Console.WriteLine("============================== =======================");
    ChooseOp = Console.ReadLine();
    switch (ChooseOp) {
        case "1":
            Console.WriteLine("Inserisci Username");
            string? username = Console.ReadLine();
            Console.WriteLine("Inserisci Password");
            string? password = Console.ReadLine();
            Utente.ControlUserAndLogin(username,password);
            break;
        case "2":
            Console.WriteLine("LogOut Effettuato !");
            break;
        case "3":
            Console.WriteLine("Accesso al File Di Log Dati");
            Utente.ListaAccessi();
            break;
        case "4":
            Console.WriteLine("Accesso al File Di Log Dati");
            Utente.ListaAccessi();
            break;
        default:
            Operation = false;
            break;
    }
}



