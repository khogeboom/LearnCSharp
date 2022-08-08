using System.Collections.Generic;

namespace InheritanceDemo
{
    public class Smartphone : Cellphone // Can only have one parent to inherit from
    {
        public List<string> Apps { get; set; }
        public void ConnectToInternet()
        {

        }

    }
}

