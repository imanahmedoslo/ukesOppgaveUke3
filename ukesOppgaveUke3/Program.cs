// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ukesOppgaveUke3;

var Cat= new Animals("cat", 3, "mice");
var Dog= new Animals("dog", 5);
var Giraffe= new Animals("giraffe", 7, "banana");
var Elephant= new Animals("elephant", 33, "poop");
List <Animals> ZooResidents= new List<Animals>();
ZooResidents.Add(Cat);
ZooResidents.Add(Dog);
ZooResidents.Add(Giraffe);
ZooResidents.Add(Elephant);
PutFoodInFridge();
feed();

void PutFoodInFridge()
{
    for (int i = 0; i < ZooResidents.Count; i++)
    {
        ZooResidents[i].AddFood();
    }
    
}
void feed()
{
    
    for (int i = 0; i < ZooResidents.Count; i++)
    {
        
        Console.WriteLine(i + 1);
        if (ZooResidents[i - 1].MostFavorittFood != null)
        {
            ZooResidents[i].GiveFood(ZooResidents[i-1]);
        }
        else ZooResidents[i].GiveFood();
       
    }
}