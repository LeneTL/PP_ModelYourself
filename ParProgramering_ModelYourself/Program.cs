namespace ParProgramering_ModelYourself
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personer person1 = new Personer { Name = "Remy", Pronoun = "Han", Age = 36, City = "Rennesøy", Hobby1="Trommer", Hobby2="Fiske", Hobby3="Motorsykkel"};
            Personer person2 = new Personer { Name = "Lene", Pronoun = "Hu", Age = 27, City = "Tønsberg", Hobby1 = "Gaming", Hobby2 = "Baking", Hobby3="Koding" };
            Console.WriteLine("Hei!");
            Console.WriteLine($"Dette er {person1.Name}! \n{person1.Pronoun} er {person1.Age} år gammel, og kommer fra {person1.City}.\n{person1.Name}’s hobbyer er: \n{person1.Hobby1}, \n{person1.Hobby2}, \n{person1.Hobby3}");
            Console.WriteLine();

            Console.WriteLine($"Hvilken hobby vil du {person1.Name} skal gjøre? ({person1.Hobby1}/{person1.Hobby2}/{person1.Hobby3}/Random)");
            string RemyHobby = Console.ReadLine();
            if (RemyHobby == person1.Hobby1)
            {
                Console.WriteLine("Remy slår løs på trommene!");
            }
            else if (RemyHobby == person1.Hobby2)
            {
                Console.WriteLine("Remy står og fisker i ro og mak");
            }
            else if (RemyHobby == person1.Hobby3)
            {
                Console.WriteLine("Remy freser rundt på to hjul");
            }
            else if (RemyHobby == "Random")
            {
                Random rand = new Random();
                int randomHobby = rand.Next(0,3);
                if (randomHobby == 0)
                {
                    Console.WriteLine("Remy slår løs på trommene!");
                }
                else if (randomHobby == 1)
                {
                    Console.WriteLine("Remy står og fisker i ro og mak");
                }
                else if (randomHobby == 2)
                {
                    Console.WriteLine("Remy freser rundt på to hjul");
                }
            }
            else
            {
                Console.WriteLine($"Beklager {RemyHobby} er ikke en av Remy’s hobbyer. Han har bestemt seg for å ignorere deg.");
            }
            Console.WriteLine();

            Console.WriteLine($"La oss møte {person2.Name}!");
            Console.WriteLine();

            Console.WriteLine($"Dette er {person2.Name}! \n{person2.Pronoun} er {person2.Age} år gammel, og kommer fra {person2.City}.\n{person2.Name}’s hobbyer er: \n{person2.Hobby1}, \n{person2.Hobby2}, \n{person2.Hobby3}");
            Console.WriteLine();

            Console.WriteLine($"Hvilken hobby vil du {person2.Name} skal gjøre? ({person2.Hobby1}/{person2.Hobby2}/{person2.Hobby3}/Random)");
            string LeneHobby = Console.ReadLine();
            if (LeneHobby == person2.Hobby1)
            {
                Console.WriteLine("Lene lager seg et lite hus i Minecraft!");
            }
            else if (LeneHobby == person2.Hobby2)
            {
                Console.WriteLine("Lene står og lager sin signaturkake!");
            }
            else if (LeneHobby == person2.Hobby3)
            {
                Console.WriteLine("Lene slår hodet i veggen mens hu lærer seg C#...");
            }
            else if (LeneHobby == "Random")
            {
                Random rand = new Random();
                int randomHobby = rand.Next(0, 3);
                if (randomHobby == 0)
                {
                    Console.WriteLine("Lene lager seg et lite hus i Minecraft!")
                }
                else if (randomHobby == 1)
                {
                    Console.WriteLine("Lene står og lager sin signaturkake!")
                }
                else if (randomHobby == 2)
                {
                    Console.WriteLine("Lene slår hodet i veggen mens hu lærer seg C#...")
                }
            }
            else
            {
                Console.WriteLine($"Beklager {LeneHobby} er ikke en av Lene's hobbyer. Hun tar seg en kaffe istedenfor");
            }



            Console.WriteLine();
            Console.WriteLine("Ha en fin dag videre!");
        }
    }
}
