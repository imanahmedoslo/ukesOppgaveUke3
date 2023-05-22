using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukesOppgaveUke3
{
    public class Animals
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public  List <string> FavoriteFood { get; private set; }
        public string MostFavorittFood { get; private set; }

        public Animals(string name, int age )
        {
            Name = name;
            Age = age;
            FavoriteFood = new List<string>();
        }
        public Animals(string name, int age, string mostFavorittFood)
        {
            Name = name;
            Age = age;
            MostFavorittFood = mostFavorittFood;
            FavoriteFood = new List<string>();
            FavoriteFood.Add(mostFavorittFood);
            
        }
       
        public void AddFood() {
            Console.WriteLine($" choose a food to add to {this.Name} list of available foods.");
         var food=Console.ReadLine();
            this.FavoriteFood.Add(food);
        }
        public void GiveFood() {
            Console.WriteLine($"choose what to give{this.Name} by typing the number of the food.");
        for  (int i = 0; i < FavoriteFood.Count; i++)
            {
                Console.WriteLine($" number {i}: {FavoriteFood[i]}");
            }
            var Answer = int.Parse(Console.ReadLine());
            Console.WriteLine($"{this.Name} fikk {FavoriteFood[Answer]}, tusen takk!");

        }
        public void GiveFood(Animals friendAnimal)
        {
            Console.WriteLine($"choose what to give{this.Name} by typing the number of the food.");
            for (int i = 0; i < FavoriteFood.Count; i++)
            {
                Console.WriteLine($" number {i}: {FavoriteFood[i]}");
            }
            var Answer = int.Parse(Console.ReadLine());
            if (FavoriteFood[Answer]== friendAnimal.MostFavorittFood)
            {
                Console.WriteLine($"{this.Name} fikk {FavoriteFood[Answer]}, det er {friendAnimal.Name} sin favorittmat, yippi, nå kan de bytte!!");

            } else
            {
                Console.WriteLine($"{this.Name} fikk {FavoriteFood[Answer]}, tusen takk!");
            }
            

        }
    }
}
