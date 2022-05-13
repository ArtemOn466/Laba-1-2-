using System.Text.Json;
using System;

namespace laba
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //змінна s, у яку ми зберігаємо нашу фразу або слово
            var d = s.GroupBy(x => x).OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Count()); //змінна d, у яку ми записуємо словник й прописуємо сортування ключів й відповідно значення

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key} - {item.Value}"); //через цикл заповнюємо словник 
            }
            string json = JsonSerializer.Serialize(d);   //серіалізація словника     
            File.WriteAllText("dictionary.json", json);  //запис словника у файл JSON
        }
    }
}