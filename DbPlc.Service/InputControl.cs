using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DbPlc.Service
{
    public class InputControl
    {
        public bool ControlLogin(string text)
        {
            string[] dangerousWords = { "'", "@" };
            foreach (var word in dangerousWords)
            {
                var result = Regex.Replace(text, word, "x");
                if (result != text)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
