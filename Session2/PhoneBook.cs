using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Session2
{
    public class PhoneBook : Phone
    {

        private List<(string name, string phone)> phoneList;

        public PhoneBook()
        {
            phoneList = new List<(string name, string phone)>();
        }

        public override void InsertPhone(string name , string phone )
        {
            if (!phoneList.Any(p => p.name == name))
            {
                phoneList.Add((name, phone));
                Console.WriteLine($"Added: {name} with phone: {phone}");
            }
            else
            {
                var existingPhone = phoneList.FirstOrDefault(p => p.name == name);
                if (existingPhone.phone != phone)
                {
                    phoneList.Remove(existingPhone);
                    phoneList.Add((name, phone));
                    Console.WriteLine($"Updated: {name} with new phone: {phone}");
                }
                else
                {
                    Console.WriteLine($"Phone already exists for {name}.");
                }
            }
        }

        public override void InsertPhone(string name)
        {
            var phoneToRemove = phoneList.FirstOrDefault(p => p.name == name);
            if (phoneToRemove != default)
            {
                phoneList.Remove(phoneToRemove);
                Console.WriteLine($"Removed: {name} with phone: {phoneToRemove.phone}");
            }
            else
            {
                Console.WriteLine($"Phone not found for name: {name}");
            }
        }

        public override void UpdatePhone(string name, string newphone)
        {
            var phoneToUpdate = phoneList.FirstOrDefault(p => p.name == name);
            if (phoneToUpdate != default)
            {
                phoneList[phoneList.IndexOf(phoneToUpdate)] = (name, newphone);
                Console.WriteLine($"Updated: {name} with new phone: {newphone}");
            }
            else
            {
                Console.WriteLine($"Phone not found for name: {name}");
            }
        }

        public override void SearchPhone(string name)
        {
            var phone = phoneList.FirstOrDefault(p => p.name == name);
            if (phone != default)
            {
                Console.WriteLine($"Found: {phone.name}: {phone.phone}");
            }
            else
            {
                Console.WriteLine($"Phone not found for name: {name}");
            }
        }

        public override void Sort()
        {
            phoneList.Sort((p1, p2) => String.Compare(p1.name, p2.name));
            Console.WriteLine("Phone list sorted.");
        }

        
    }
}
