namespace clubMemberIndexer
{
   class Program
    {
        public const int Size = 15; //global variable
        class Clubmembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            //constructor
            public Clubmembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }
            //indexer get and set methods
            public string this[int index] 
            { 
                get
                {
                    string tmp;
                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }
                    return tmp;
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Clubmembers club1 = new Clubmembers();
            bool end = false;
            while (!end) 
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which Club Member do you want to enter (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1-{Size}");
                }
                Console.WriteLine($"Enter the name of the Club Member");
                club1[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue, q to stop");
                string stop = Console.ReadLine();
                if (stop =="q")
                    end= true;
            }
            Console.WriteLine("What is the Club Type?");
            club1.ClubType = Console.ReadLine();
            Console.WriteLine("Where is the Club Location?");
            club1.ClubLocation = Console.ReadLine();
            Console.WriteLine("When is the Club Meeting Date?");
            club1.MeetingDate = Console.ReadLine();

            Console.WriteLine($"Here is the information on the Club");
            Console.WriteLine($"Club Members");
            for (int i = 0; i < Size; i++)
            {
                if (club1[i] != string.Empty)
                    Console.WriteLine(club1[i]);
            }
            Console.WriteLine($"Club Type: {club1.ClubType}");
            Console.WriteLine($"Club Location: {club1.ClubLocation}");
            Console.WriteLine($"Club Meeting Date: {club1.MeetingDate}");
        }
    }
}