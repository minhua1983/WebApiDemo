using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace WebApiDemo.OWINDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StartOptions startOptions = new StartOptions();
            startOptions.Urls.Add("http://localhost:11002");

            WebApp.Start<Startup>(startOptions);
            Console.WriteLine("程序已启动,按任意键退出");
            Console.ReadLine();
        }
    }
}
