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

        /*
        /// Collections classes library:
        /// System.Collections.Generic classes: A generic collection is useful when every item in the collection has the same data type. A generic collection enforces strong typing by allowing only the desired data type to be added.
        /// System.Collections.Concurrent classes: provide efficient thread-safe operations for accessing collection items from multiple threads.
        /// System.Collections classes: do not store elements as specifically typed objects, but as objects of type Object
        /// 
        /// Non-Generic return object 
        /// Generic return generic type 
        /// https://learn.microsoft.com/en-us/dotnet/standard/collections/
        /// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections#BKMK_Generic
        */

        /// <summary>
        /// non-generic collection can store any object (generic version of this is List<T>
        /// </summary>
        public static void arrayList()
        {
            //can store any type + element can be different data type

            // must use System.Collection to use arraylist
            ArrayList arrListNonGeneric = new ArrayList();
            List<Int32> arrListGeneric = new List<Int32>();

            //explore method 

            //add
            arrListNonGeneric.Add(1);
            arrListNonGeneric.Add("string");
            arrListNonGeneric.Add(true);
            arrListGeneric.Add(1);
            arrListGeneric.Add(2);
            arrListGeneric.Add(3);

            // acess element 
            object num = arrListNonGeneric[0];
            int num1 = arrListGeneric[0];
            // index of element
            arrListNonGeneric.IndexOf(3);

            //insert object at index
            arrListNonGeneric.Insert(0, 5);

            //remove 'inserted' element
            arrListNonGeneric.Remove(2);

            //remove at index
            arrListNonGeneric.RemoveAt(0);

            //num of element
            int num2 = arrListNonGeneric.Count;

            //contain
            bool isTrue = arrListNonGeneric.Contains(1);
        }

        /// <summary>
        /// can be generic or non-generic
        /// cant dirrectly access an element 
        /// only has access to top of the stack 
        /// </summary>
        public void stack() { 
            Stack<Int32> stackGeneric = new Stack<Int32>();
            Stack stackNonGeneric = new Stack();
            stackGeneric.Push(1);
            stackGeneric.Push(2);
            stackGeneric.Push(3);
            stackNonGeneric.Push(1);
            stackNonGeneric.Push("string");
            stackNonGeneric.Push(true);
            if (stackGeneric.Count == 3)
            {
                Console.WriteLine("true");
            }
            if (stackGeneric.Peek() == 3)
            {
                Console.WriteLine("true"); 
            } 
            if((bool)stackNonGeneric.Pop())
            {
                Console.WriteLine("true"); 
            }

            if (stackNonGeneric.Contains(1))
            {
                Console.WriteLine("true");
            }

            if (stackGeneric.Contains(1))
            {
                Console.WriteLine("true");
            }
            stackGeneric.Clear(); 
            if (stackGeneric.Count == 0)
            {
                Console.WriteLine("true");
            }

        }

        /// <summary>
        /// can be generic or non-generic
        /// cant dirrectly access an element 
        /// only has access to first of the queue
        /// </summary>
        public void queue() {
            Queue queueNonGeneric = new Queue();
            Queue<Int32> queueGeneric = new Queue<Int32>();

            queueNonGeneric.Enqueue(1);
            queueNonGeneric.Enqueue("string");
            queueNonGeneric.Enqueue(true);
            queueGeneric.Enqueue(1);
            queueGeneric.Enqueue(2);
            queueGeneric.Enqueue(3);
            if (queueNonGeneric.Count == 3)
            {
                Console.WriteLine("true");
            }
            if (queueNonGeneric.Contains(1))
            {
                Console.WriteLine("true");
            }
            if (queueNonGeneric.Dequeue() == (object)1)
            {
                Console.WriteLine("true");
            }
            if (queueNonGeneric.Dequeue() == (object)"string")
            {
                Console.WriteLine("true");
            }
            queueGeneric.Clear(); 
            if(queueGeneric.Count == 0)
            {
                Console.WriteLine("true");
            }

        }

        /// <summary>
        /// generic
        /// </summary>
        public void dictionary()
        {
            //aka map
        }

        /// <summary>
        /// generic
        /// </summary>
        public void linkedlist() { }

        /// <summary>
        /// generic
        /// </summary>
        public void hashtables() { }
        public void sortset() { }
    }
}
