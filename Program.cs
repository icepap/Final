using System;

namespace _5._5_рекурсия
{
    class Program
    {
        /* static void Main(string[] args)
         {
             Console.WriteLine("Напишета какую нибуть фразу...");
             var saidword = Console.ReadLine();
             Console.WriteLine("Введите глубину эха...");
             var deep = int.Parse(Console.ReadLine());
             Console.WriteLine(saidword);
             Echo(saidword, deep);

             Console.ReadKey();
         }

         static void Echo(string saidword, int deep)
         {
             var modif = saidword;

             if (modif.Length>2)
                     {
                 modif = modif.Remove(0, 2);
                     }

             Console.WriteLine("... " + modif);

             if (deep > 1)
             {
                 Echo(modif, deep - 1);

             }


         }
        */
        static bool CheckNum(string num, out int correctnum)
        {
            if (int.TryParse(num, out int intnum))
            {
                if (intnum > 0)
                {
                    correctnum = intnum;
                    return false;
                }
            }
            {

                correctnum = 0;
                return true;
            }
        }

        static void FavoriteColor(string color)
        {
                       
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }


        }
          
    

       

        static void Main(string[] args)
        {
            (string name, string Surname, int Age, bool HasPet, int ColorCount, string[] colorNames) anketa;

            Console.WriteLine("Введите свое имя...");
            anketa.name = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию...");
            anketa.Surname = Console.ReadLine();

         
           

            string age;
            int correctage;

           do
                {
                    Console.WriteLine("Введите Ваш возраст цифрами...");
                    age = Console.ReadLine();
                }

            while (CheckNum(age, out correctage));
            anketa.Age = correctage;
            

             

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var result = Console.ReadLine();
            
            if (result == "Да")
            {
                anketa.HasPet = true;

                (int CountPet, string[] petsName) pets;
                string petcount;
                
                do
                {
                    Console.Write("Введите количество Ваших животных: ");
                    petcount = Console.ReadLine();
                } while (CheckNum(petcount, out pets.CountPet));

                pets.petsName = new string[pets.CountPet];
               

                for (int i = 0; i < pets.petsName.Length; i++)
                {
                    Console.WriteLine("Введите имя питомца...");
                    pets.petsName[i] = Console.ReadLine();
                    Console.WriteLine("Имя питомца №{0}: {1}", i+1, pets.petsName[i]);
                }
               
            }
            else
            {
                anketa.HasPet = false;
            }

                    


            
            string ColorsCount;
            int correctColorCount;

            do
            {
                Console.WriteLine("Введите количество любимых цветов...");
                ColorsCount = Console.ReadLine();
            }

            while (CheckNum(ColorsCount, out correctColorCount));
            anketa.ColorCount = correctColorCount;

            anketa.colorNames = new string[anketa.ColorCount];
            
            for (int k = 0; k < anketa.colorNames.Length; k++)
            {
                Console.WriteLine("Введите название любимого цвета №{0} на английском и с маленькой буквы", k + 1);
                anketa.colorNames[k] = Console.ReadLine();

                FavoriteColor(anketa.colorNames[k]);
              
            }

            
            Console.ReadKey();



        }







    }
}
