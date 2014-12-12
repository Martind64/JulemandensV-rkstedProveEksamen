using System;

namespace JulemandensVærksted
{
    public class Julemand : JuleAnsat
    {
        private static Julemand instance;

        private Julemand() {}

        public static Julemand Instance(string name, int age)
        {
            _name = name;
            _age = age;

            if (instance == null)
             {
                 instance = new Julemand();
                instance.CheckAge(age);
             }
            
            return instance;
            
           
        }

        private static string _name;
        private static int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                CheckAge(value);
                _age = value;
            }
        }



        

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", _name, _age);
        }

        public override void CheckAge(int age)
        {
            if (age <= 450)
                throw new ArgumentException("Julemanden er altid over 450 år gammel");
        }
    }
}
