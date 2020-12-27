using Entities;
using System;

namespace Composicao2_CSharp {
    class Program {
        static void Main(string[] args) {
            string data = DateTime.Now.ToLongDateString();
            Console.WriteLine(data + "\n\n");

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString()),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString()),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
