using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulemandensVærksted
{
    public class JuleNisse : JuleAnsat
    {
        public string _name;
        public string _arbejdsområde;
        
        public int _age;

        public JuleNisse(string name, string arbejdsområde, int age)
        {
            _name = name;
            _arbejdsområde = arbejdsområde;
            _age = age;
        }
        
        public override void CheckAge(int age)
        {
            if (age <= 199)
                throw new ArgumentException("Julenisser er altid mindst 200 år gamle");
        }
    }
}
