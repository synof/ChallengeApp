

namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string imie, string nazwisko, string wiek)

        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }
        public string imie { get; private set; }
        public string nazwisko { get; private set; }

        public string wiek { get; private set; }

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
