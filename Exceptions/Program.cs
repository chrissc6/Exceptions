using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            try
            {
                var answer = GetErrorMessage(str);
                ArrayError(5);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message + " Error 322, Null, Str cannot be null");
                str = string.Empty;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + " Error 321, ArrayIndex, No element in index");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + " Error 999, General exception error");
            }

        }


        static string ArrayError(int idx)
        {
            string[] messages =
            {
                "message1",
                "message2",
                "message3"
            };
            return messages[idx];
        }

        static string GetErrorMessage(string str)
        {
            return str.ToLower();
        }
    }
}
