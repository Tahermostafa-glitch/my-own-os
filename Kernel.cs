using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace my_os
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("                !!!WARNING!!!");
            Console.WriteLine("THIS OS JUST FOR FUN DONT TAKE THIS SERIOUSLY");
            Thread.Sleep(5000);
            Console.Clear();
            Console.Beep(220, 300);
            Console.Beep(294, 300);
            Console.Beep(250, 150);
            Console.Beep(294, 300);
            Console.Beep(220, 300);
            Thread.Sleep(2000);
            Console.WriteLine("OOOOOOOOOOOOOOOOOO    SSSSSSSSSSSSSSSS");
            Console.WriteLine("OO              OO   SS");
            Console.WriteLine("OO              OO   SS");
            Console.WriteLine("OO              OO   SS");
            Console.WriteLine("OO              OO    SSSSSSSSSSSSSSS ");
            Console.WriteLine("OO              OO    SSSSSSSSSSSSSSS ");
            Console.WriteLine("OO              OO                  SS");
            Console.WriteLine("OO              OO                  SS");
            Console.WriteLine("OO              OO                  SS");
            Console.WriteLine("OOOOOOOOOOOOOOOOOO   SSSSSSSSSSSSSSSS  animal");
            Thread.Sleep(2000);
            Console.WriteLine("os booted successfully");
            Thread.Sleep(2000);
        }

        protected override void Run()
        {
            Console.WriteLine("welcome to 0s animals\nit's dec for animals\nto content or include a new animals:taheraltahermrt@gmail.com\nEnjoy :-D");
            var exorno = true;
            while (exorno)
            {
                Console.Write("animal> ");
                var usrinp = Console.ReadLine();
                switch (usrinp.ToLower()) // Convert input to lowercase for case-insensitive comparison
                {
                    case "cow":
                        Console.WriteLine("The cow makes milk but has a bad smell.");
                        break;
                    case "camel":
                        Console.WriteLine("Makes milk like a cow and you can ride on it, but its poop smells like smoke.");
                        break;
                    case "rabbit":
                        Console.WriteLine("Is cute \"UwU\" and fast but noisy and weak.");
                        break;
                    case "cat":
                        Console.WriteLine("Beautiful and cute but messy and destroys your sofa.");
                        break;
                    case "dog":
                        Console.WriteLine("It is a friend of humans but the street dog is ugly and poops everywhere.");
                        break;
                    case "gazelle":
                        Console.WriteLine("It is beautiful and clean but rare.");
                        break;
                    case "coyotes":
                        Console.WriteLine("It is scary and strong but makes fun of donkeys.");
                        break;
                    case "horse":
                        Console.WriteLine("It is fast and beautiful but has a big ass.");
                        break;
                    case "monkey":
                        Console.WriteLine("It is intelligent but noisy. Very, very noisy.");
                        break;
                    case "donkey":
                        Console.WriteLine("It is friendly and you can ride on it like a camel or horse. It is fast but poor and expensive.");
                        break;
                    case "bear":
                        Console.WriteLine("It is huge, big, scary, and strong but is scared of cats.");
                        break;
                    case "lion":
                        Console.WriteLine("It is the king of the savanna but very rare.");
                        break;
                    case "cheetah":
                        Console.WriteLine("It is very, very, very fast but very rare in normal places.");
                        break;
                    case "elephant":
                        Console.WriteLine("It is very huge and friendly but poor.");
                        break;
                    case "rat":
                        Console.WriteLine("It is cute and common if it's a hamster, but sometimes noisy and eats the edges of things.");
                        break;
                    case "dolphin":
                        Console.WriteLine("It is smart and friendly but sometimes behaves like a sea bad boy, drinking and bullying. Long story short, dolphins are bad boys.");
                        break;
                    case "crocodile":
                        Console.WriteLine("It is useful for making bags but it's a gluttonous creature.");
                        break;
                    case "penguin":
                        Console.WriteLine("It is a snowy bird like any another snowy bird but he can't fly and scary!!!");
                        break;
                    case "eagle":
                        Console.WriteLine("it is strong and an iconic symbol of America, but it is also a predator ruthless in its hunting behavior, fake sigma!");
                        break;
                    case "bird":
                        Console.WriteLine("it is animal can fly but it is stupid and a easy snack for lion and his brothers");
                        break;
                    case "hamester":
                        Console.WriteLine("its cutey little rat. cotshi! cotshi! (m hmm) but it is spoiled animal very.very.. spoiled animal");
                        break;
                    case "kusemek":
                        Console.WriteLine("arrogant,haughty, ill mannered, and disrespectful. he would be a lamb to any female creature, even a dog!");
                        break;
                    case "furry":
                        Console.WriteLine("laggings.. Should I say more?");
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "help":
                        Console.WriteLine("cow\ncamel\nrabbit\ncat\ndog\ngazelle\ncoyotes\nhorse\nmonkey\ndonkey\nbear\nlion\ncheetah\nelephant\nrat\ndolphin\ncrocodile\npenguin\neagle\nbird\nhamester\nkusemek\nfurry");
                        break;
                    case "info":
                        Console.WriteLine("OOOOOOOOOOOOOOOOOO    SSSSSSSSSSSSSSSS");
                        Console.WriteLine("OO              OO   SS");
                        Console.WriteLine("OO              OO   SS");
                        Console.WriteLine("OO              OO   SS");
                        Console.WriteLine("OO              OO    SSSSSSSSSSSSSSS ");
                        Console.WriteLine("OO              OO    SSSSSSSSSSSSSSS ");
                        Console.WriteLine("OO              OO                  SS");
                        Console.WriteLine("OO              OO                  SS");
                        Console.WriteLine("OO              OO                  SS");
                        Console.WriteLine("OOOOOOOOOOOOOOOOOO   SSSSSSSSSSSSSSSS  animal");
                        Console.WriteLine("welcome to 0s animals\nit's dec for animals\nto content or include a new animals:taheraltahermrt@gmail.com\nEnjoy :-D");
                        Console.WriteLine("created by:taher mostafa rajab");
                        Console.WriteLine("Writed by:C# cosmos krenel");
                        break;
                    case "exit":
                        Console.WriteLine("Exiting...");
                        Sys.Power.Shutdown(); // Shutdown the machine
                        break;
                    default:
                        Console.WriteLine($"{usrinp} not found");
                        break;
                }
            }
        }
    }
}
