using System;

namespace LearnDocker.Data.Entities
{
    public class Candidate
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public Candidate()
        {
        }

        public Candidate(bool mock)
        {
            if (mock)
            {
                ID = "1";
                Name = "Charly";
                Surname = "Zero Four";
                BirthDate = DateTime.UtcNow;
                Address = "Behaind a tree";
            }
        }
    }
}
