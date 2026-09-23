namespace _002_Werkzeugverwaltung
{


    class Tool // "Bauplan" im Speicher
    {
        //  Member-Variablen / (Eigenschaften)
        private string description;

        private int number;

        private bool inStore;

        // Methoden (Unterprogramme)
        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public void SetInStore(bool inStore)
        {
            this.inStore = inStore;
        }

        public void Print ()
        {
            Console.WriteLine($"{description} {number}, im Lager: {inStore}");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Tool s1 = new Tool();
            s1.SetDescription("Wasserwaage");
            s1.SetNumber(19828);
            s1.Print();


            Tool s2 = new Tool();
            s2.SetDescription ("Schraubendreher");
            s2.SetNumber(88392);
            s2.Print();

            

            Tool s3 = new Tool();
            s3.SetDescription("Schraubendreher");
            s3.SetNumber(649389);
            s3.Print();


            Console.ReadKey();

            /*


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

                        break;


                    case 'h':

                        break;


                    case 'a':

                        break;


                    case 'r':

                        break;


                    case 'b':
                        stayAlive = false;
                        break;

                    

                }
            } while (stayAlive);

            
            */
            
        }
    }
}
