using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1= SpinWords("for shizzle ma niggle");
            WriteLine(test1);

            var list1= sockMerchant(10, new List<int>(){1, 2, 4, 4, 2, 3, 6, 7, 8, 3});
            WriteLine(list1);

            int[,] nums= {{1,2,3,4}, {4,3,2,1}};
            WriteLine(nums[1]);
            for(int i=0; i<nums.Length; i++){
                if(Array.IndexOf(nums[1], 5)){
                    WriteLine("Found");
                }
            }
        }

        public static string SpinWords(string sentence)
        {
            string[] words= sentence.Split(" ");

            string reversed= "";
            for(int i=0; i < words.Length; i++){
                if(words[i].Length >= 5){
                    for(int j= words[i].Length-1; j>=0; j--){
                        reversed += words[i][j];
                    }
                    words[i]= reversed;
                    reversed= "";
                }
            }
            sentence= string.Join(" ", words);
            
            return sentence;
        }

        public static string Decode(string morseCode)
        {
            string[] morseWords= morseCode.Split("   ");
            string english= "";
            
            for(int i=0; i < morseWords.Length; i++){
            string[] morseChars= morseWords[i].Split(" ");
            for(int j=0; j < morseChars.Length; j++){
                // english += MorseCode.Get(morseChars[j]);
            }
            english += " ";
            }
            
            return english.Trim();
        }

        public static int sockMerchant(int n, List<int> ar)
        {
            int pairs= 0;
            for(int i=0; i < ar.Count; i++){
                if(ar[i] != 0){
                    for(int j=0; j < ar.Count; j++){
                        if(ar[j] != 0 && i != j){
                            if(ar[i] == ar[j]){
                                pairs++;
                                ar[i]= 0; ar[j]= 0;
                            }
                        }
                    }
                }
            }

            foreach(int q in ar){
                Write($"{q} ");
            }WriteLine();
            
            return pairs;
        }
    }
}
