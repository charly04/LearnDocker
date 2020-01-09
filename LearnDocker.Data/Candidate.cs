using System;

namespace LearnDocker.Data
{
    public class Candidate
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public Candidate()
        {
            Name = "Carlos";
            Surname = "Clares Cucala";
            BirthDate = DateTime.UtcNow;
            Address = "Poeta Iranzo Simon 5, pta 11";
        }
    }
}
