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
            Console.WriteLine($"Hvilken hobby vil du {person1.Name} skal gjøre?");
            string RemyHobby = Console.ReadLine();
            if (RemyHobby == "Trommer") 
            {
                Console.WriteLine("Remy slår løs på trommene!");
            }
            else if(RemyHobby == "Fiske")
            {
                Console.WriteLine("Remy står og fisker i ro og mak");
            }
            else if(RemyHobby == "Motorsykkel")
            {
                Console.WriteLine("Remy freser runt på to hjul");
            }
            else
            {
                Console.WriteLine($"Beklager {RemyHobby} er ikke en av Remy’s hobbyer. Han har bestemt seg for å ignorere deg.");
            }


            Console.WriteLine($"La oss møte {person2.Name}!");
            Console.WriteLine($"Dette er {person2.Name}! \n{person2.Pronoun} er {person2.Age} år gammel, og kommer fra {person2.City}.\n{person2.Name}’s hobbyer er: \n{person2.Hobby1}, \n{person2.Hobby2}, \n{person2.Hobby3}");
            Console.WriteLine($"Hvilken hobby vil du {person2.Name} skal gjøre?");
            string LeneHobby = Console.ReadLine();
            if (LeneHobby == person2.Hobby1)
            {
                Console.WriteLine("hihi");
            }




            Console.WriteLine("test4rd");
        }
    }
}
