#### Name: Samer Khamisi

## C# HW08

**1. What is the difference between deep copy and shallow copy?**

* Deep Copy -- Clone method that returns another instance of the same class but populated with the same data. 
The Clone method would have access to the private data in an object and could copy this data directly to 
another instance of the same class.
* Shallow Copy -- The alternative approach, wherein the Clone method simply copies references,
is known as a shallow copy.

**2. What is the value of a reference after you declare and initialize it?**

* Unlike value types, a reference type doesn't store its value directly. Instead, it stores 
the address where the value is being stored. In other words, a reference type contains a pointer to another 
memory location that holds the data.

**3. How do you declare a value type?**

* It is declared before the variable with keywords such as int, double, and char. Giving it a name and optionally 
assigning it a value 

**4. How do you declare a reference type?**

* Use the keywords class, interface, delegate, or array with an assignment operator and the new keyword

**5. Does C# allow you to assign NULL to a value type?**

* Yes, you attach a '?' to the value type

**6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?**

* No, because non-nullable variables must always contain a value

**7. What is the difference between the stack and the heap?**

* Stack -- Organized memory ,it is an array of memory. It is a LIFO (Last In First Out) data structure. 
Data can be added to and deleted only from the top of it (value types)
* Heap -- Unorganized memory, it is an area of memory where chunks are allocated to store certain kinds of data objects.
Data can be stored and removed in any order (Reference types)

**8. What does it mean when we say that all classes are specialized types?**

* A class is a package and deal with the package, we don't have to know how it works on the inside.

**9. What does ref do?**

* If you prefix a parameter with the ref keyword, the C# compiler generates code that passes a reference
to the actual argument rather than a copy of the argument.
* static void Main()
{
int arg = 42;
doWork(ref arg);
Console.WriteLine(arg);
}

**10. What does out do?**

* If you prefix the argument with the out keyword, it makes the parameter an alias for the actual argument rather 
than a copy of the argument.
* static void Main()
{
int arg;
doWork(out arg);
Console.WriteLine(arg);
}

**11. Describe boxing and unboxing in your own words.**

* Boxing -- Initialize or assign a variable of type object with the value. For example:
object o = 42;
* Unboxing -- GCast the object reference that refers to the boxed value to the type of the value
variable. For example:
int i = (int)o;.

**12. What does cast do?**

* To obtain the value of the boxed copy, you must use what is known as a cast. This is an operation
that checks whether converting an item of one type to another is safe before actually making the copy.