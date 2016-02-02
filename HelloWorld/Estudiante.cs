using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Estudiante
    {

        // Field
        public string name;

        // Constructor thattakesno arguments.
        public Estudiante()
        {
            name = "unknown";
        }

        // Constructor thattakesoneargument.
        public Estudiante(string nm)
        {
            name = nm;
        }
        // Method
        public void SetName(string newName)
        {
            name = newName;
        }
    }
}
