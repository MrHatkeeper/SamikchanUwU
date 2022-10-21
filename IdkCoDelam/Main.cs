namespace IdkCoDelam;

class Idk
{
    public static void Main(string[] args)
    {
        List<Athlete> athletes = new List<Athlete>();
        
        string[] input = File.ReadAllLines("athletes.csv");

        for (int i = 1; i < input.Length;i++)
        {
            string[] editedAthlet = input[i].Split(";");


            Console.WriteLine(long.Parse(editedAthlet[6]));

            Athlete holder = new Athlete(
                long.Parse(editedAthlet[0]),
                editedAthlet[1],
                editedAthlet[2],
                editedAthlet[3],
                editedAthlet[4],
                double.Parse(editedAthlet[5]),
                double.Parse(editedAthlet[6]),
                editedAthlet[7],
                int.Parse(editedAthlet[8]),
                int.Parse(editedAthlet[9]),
                int.Parse(editedAthlet[10]),
                editedAthlet[11]
            );
 
            athletes.Add(holder);
        }

        CountOfGenders(athletes);
        MaxMedals(athletes);
        CzechAthletes(athletes);
        WonMedal(athletes);
    }

    private static void WonMedal(List<Athlete> athletes)
    {
        foreach (var i in athletes)
        {
            if (i.Name == "Jiri Prskavec")
            {
                if (i.Bronze > 0)
                {
                    Console.WriteLine("Vyhrál bronz");
                }
                else if(i.Silver > 0)
                {
                    Console.WriteLine("Vyhrál stříbro");
                }
                else
                {
                    Console.WriteLine("vyhrál zlato");
                }
            }
        }
    }

    private static void CzechAthletes(List<Athlete> athletes)
    {
        List<Athlete> czechAthletes = new List<Athlete>();
        foreach (var i in athletes)
        {
            if (i.Medals() >= 1 && i.Nationality == "CZE") 
            {
                czechAthletes.Add(i);
            }
        }

        foreach (var j in czechAthletes)
        {
            Console.Write(j + " ");
        }
    }


    private static void CountOfGenders(List<Athlete> athletes)
    {
        int[] output = new int[2];

        int man = 0;
        int woman = 0;
        
        foreach (var i in athletes)
        {
            if (i.Sex == "male")
            {
                output[0]++;
            }
            else
            {
                output[1]++;
            }
        }

        Console.WriteLine("mužů = " + man + " žen = " + woman);
    }

    private static void MaxMedals(List<Athlete> athletes)
    {
        Athlete output = athletes[0];
        int maxMedals = athletes[0].Medals();
        foreach (var i in athletes)
        {
            if (i.Medals() > maxMedals)
            {
                maxMedals = i.Medals();
                output = i;
            }
        }
        Console.WriteLine("Nejvíce jich má = " + output.Name);
    }
}








    class Athlete
    {
        public long Id { get;}
        public string Name { get; }
        public string Nationality { get; }
        public string Sex { get; }
        private string DateOfBirth { get; }
        public double Height { get; }
        public double Weight { get; }
        public string Sport { get; }
        public int Gold { get; }
        public int Silver { get; }
        public int Bronze { get; }
        public string Info { get; }
        public Athlete(long id,string name, string nationality, string sex, string dateOfBirth, double height, double weight, string sport,
            int gold, int silver, int bronze, string info)
        {
            Id = id;
            Name = name;
            Nationality = nationality;
            Sex = sex;
            DateOfBirth = dateOfBirth;
            Height = height;
            Weight = weight;
            Sport = sport;
            Gold = gold;
            Silver = silver;
            Bronze = bronze;
            Info = info;
        }

        public int Medals()
        {
            return Gold + Silver + Bronze;
        }
    }