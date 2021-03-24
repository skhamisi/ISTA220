#### Name: Samer Khamisi

## C# HW10

**1. What does an array look like in memory?**

* Arrays live in a continuous (together in a sequence) block of memory and are accessed by using an index.."

**2. Where is memory allocated to hold an array, on the stack or on the heap?**

* The Heap

**3. Where is memory allocated to hold an array reference, on the stack or on the heap?**

* The Stack

**4. Can an array hold values of different types? This is a trick question, the answer is, "It depends." What
determines the types that an array can hold?**

* An array can hold references to different types, you just have to specify  type for an array.
* An Object type will allow an array to hold any type.

**5. Describe the syntax of the condition for a foreach loop.**

* int[ ] socks = {1, 2, 3, 4}; 
foreach (sock in socks) 
{
   Console.WriteLine("sock");
}

**6. How do you make a deep copy of a array?**

* By using Clone, and all of the fields that reference types also provide a clone method.

**7. What is the difference in the syntax between a multi-dimensional array and an array of arrays?**

* A multi-dimensional array takes up a lot of memory and if you don't use it, it's a waste
* Array of arrays each column has a different length and there is no memory wasted.

**8. What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words,
what determines whether you would use one as opposed to the other?**

* Array of arrays (jagged arrays) are faster than multi-dimensional arrays and can be used more effectively. 
Multidimensional arrays have nicer syntax.

**9. How do you "flatten" a multidimensional array? In other words, take something that looks like a matrix 
and turn it into an array [1; 2; 3; 4; 5; 6; 7; 8; 9]? Write the code to do this in English.**

* int[ ][ ] twoDimensional = new int[ ][ ] { 
                                        new int[ ] {1, 2},
                                        new int[ ] {3, 4},
                                        new int[ ] {5, 6}
                                           };

* int [ ] flattened = twoDimensional.SelectMany(x=>x).ToArray();

**10. (Thought question) When we use a for loop, we can change the values of the array elements inside
the loop. When we use a foreach loop, we cannot change the values of the arry elements inside the
loop. Why not? How is for different from foreach?**

* However, that loop variable is a read-only copy of the actual element of the collection that we loop over. 
So while we get the element's value (as a copy), our loop doesn't work with the actual element itself.