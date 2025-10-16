using System.Collections;
using System.ComponentModel.DataAnnotations;

public class DS
{
    /*
     | Operation          | Description                                          |
| ------------------ | ---------------------------------------------------- |
| **push(item)**     | Adds an item to the top of the stack                 |
| **pop()**          | Removes and returns the top item from the stack      |
| **peek() / top()** | Returns (views) the top item **without removing** it |
| **isEmpty()**      | Checks if the stack is empty                         |
| **isFull()**       | (in case of fixed size) Checks if the stack is full  |


     */

    public void StackMethod()
    { 
      Stack<int> s = new Stack<int>();
        s.Push(1);
        s.Push(2);
        s.Push(3);

        s.Peek();

        foreach(int num in s)
        {

            Console.WriteLine(num);
        }

        Console.WriteLine(s.Pop());



    }


    /*
     | Operation         | Description                                           |
    | ----------------- | ----------------------------------------------------- |
    | **Enqueue(item)** | Add (insert) an element at the **rear** of the queue  |
    | **Dequeue()**     | Remove an element from the **front** of the queue     |
    | **Peek()**        | View the element at the **front** without removing it |
    | **Count**         | Returns the number of elements                        |
    | **Clear()**       | Removes all elements                                  |


     */
    public void queueMethod()
    { 
    Queue<int> q= new Queue<int>();

        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        q.Enqueue(40);

        foreach (int n in q)
        { 
            Console.WriteLine(n);
        }

        
    
    }


    public void arrlist()
    { 
        ArrayList al = new ArrayList();
        al.Add(100);
        al.Add(200);
        al.Add(300);  
        al.Add(400);

        foreach (int n in al)
        { 
            Console.WriteLine(n);
        }
    }
    /*
                     | Method            | Description              |
                | ----------------- | ------------------------ |
                | `Add(item)`       | Adds an item             |
                | `Remove(item)`    | Removes first occurrence |
                | `RemoveAt(index)` | Removes item at position |
                | `Count`           | Number of items          |
                | `Contains(item)`  | Checks if item exists    |
                | `Sort()`          | Sorts list               |
                | `Clear()`         | Removes all items        |

     
     */

    public void listMethod()
    { 

        List<int> list1= new List<int>();
        list1.Add(100);
        list1.Add(200);
        Console.WriteLine("Default Constructor: ");
        foreach (var i in list1)
        { 
            Console.WriteLine(i);
        }

        int[] num = { 10, 20, 50, 80 };
        List<int> list2= new List<int>(num);
        Console.WriteLine("Constructor with IEnumerable: ");
        foreach (int i in list2)
        { 
            Console.WriteLine(i);
        }
        Console.WriteLine("Constructor with Initial Capacity: ");
        List<int> list3 = new List<int>(5);
        list3.Add(100);
        list3.Add(200);
        list3.Add(300);
        list3.Add(400);
        list3.Add(500);

        foreach (var i in list3)
        {
            Console.WriteLine(i);
        }

    }

    /*
                 | Method                 | Description         |
            | ---------------------- | ------------------- |
            | `Add(key, value)`      | Adds a pair         |
            | `Remove(key)`          | Removes pair by key |
            | `ContainsKey(key)`     | Checks key exists   |
            | `ContainsValue(value)` | Checks value exists |
            | `Count`                | Number of pairs     |
            | `Clear()`              | Removes all items   |

     
     */
    public void DictionaryMethod()
    { 
      Dictionary<int , string > dc = new Dictionary<int , string>();
        Console.WriteLine("Dictionary : ");
        dc.Add(1, " Hii");
        dc.Add(2, " Mehul ");
        dc.Add(3, " How are you ?");

        foreach (var i in dc)
        {
            Console.WriteLine($"{i.Key}  : {i.Value}");
        }
        Console.WriteLine("\n After Remove Dictionary : ");
        dc.Remove(3);

        foreach (var i in dc)
        { 
            Console.WriteLine($"{i.Key} : {i.Value}");
        }
    }


    public void SortedListMethod()
    {
        Console.WriteLine("SortedList :");
        SortedList<int , string > st = new SortedList<int , string>();

        st.Add(2, " mehul");
        st.Add(3, " BCA");
        st.Add(1, " Jamukiya");

        foreach (var i in st)
        {
            Console.WriteLine($"{i.Key} : {i.Value}");
        }
       
    }


    public void HashtableMethod()
    {
        Console.WriteLine("Hashtable :");

        Hashtable hs = new Hashtable();
        hs.Add(1, "Value 1");
        hs.Add(2, "Value 2");
        hs.Add(3, "Value 3");
        hs.Add(4, "Value 4");

        foreach (DictionaryEntry i in hs)
        {
            Console.WriteLine($"key :{i.Key} : {i.Value} ");
        }
    }

}
