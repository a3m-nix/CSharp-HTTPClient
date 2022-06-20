using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace ConsoleAppHTTPClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application.Run(new Form1());
            //Console.Write("masukkan id data: ");
            //string id = Console.ReadLine();
            //User user = UserProvider.GetDataById(id);
            //Console.WriteLine("ID:" + user.id);
            //Console.WriteLine("Nama:" + user.nama);
            //Console.WriteLine("Alamat:" + user.alamat);
            //User user = new User()
            //{
            //    nama="budianto",
            //    alamat="jalan manggis baru"
            //};
            //HttpResponseMessage request = UserProvider.CreateData(user);
            //string result = request.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(result);
            //Console.ReadKey();
            Application.Run(new Form1());

        }
    }
}
