using LoginUtente.Models;

var IlMioUtente = Utente.ControlUserAndLogin();
var SecondoUtente = Utente.ControlUserAndLogin();

var Operation = true;

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

}



