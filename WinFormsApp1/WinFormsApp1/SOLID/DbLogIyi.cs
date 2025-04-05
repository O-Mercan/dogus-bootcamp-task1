using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class DbLogIyi : ILog
    {
        public string log(string message)
        {
            return $"Veritabanına ödeme kaydı: {message}";
        }
    }
}
