namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shark shark = new Shark("White shark", "", 1.5);
            GoldFish fish = new GoldFish("Gold fish", "", 0.1);
            Oceanarium oceanarium = new Oceanarium("Nemo");
            oceanarium.AddCreature(shark);
            oceanarium.AddCreature(fish);
            foreach (Creature creature in oceanarium)
            {
                creature.Description = creature.Name;
            }
            Console.WriteLine(oceanarium);
        }
    }
}
