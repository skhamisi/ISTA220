#### Name: Samer Khamisi

## C# HW13

**1. What is an interface as the term is used on object-oriented programming?**

* An interface does not contain any code, it just specifies the methods and properties that a 
class that inherits from the interface must provide.
* Separates the "What" from the "How"

**2. How do you define an interface?**

* As you would a class but instead you use the interface keyword

**3. Can an interface have variables, fields, or properties?**

* No, an interface can not contain any data, because an interface is an abstraction

**4. How do you define a method in an interface?**

* Just as you would in a class but without using an access modifier

**5. Can you instantiate an object through an interface? Why or why not?**

* Yes, an interface is still a type even though it contains no data

**6. Using the new keyword, can you declare a reference to an interface?**

* Yes, IFirearm f = new Pistol();

**7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how
can it do so?**

* Yes, both objects and classes can. It must use all the methods declared by these interfaces, if there 
are more than one, they would be separated by commas in a list.

**8. What does it mean to  explicitly  implement an interface?**

* Specify which interface a method belongs to like interface.method
* Type name . method name

**9. What are the restrictions on interfaces?**

* Not allowed to define any fields in an interface.
* Not allowed to define any constructors in an interface
* Not allowed to define a destructor in an interface (used to destroy an object instance)
* Cannot specify an access modifier for any method (all methods are public)
* Cannot nest any types -- enums, structs, classes or interfaces
* Not allowed to inherit form a struct or a class

**10. What is the difference between an abstract class and an interface?**

* Abstract classes can have data and implementation

**11. What is an abstract method?**

* It does not contain a method body and the derived class must override the method.

**12. What is a sealed class?**

* A class that can not be used as a base class or inherited 

**13. What is an sealed method?**

* A method that cannot be overridden