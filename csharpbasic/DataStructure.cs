using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    public class DataStructure
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }

        public void trick()
        {
            //trick of the day 

            //enhance if statement only use for assignment (var x = enhance if) 
            int temp = 100;
            var state = temp > 100 ? "hot" : "cold";
            var state2 = temp == 100 ? "hot" : temp < 0 ? "cold" : "room temp";

            //properties
            Name = "Minh";
            Age = 10;


            //nullable type 
            int? ticketOnSale = 100; //can be null ex: ticketOnSale = null; 
            int availableTicket = ticketOnSale ?? 0;  //since assign to a nullable type, ?? if null use default value '0' 


            //Parsing Parse vs TryParse
            string num = "10";
            var x = int.Parse(num);
            int.TryParse(num, out x);

        }

        public static void array()
        {
            //can store cetain data type, elemeent must be the same type (special case object type)
            int right;
            object[] intArr2 = new object[3] { 1, "1", true };
            int[] intArr = new int[3] { 1, 2, 3 };

            //Properties
            if (intArr.Length == intArr.Count()) Console.WriteLine("That is correct");

            //explore the methods

            //access element at index 
            if (intArr.ElementAt(1) == intArr[1]) Console.WriteLine("That is correct");

            //access index of element
            Array.IndexOf(intArr, 1);

            //Copy To
            int[] tempArr = new int[3];
            intArr.CopyTo(tempArr, 0);
            foreach (var item in tempArr) Console.WriteLine(item);

            //LinQ + lambda
            IEnumerable<int> list = intArr.Where(x => x < 2);
            foreach (var item in list) Console.WriteLine(item);

            //multi dimen array
            int[,] twoD = new int[2, 2]; // 2d array 2 col 2 rows
            int numRow = twoD.GetLength(0);
            int numCol = twoD.GetLength(1);

            for (int i = 0; i < numRow; i++)
            {
                for (int j = 0; j < numCol; j++)
                {
                    if (twoD[i, j] == 1) break; //accessing element of 2d arr
                }
            }


            int[,,] threeD = new int[2, 2, 2];  // 3d array

            //jagged array = array in array
            int[][] jag = new int[3][];
        }

        public static void arrayList()
        {
            //can store any type + element can be different data type

            // must use System.Collection to use arraylist
            ArrayList arr = new ArrayList();

            //explore method 


            //add
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            //index of element
            arr.IndexOf(3);

            //insert object at index
            arr.Insert(0, 5);

            //remove 'inserted' element
            arr.Remove(2);

            //remove at index
            arr.RemoveAt(0);

            //num of element
            int num = arr.Count;

            //contain
            bool isTrue = arr.Contains(1);
        }

        public void stack() { }
        public void queue() { }
        public void dictionary()
        {
            //aka map
        }
        public void linkedlist() { }


    }
}
