using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Test_c_
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var words = await LoadWords();

            var json = JsonConvert.SerializeObject(words);

            Console.WriteLine(json);
            Console.ReadKey();

            File.WriteAllText("words.json", json);
        }

        public static async Task<List<string>> LoadWords()
        {
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine("Connecting");
                string content = await client.GetStringAsync("https://cheaderthecoder.github.io/5-Letter-words/words.txt");
                string[] lines = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                return lines.ToList();
            }
        }
    }
}
