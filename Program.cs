using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static int[] RandomArray(){
            int[] rArr = new int[10];
            Random rand = new Random();
            int min = rArr[0];
            int max = rArr[0];
            int sum = 0;
            for(int i = 0; i < rArr.Length; i++){
                rArr[i]= rand.Next(5,26);
                sum += rArr[i];
                if(max < rArr[i]){
                    max = rArr[i];
                }
                if(min > rArr[i] || i == 0){
                    min = rArr[i];
                }
            }
            Console.WriteLine("Max: "+max+ " Min: "+min+"  Sum: "+sum);
            for(int i = 0; i < rArr.Length; i++){
                Console.WriteLine(rArr[i]);
            }
            return rArr;
        }

        public static string TossCoin(){
            string result = "";
            Console.WriteLine("Tossing A Coin!");
            Random rand = new Random();
            if(rand.Next(10) <= 5){
                result = "Heads";
            } else {
                result = "Tails";
            }
            Console.WriteLine(result);
            return result;
        }
        public static double TossMultipleCoins(int num){
            int count = 0;
            int heads = 0;
            Random rand = new Random();
            while(count < num){
                if(rand.Next(10) < 5){
                    heads++;
                }
                count++;
            }
            double perc = (double)heads/(double)count;
            Console.WriteLine(perc);
            return perc;
        }

        public static List<string> Names(){
            List<string> names = new List<string>{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random random = new Random();
            string temp = "";
            for(int i = 0; i < names.Count; i++){
                int rand = random.Next(0,names.Count);
                temp = names[rand];
                names[rand] = names[i];
                names[i] = temp;
            }
            for( int j = 0; j < names.Count; j++){
                if(names[j].Length < 5){
                    names.RemoveAt(j);
                }
                Console.Write(names[j]+ ", ");
            }
            Console.WriteLine();
            return names;
        }
        static void Main(string[] args)
        {
            RandomArray();
            TossMultipleCoins(1000000);
            Names();
        }
    }
}
