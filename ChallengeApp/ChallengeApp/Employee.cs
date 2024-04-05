

namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string Name, string SurName, string Age)

        {
            this.Name = Name;
            this.SurName = SurName;
            this.Age = Age;
        }
        public string Name { get; private set; }
        public string SurName { get; private set; }

        public string Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
