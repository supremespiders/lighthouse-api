using System;

namespace lighthouse_api.Models
{
    public class MyException:Exception
    {
        public MyException(string message):base(message)
        {
                
        }
    }
}