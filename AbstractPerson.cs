using System;

namespace LMS1
{

    public abstract class AbstractPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void DisplayInfo();
    }

}

