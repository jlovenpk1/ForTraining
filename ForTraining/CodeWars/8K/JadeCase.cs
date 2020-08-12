using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.CodeWars
{
    class JadeCase
    {
        public void JadenCase()
        {
            string test = "How can mirrors be real if our eyes aren't real";
            StringBuilder st = new StringBuilder();
            var x = test.Split(new char[] { ' ' }).ToArray();
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            foreach(var word in x)
            {
                st.Append(ti.ToTitleCase(word+" "));
                Console.WriteLine("{0} >>>> {1}", word, ti.ToTitleCase(word));
            }
            Console.WriteLine(st.ToString().TrimEnd(new char[] {' '}));
        }
    }


}
