using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace AbstractandInterface
{
    class invalidemail : Exception
    {
        public invalidemail(string msg)
            : base(msg)
        {

        }
    }
    public class EmailValidation
    {
        static void check(string sub)
        {
            string email = sub;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                Console.Write(email + " is valid email");
            else
            {
                throw new invalidemail("invalid email");
            }

        }

        static void Main(string[] args)
        {
            string s2 = Console.ReadLine();

            try
            {
                check(s2);
                string sub = s2.Substring(s2.Length - 10);

                Console.WriteLine(sub);

            }
            catch (invalidemail e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("code executed");
            }
            Console.ReadLine();
        }
    }
}
