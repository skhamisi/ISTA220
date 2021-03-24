#### Name: Samer Khamisi

## C# HW07

**1. What is a class? According to the book, what does a class "arrange?"**

* Class is the root word of the term classification. When you design a class, you systematically arrange
information(variables) and behavior(methods) into a meaningful entity.
* Arrange is an act of classification

**2. What are the two purposes of encapsulation?**

* To combine methods and data within a class; in other words, to support classification
* To control the accessibility of the methods and data; in other words, to control the use of
 the class

**3. How do you instantiate an instance of a class? How do you access that instance?**

* You instantiate an instance of a class by using the NEW operator keyword.
New keyword goes to the heap and allocates enough space to hold the type that you defined and returns a 
memory address to the object

**4. What is the default access of the fields and methods of a class? How do you change the default?**

* default access for a method or class is private, to change this, simply write public before you 
declare the class or method

**5. What is the syntax for writing a constructor?**

* It has exactly the same name as the class and it does not have a return type

**6. What is the difference between class fields and methods, and instance fields and methods? How do you
create class fields and methods?**

* Class fields and methods belong to all of the instances of that class, we create them by using the static keyword
* Instance fields and methods belong only to that instance

**7. How do you bring a static class in scope? Why would you want to bring a static class in scope?**

* Static using statements enable you to bring a class into scope, you do this so you can omit the 
class name when accessing static members
* Math.Sqrt = Sqrt
* Console.WriteLine = WriteLine

**8. Can you think of a good reason to create an anonymous class? What is it?**

* An anonymous class is a class that does not have a name,  anonymous types are created using the Select clause of a 
LINQ queries to return a subset of the properties from each object in the collection.

**9. What is polymorphism as this term is used in computer science? This is not in the book.**

* Polymorphism refers to the ability of a programming language to interpret objects in different ways based on their class or data type. 
In essence, it is the ability of a single method to be applied to derived classes and achieve a proper output.

**10. What is message passing as this term is used in computer science? This is not in the book.**

* Message passing is a technique for invoking behavior (i.e., running a program) on a computer. The invoking program sends 
a message to a process (which may be an actor or object) and relies on that process and its supporting infrastructure to then select and 
run some appropriate code. It is how object oriented programming works

**11. What was the first object-oriented programming language?**

* Simula (1962 & 1967)

**12. Consider this quote by Alexander Stepanov:**

"I find OOP technically unsound. It attempts to decompose the world in terms of interfaces
that vary on a single type. To deal with the real problems you need multisorted algebras--
families of interfaces that span multiple types. I find OOP philosophically unsound. It
claims that everything is an object. Even if it is true it is not very interesting--saying that
everything is an object is saying nothing at all."

**Who is Alexander Stepanov? What do you think about this quote?**

* Stepanov is a Russian-American computer programmer, best known as an advocate of generic programming and as the primary designer and 
implementer of the C++ Standard Template Library