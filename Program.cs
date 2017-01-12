using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AssessDemo
{
    /***Program to read in file and find the student with the highest mark.
     * The following is for guidance only. Use of Global and local variables and which parameters you chose to pass
     * is your decision as a programmer***/


    class Program
    {
          // global variable for the array
       

        static void Main(string[] args)   // main method to execute other functions within the program
        {
           String text =  readIn();    // calling the readIn() and string result in variable called "text"
           splitText(text);            // calling the splitText() and passing in the variable called "text" to be split up




        }


        public static String readIn()
        {  // method to readIn the text from the file and store in an array

            String loremIpsum = "";
            try 
            {
                StreamReader reader = new StreamReader("C:\\Users\\rhenderson\\desktop\\LoremIpsum.txt");  //reader object to read in file
                loremIpsum = reader.ReadToEnd();

                // read file to end and store in a string variable
               // Console.WriteLine(loremIpsum);  // verified it was working using this code
               // Console.ReadLine();             
            
            }
            catch(FileNotFoundException fnfe) 
            {
                Console.WriteLine("File Not Found", fnfe);
                Console.ReadLine();

            }

            return loremIpsum;  // returns the string variable where the text data has been stored
           
            
        
        }


        public static void splitText(String s)
        {   // method to seperate the text and store in an array. Takes in a variable of type String

            char[] seperators = new char[] { ' ', ',', '.', };

            String[] wordArr = s.Split(seperators);

            for(int i = 0; i<wordArr.Length;i++)    // loopuing through word array to check that it has been stored correctly
            {
               Console.WriteLine(wordArr[i]);
            
            
            }
            Console.ReadLine();  //screen freeze

        }


      //  public static string findHighest(string[] anArray) 
      //  {
            // method to find the student with the highest mark



           // return "0"; // change this to return the result. Only returning zero at the moment to avoid syntax errors
      //  }



   //     public void outPutResult(string highest) 
      //  { 
           
          
             // method to display result to user and output the result to a file.
        
     //   }


    }
}
