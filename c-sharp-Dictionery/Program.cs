using c_sharp_Dictionery;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1=new Person(1222,"omran",27);
        Person person2 = new Person(1223, "ali", 22);
        Person person3 = new Person(1225, "salim", 30);

        Dictionary<long,Person> personMap = new Dictionary<long,Person>();

        personMap.Add(person1.id, person1);
        personMap.Add(person2.id, person2);
        personMap.Add(person3.id, person3);

       Console.WriteLine(personMap[person1.id]);

        person1.age = 50;

        Person? result=null;
        if(personMap.TryGetValue(person1.id, out result))
        {
            Console.WriteLine(result);
        }

        Console.WriteLine("Enter the ID number to retrieve person information:");
        string input = Console.ReadLine();
        long id;

        if (long.TryParse(input, out id))
        {
            GetPersonInfo(id, personMap);
        }
        else
        {
            Console.WriteLine("Invalid ID number entered.");
        }

        Console.ReadLine();

    }
    static void GetPersonInfo(long id, Dictionary<long, Person> personMap)
    {
        if (personMap.ContainsKey(id))
        {
            Person person = personMap[id];
            Console.WriteLine($"ID: {person.id}, Name: {person.name}, Age: {person.age}");
        }
        else
        {
            Console.WriteLine("Person with the specified ID does not exist.");
        }
    }


}
