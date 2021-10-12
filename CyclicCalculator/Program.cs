using System;
using System.Collections.Generic;

namespace CyclicCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            Console.WriteLine("Type Your Equation Below: ");
            char next = ' ';
            int total = 0;
            int acc = 0;
            bool done = false;
            List<char> ops = new List<char>();
            ops.Add('+');
            ops.Add('-');
            ops.Add('*');
            ops.Add('/');
            ops.Add('=');
            do{
                key = Console.ReadKey(true);
                try{
                    string str = ""+key.KeyChar;
                    int val =  Convert.ToInt32(str);
                    if(acc == 0 && val == 0){
                        continue;
                    }else{
                        acc *= 10;
                        acc += val;
                    }
                    Console.Write(key.KeyChar);
                    continue;
                }catch(Exception ){
                }
               

                if(ops.Contains(key.KeyChar)){
                    if(ops.Contains(next)){
                        switch(next){
                            case '+': total += acc; break;
                            case '-': total -= acc; break;
                            case '*': total *= acc; break;
                            case '/': total /= acc; break;
                            case '=': done = true; break;
                            default:break; //Whu?
                        }
                        acc = 0;
                        if(key.KeyChar == '='){
                            done = true;
                        }
                    } else {
                        total = acc;
                        acc = 0;
                    } 
                    Console.Write(key.KeyChar);
                    next = key.KeyChar;
                }
            }while(!done && key.Key != ConsoleKey.Escape);
            Console.WriteLine(total);
        }
    }
}
