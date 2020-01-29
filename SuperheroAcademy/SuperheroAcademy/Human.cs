using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Human
    {

        public int physicalStability;
        public int mentalStability;
        public PowerLevel powerLevel;
        public float moralSpcetra;
        public string name;
        public string eduClass;
        public bool teacher;

    }
    public enum PowerLevel
    {
        E,
        D,
        C,
        B,
        A,
        S,
        SS,
    }

}
