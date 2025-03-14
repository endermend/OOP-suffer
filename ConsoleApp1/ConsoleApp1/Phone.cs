using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Phone
{
    private Dictionary<string, string> contacts = new Dictionary<string, string>();
    private string phone_number = "000";
    private Phone() { }

    public Phone(string phoneNumber)
    {
        this.phone_number = phoneNumber;
    }

    public string GetNumber()
    {
        return this.phone_number;
    }

    public void AddContact(string phoneNumber, string name)
    {
        this.contacts[name] = phoneNumber;
    }

    public KeyValuePair<string, string> CallByName(string name)
    {
        if (this.contacts.ContainsKey(name))
        {
            return CallByNumber(this.contacts[name]);
        }
        else
        {
            Console.WriteLine("Contact not found");
            return KeyValuePair.Create("", "");
        }
    }

    public KeyValuePair<string, string> CallByNumber(string phoneNumber)
    {
        return KeyValuePair.Create(this.phone_number, phoneNumber);
    }

    public void RecieveACall(string number)
    {
        string name = this.contacts.FirstOrDefault(x => x.Value == number, KeyValuePair.Create(number, number)).Key;
        Console.WriteLine($"MSG from {this.phone_number}: {name} is calling");
    }
}
