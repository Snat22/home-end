using System.Runtime.InteropServices;

namespace Task5;

public class Counter
{
    int _value;

    public Counter(int value)
    {
        _value = value;
    }

    public int Decrement()
    {
        if(_value <= 0)
        {
            return _value;
        }else{
            _value--;
        }
        return _value;
    }

    // string command = Convert.ToString(System.Console.ReadLine());
    public int Reset()
    {
        // if(command == "reset") return _value = 0;
        return _value = 0;
    }

    public void PrintValue()
    {
        System.Console.WriteLine($"{_value}");
    }
}
