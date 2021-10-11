using System;

namespace CyclicCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            int total = 0;
            do{
                key = Console.ReadKey(true);
                try{
                    string str = ""+key.KeyChar;
                    int val =  Convert.ToInt32(str);
                    if(total == 0 && val == 0){
                        continue;
                    }else{
                        total *= 10;
                        total += val;
                    }
                    Console.WriteLine("Character: "+str+" "+val+" "+total);
                }catch(Exception e){
                    Console.WriteLine("Exception: "+e.Message+" "
                            +key.Key.ToString());
                }
            }while(key.Key != ConsoleKey.Escape);
        }
    }
}
