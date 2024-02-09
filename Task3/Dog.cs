namespace Task3;

public class Dog
{
    string _name;
    string _breed;
    int _age;

    public Dog(string name, string breed, int age)
    {
        _name = name;
        _breed = breed;
        _age = age;
    }

    public void GetDogInfo()
    {
        System.Console.WriteLine($"Dog name: {_name}\nDog breed: {_breed} \nDog Age: {_age}");
    }

}
