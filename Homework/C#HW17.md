### Name: Samer Khamisi

## C# HW17

**1. What is a type parameter?**

* It specifies the types of objects on which they use.
* It uses angle brackets

**2. What does a type parameter do?**

* It specifies the type of objects
* You create generic types that can take on any kind of type

**3. How many type parameters can a generic class have?**

* Unlimited

**4. What is the difference between a generic class and a generalized class?**

* A generic class uses type Parameters
* A generalized class takes parameters that can cast to different types

**5. What is a constraint? How do you specify a constraint?**

* A constraint limits the type parameters of a generic class to specific interfaces and ensures that you get certain methods.
* public class PrintableCollection<T> where T : IPrintable

**6. What is a generic method? How do you define a generic method?**

* A generalized method that are type safe and prevent casting.
* Defined MethodName

**7. What do we mean when we cay that a generic type interface is invariant?**

* You can only use the type originally specified.

**8. What do we mean when we cay that a generic type interface is covariant?**

* Enables you to use a more specific type than originally specified.

**9. Does covariance work with value types? Does it work with reference types?**

* Covariance only works with reference types, because value types cannot form inheritance hierarchies.

**10. What do we mean when we cay that a generic type interface is contravariant?**

* Allows you to use a less specific type an originally specified.