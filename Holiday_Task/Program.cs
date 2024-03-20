
using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace Holiday_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //Console.WriteLine(ReverseSentence());
            #endregion


            #region Task2
            //Console.WriteLine(ReverseNum());
            #endregion


            #region Task3
            //SameLetters();           
            #endregion


            #region Task4
            //Console.WriteLine(PolindromeWord());
            #endregion

        }

        #region Task1
        //static string ReverseSentence()
        //{
        //    Console.WriteLine("Zehmet olmasa input daxil edin:");
        //    string input=Console.ReadLine();
        //    var reverseInput=input.Reverse();
        //    string str = "";
        //    foreach (var word in reverseInput)
        //    {
        //        str+= word;
        //    }
        //    return str;
        //}
        #endregion


        #region Task2
        //static int ReverseNum()
        //{
        //    Console.WriteLine("Eded daxil edin:");
        //    value:
        //    string strNum=Console.ReadLine();
        //    bool IsCheckNum=int.TryParse(strNum, out int num);         
        //    if(!IsCheckNum)
        //    {
        //        Console.WriteLine("Duzgun eded daxil edin..");    
        //        goto value;
        //    }
        //    int number = 0;
        //    int reverseNumber = 0;
        //    while(num > 0)
        //    {
        //        number = num % 10;                         
        //        reverseNumber=reverseNumber*10+number;     
        //        num=num/10;                               
        //    }
        //    return reverseNumber;
        //}
        #endregion

        
        #region Task3

        //static void SameLetters()
        //{
        //    Console.WriteLine("Zehmet olmasa cumle daxil edin:");
        //    string sentence = Console.ReadLine();
        //    string newStr = sentence.Replace(" ", "");
        //    for (int i = 0; i < newStr.Length; i++)
        //    {                                                           
        //        int count = 0;
        //        bool CheckLetter = false;
        //        for (int j = 0; j < newStr.Length; j++)
        //        {
        //            if (newStr[i] == newStr[j])                    
        //            {
        //                if (i < j)
        //                {
        //                    CheckLetter = true;
        //                    break;
        //                }
        //                count++;
        //            }
        //        }
        //        if (!CheckLetter)
        //        {
        //            Console.WriteLine($"{newStr[i]}=>{count}");
        //        }
        //    }
           
        //}
        #endregion


        #region Task4 1st method
        //static bool PolindromeWord()
        //{
        //    Console.WriteLine("Zehmet olmasa soz daxil edin");
        //    string word = Console.ReadLine();
        //    var reversed = word.Reverse();
        //    bool IsPolindrome = false;
        //    foreach (char letter1 in reversed)
        //    {
        //        foreach (char letter2 in word)
        //        {
        //            if (letter1.ToString().ToLower() == letter2.ToString().ToLower())
        //            {
        //                IsPolindrome = true;
        //            }
        //            else
        //            {
        //                IsPolindrome = false;
        //            }
        //        }
        //    }
        //    return IsPolindrome;
        //}
        #endregion


        #region Task4 2nd method
        //static bool PolindromeWord()
        //{
        //    Console.WriteLine("Soz daxil edin:");
        //    string word=Console.ReadLine();
        //    string reversedWord = new string(word.Reverse().ToArray());
        //    return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
        //}
        #endregion
    }
}