using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;

namespace LoginUtente.Models
{
    internal static class Utente
    {
        private static string Username {get; set;} = string.Empty;
        private static string Password { get; set; } = string.Empty;
        private static bool IsLogged { get; set;} = false;
        private static DateTime Ora { get; set; }
        private static DateOnly DataLogin { get; set; }
        private static string[] DataBaseUtenti { get; set; } = { "Walter", "Password" };

        private static string[] DataConnessione { get; set;} = { };
        public static string ControlUserAndLogin(string myUser, string myPassword) {  
        
                if(myUser != DataBaseUtenti[0] || myPassword != DataBaseUtenti[1])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Username Non Corretto, Riprova per favore");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {

                    Console.WriteLine("Username e Password Corretto");
                    IsLogged = true;
                    Ora = DateTime.Now;
                    DataLogin = new DateOnly();
                    DataConnessione.Append(Ora.ToString());
                    DataConnessione.Append(DataLogin.ToString()); 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Accesso Effettuato");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (IsLogged)
                    {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt");
                            File.WriteAllText(path, DataLogin.ToString()+"\n"+ Ora.ToString());
                           
                    }
                }
            return Username; 
        } 

        public static void ListaAccessi()
        {
            foreach (var accessi in DataConnessione)
            {
                Console.WriteLine($"Ora e Data : {accessi.ToString()}");
            }
        }

        public static void StampaOraEData() {
            Console.WriteLine("Ora : " + Ora.ToString());
            Console.WriteLine("Data attuale : " + DataLogin.ToString());
        }
    }
}
