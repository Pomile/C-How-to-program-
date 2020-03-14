using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace NumToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int con = 1;
            while(con == 1){
                Console.Write("Enter a num: ");
                string numstr = Console.ReadLine();
                 displayMessage(covertNumToWords(numstr));
                 Console.Write("Enter any number to exit or enter 1 to continue: ");
                 con = int.Parse(Console.ReadLine());
            }
        }

        private static string covertNumToWords(string num)
        {
            var words = new StringBuilder();
            var str = num;
            var counter = str.Length;
            try{
                if (NumToWordsErrorHanlder(str) != str){
                    throw new Exception(NumToWordsErrorHanlder(str));
                };
                 do
                {
                    if(counter == 1){
                        
                        var result = getUnitNoInWords(str);
                        words.Append(result);
                        --counter;
                    } else if(counter == 2)
                    { 
                        var result = getTenOrTeensNoInWords(str);
                        words.Append($" {result}");
                        counter -=2;
                    
                    } else if(counter == 3){
                        var strUnit = getUnitNoInWords(str);
                        str = str.Substring(1);
                        if(str=="00"){
                            words.Append(strUnit.Trim() == ""? $"and":$"and {strUnit} hundred");
                        }else{
                            words.Append(strUnit.Trim() == ""? $"and":$"{strUnit} hundred and");
                        }
                        --counter;
                    } else if(counter == 4){
                        var strUnit = getUnitNoInWords(str);
                        str = str.Substring(1, counter-1);
                        words.Append($"{strUnit} thousand ");
                        --counter;
                    }else if(counter == 5 || counter == 6){
                        var result = counter == 5 ? 
                        getTenOrTeensNoInWords(str.Substring(0, 2)) :
                        getUnitNoInWords(str.Substring(0, 1));
                        if(result.Trim() != ""){
                            words.Append(counter == 5 ? $"and {result.Trim()} thousand " : $"{result.Trim()} hundred ");
                        }else if(result.Trim() == ""){
                            words.Append("thousand, ");
                        }
                        
                        str = counter == 5 ? str.Substring(2) : str.Substring(1);
                        if(counter == 5 ){
                            counter -=2 ;
                        } else{
                            --counter;
                        } 
                    }
                    
                }while(counter > 0);
                

                return words.ToString();

            }catch(Exception ex){
                return ex.Message;
            }
           
        }

        private static string findWordEquivalent(Dictionary<string, string> numMaps,string numstr)
        {
            
            StringBuilder words = new StringBuilder();

            for(int counter = numstr.Length; counter > 0; counter -=numstr.Length)
            {
                foreach(KeyValuePair<string, string> numMap in numMaps)
                {
                    if(numMap.Key == numstr)
                    {
                        words.Append(numMap.Value);
                        break;
                    }
                }
            }
            return words.ToString();
        }

        private static void displayMessage(string str)
        {
            Console.WriteLine(str);
        }

        private static bool containTeen(int[] teens, int num){
            var result = false;
            for(int counter =0; counter < teens.Length; counter++)
            {
                if(teens[counter] == num )
                {
                    
                    result = true;
                    break;
                }
            
            }
            return result;
        }
        private static string getUnitNoInWords(string str){
            var digits = new Dictionary<string, string>()
            { 
                {"1", "One"}, {"2","Two"}, {"3", "Three"},
                {"4", "Four"}, {"5","Five"}, {"6", "Six"},
                {"7", "Seven"}, {"8","Eight"}, {"9", "Nine"}
            };
             string result = findWordEquivalent(digits, str.Substring(0, 1));
             return result;
        }

        private static string getTenOrTeensNoInWords(string str){
            string result = String.Empty;
            int[] numArr = { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            var tens = new Dictionary<string, string>()
            { 
                {"10", "Ten"}, {"20","Twenty"}, {"30", "Thirty"},
                {"40", "Fourty"}, {"50","Fifty"}, {"60", "Sixty"},
                {"70", "Seventy"}, {"80","Eighty"}, {"90", "Ninety"}
            };

             var teens = new Dictionary<string, string>()
            { 
                {"11", "Eleven"}, {"12","Twelve"}, {"13", "Thirteen"},
                {"14", "Foueteen"}, {"15","Fifteen"}, {"16", "Sixteen"},
                {"17", "Seventeen"}, {"18","Eighteen"}, {"19", "Nineteen"}
            };
            if(containTeen(numArr, int.Parse(str))){
                var strTeens = findWordEquivalent(teens, str);
                result = strTeens;  
            } else{
                var convertToTens = str.Substring(0, 1) + '0';
                var digit = str.Substring(1);
                var strTens = findWordEquivalent(tens, convertToTens);
                var strUnit = getUnitNoInWords(digit);
                result = $"{strTens} {strUnit}";
            }
            return result;
        }

        private static string NumToWordsErrorHanlder(string str){
            try{
                if(int.Parse(str) <= 0){
                    throw new Exception("No negative or zero value. Please enter a positive value");
                }
                if(str.Substring(0, 1) == "0"){
                    throw new Exception("No Trailing zero");
                }
                return str;

            }catch(Exception ex){
                
                // Console.WriteLine(ex.Message);
                return ex.Message;
            }

        }
    }
}
