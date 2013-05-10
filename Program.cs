/*Program: hashtabe example
 * Programmer: Dominque Terry
 */
using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace hashExample
{
    class Program
    {
        static Hashtable GetMyTable() 
        {
            Hashtable myTable = new Hashtable();
            myTable.Add("Phone Number", "888-777-9654");
            myTable.Add("Work Number", "779-999-8525");
            return myTable;
        }
        static void Main(string[] args)
        {
            Hashtable myTable = GetMyTable();

            //checks to see if the hashtable contains a key
            Console.WriteLine(myTable.ContainsKey("Phone Number"));

            //check for another key
            Console.WriteLine(myTable.Contains("Work Number"));

            string myValue = myTable["Phone Number"].ToString();
            Console.WriteLine("phone number value: " + myValue);

            string myValue2 = myTable["Work Number"].ToString();
            Console.WriteLine("work number value: " + myValue2);







        }
    }
}
