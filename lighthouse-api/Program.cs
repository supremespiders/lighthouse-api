// See https://aka.ms/new-console-template for more information

using System;
using lighthouse_api.Models;
using lighthouse_api.Services;
using Newtonsoft.Json;

namespace lighthouse_api
{
    public static class Program
    {
        public static void Main()
        {
            var c = new BnrClient();
            var d = new EbmClient();
            try
            {
                //var o=c.Work("GBP").GetAwaiter().GetResult();
                var o=d.Work("PVDRLUY5TV2H74TK").GetAwaiter().GetResult();
               // var o=d.Work("XCBGAHQWECT3IGND").GetAwaiter().GetResult();
                Console.WriteLine(JsonConvert.SerializeObject(o,Formatting.Indented));
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

