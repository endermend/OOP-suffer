using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Operator
{
    private Dictionary<string, Phone> phones = new Dictionary<string, Phone>(100);

    public void AddPhones(params Phone[] phones)
    {
        foreach (Phone phone in phones)
        {
            this.phones.Add(phone.GetNumber(), phone);
        }
        Console.WriteLine(string.Join(" ",this.phones.Keys));
    }

    public void MakeACall(KeyValuePair<string, string> numbers)
    {
        string setter = numbers.Key, getter = numbers.Value;
        if (this.phones.ContainsKey(getter))
        {
            this.phones[getter].RecieveACall(setter);
        }
    }
}
