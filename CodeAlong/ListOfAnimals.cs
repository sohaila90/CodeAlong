namespace CodeAlong;

public class ListOfAnimals
{
    private List<Animal> _animalList;

    public ListOfAnimals()
    {
        _animalList = new List<Animal>
        {
            new Animal("Dog", "Woof Ruff"),
            new Animal("Cat", "Miaow"),
            new Animal("Cow", "Moo"),
            new Animal("Fox", "Lalalalalala"),
            new Animal("Swan", "Schwa")
        };
    }
    public void Run()
    {
        Console.WriteLine("Here you can check what an animal sounds like: \nPlease choose an Animal from the list");

        for (int i = 0; i < _animalList.Count; i++)
        {
                Console.WriteLine($"{i}: {_animalList[i].Name}");

            
        }

        while (true)
        { 
            int chooseAnAnimal = Convert.ToInt32((Console.ReadLine()));
           if (chooseAnAnimal < _animalList.Count)
           {
               
               Console.WriteLine($"You choose: {_animalList[chooseAnAnimal].Name}");
               Console.WriteLine($"The {_animalList[chooseAnAnimal].Name} says: {_animalList[chooseAnAnimal].Sound}");
           }
           else
           {
               Console.WriteLine("Bye, bye");
               break;
           }
        }
        
        
        
        
        
        
       
    }
}


//Lag en liste over forskjellige dyr (for eksempel "hund", "katt", "ku", osv.), 
// og la programmet spørre brukeren om å velge et dyr fra listen. 
// Deretter skal programmet skrive ut en passende lyd for det valgte dyret.
