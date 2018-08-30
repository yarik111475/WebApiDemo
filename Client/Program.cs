using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using Client.Models;

namespace Client {
    class Program {
        static void Main(string[] args) {
            Test();
            Console.ReadLine();
        }
        static async void Test() {
            using (HttpClient client = new HttpClient()) {
                client.BaseAddress = new Uri("http://localhost:50282");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;
                response = await client.GetAsync("Users/getAll");
                if (response.IsSuccessStatusCode) {
                    Console.WriteLine("List of users:");
                    IEnumerable<User> users = await response.Content.ReadAsAsync<IEnumerable<User>>();
                    foreach (User user in users) {
                        Console.WriteLine(user.ToString());
                    }
                }
                Console.WriteLine();

                response = await client.GetAsync("Users/getById/2");
                if (response.IsSuccessStatusCode) {
                    User user = await response.Content.ReadAsAsync<User>();
                    Console.WriteLine("User by id:");
                    Console.WriteLine(user);
                    
                }
                Console.WriteLine();
            };
            Console.ReadLine();
        }
    }
}
