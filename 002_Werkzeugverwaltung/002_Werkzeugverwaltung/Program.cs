using System.Linq;

namespace _002_Werkzeugverwaltung
{


    class Tool // "Bauplan" im Speicher
    {
        //  Member-Variablen / (Eigenschaften)
        private string description;

        private int number;

        private bool inStore = true; 

        // Methoden (Unterprogramme)
        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public void SetInStoreFalse()
        {
            inStore = false;
        }

        public void SetInStoreTrue()
        {
            inStore = true;
        }

        public int GetNumber()
        {
            return number;
        }


        public void Print ()
        {
            Console.WriteLine($"{description} {number}, im Lager: {inStore}");

        }

        public Tool(string description, int number)  // Konstruktor (heißt immer wie die Klasse)
        {
            this.description = description;
            this.number = number;
        
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List <Tool> tools = new List <Tool> ();
            tools.Add (new Tool("Wasserwaage", 19828));
            tools.Add(new Tool("Schraubendreher", 88392));
            tools.Add(new Tool("Schraubendreher", 649389));



            

            int i = 3;

            bool stayAlive = true;
            do
            {
                Console.WriteLine("Werkzeuge auflisten [l]");
                Console.WriteLine("Werkzeug hinzufügenn [h]");
                Console.WriteLine("Werkzeug ausleihen [a]");
                Console.WriteLine("Werkzeug retounieren [r]");
                Console.WriteLine("Beenden [b]");

                char eingabe = Console.ReadKey().KeyChar;
                switch (eingabe)
                { 
                    case 'l':
                        foreach (Tool tool in tools)
                        {
                            tool.Print();
                        }
                        break;


                    case 'h':
                        Console.WriteLine("Name vom Werkzeug eingeben");
                        string toolDescription = Console.ReadLine();

                        Console.WriteLine("Nummer vom Werkzeug eingeben");
                        int toolNumber = int.Parse(Console.ReadLine());

                        tools.Add(new Tool(toolDescription, toolNumber));

                        tools[i].SetDescription(toolDescription);
                        tools[i].SetNumber(toolNumber);
                        i++;
                        Console.WriteLine("Werkzeug wurde hinzugefügt");
                        break;


                    case 'a':
                        Console.WriteLine("Nummer vom Werkzeug eingeben");
                        int ausleihenWerkzeug = int.Parse (Console.ReadLine());
                        

                        foreach (Tool tool in tools)
                        {
                            if  (ausleihenWerkzeug == tool.GetNumber())
                            {
                                tool.SetInStoreFalse();


                                Console.WriteLine("Werkzeug wurde ausgeliehen");
                            }

                        }
                                             
                        break;


                    case 'r':
                        Console.WriteLine("Nummer vom Werkzeug eingeben");
                        int retourWerkzeug = int.Parse(Console.ReadLine());


                        foreach (Tool tool in tools)
                        {
                            if (retourWerkzeug == tool.GetNumber())
                            {
                                tool.SetInStoreTrue();
                                Console.WriteLine("Werkzeug wurde retouniert");
                            }
                        }
                        break;

                    case 'b':
                        stayAlive = false;
                        break;

                    default:
                        Console.WriteLine("Falsche Eingabe");
                        break;
                    

                }
            } while (stayAlive);

            
            
            
        }
    }
}
