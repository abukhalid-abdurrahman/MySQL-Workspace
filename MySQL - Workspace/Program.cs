/*
 *
 *  Web Host: ru.000webhost.com
 *  Host Name: sendysocialclub.000webhostapp.com
 *  Project Name: SendySocialClub
 *  Password: m!jg0n@j0n2802
 *  DataBase Name: id13668343_sendysocialclub
 *  DataBase Username: id13668343_faridun
 *  DataBase Password: |Zl^Q8!P{R*ANxyU
 * 
 */
using System;
using System.Threading;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace MySQL___Workspace
{
    class Program
    {
        private static string endPoint = "https://sendysocialclub.000webhostapp.com/manager.php";

        private static void InsertRecord(string name, string surname)
        {
            Thread requestThread = new Thread(() =>
            {
                WebClient webClient = new WebClient();

                NameValueCollection formData = new NameValueCollection();
                formData["name"] = name;
                formData["surname"] = surname;

                byte[] responseData = webClient.UploadValues(endPoint, "POST", formData);
                string responseFromServer = Encoding.UTF8.GetString(responseData);

                Console.WriteLine("Response From Server: " + responseFromServer);

                webClient.Dispose();
            });
            requestThread.Start();
            requestThread.Join();
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Input Name: ");
                string name = Console.ReadLine();
                Console.Write("Input Surname: ");
                string surname = Console.ReadLine();
                InsertRecord(name, surname);
            }
        }
    }
}
