#### Name: Samer Khamisi

## C# HW20

**1. What is a delegate? Explain delegates in terms of pointers and reference types.**

* A delegate is a reference type. They delegate processing to the referenced method when they are invoked. A delegate is an object that refers to a method, you can assign a reference to a method in much the same way that you can assign an int value to an int variable. A delegate is similar to a function pointer. However, unlike function pointers, delegates are completely type safe. You can make a delegate refer only to a method that matches the signature of the delegate and you can not invoke a delegate that does not refer to a valid method. 

**2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.**

* To declare a delegate you utilize the delegate keyword, specify the return type, a name for the delegate, and any parameters. 
* `public delegate int PerformCalculation(int x, int y);`

**3. How do you create instances of delegates and assign values to the instance? What are the values?**

* To create an instance of a delegate it must first be declared and then called by specifying its access and name and then the name of the of the instance. 
* The value that is assigned to the delegate is a method and it is assigned to the instance with the compound assignment operator +=.

**4. How do you invoke a method that has been added to a delegate?**

* You can invoke the delegate by calling the instance using the `this` keyword. 

**5. What is an event? Why do we have events?**

* Events are used to define an trap significant actions and arrange for a delegate to be called to handle the situation.

**6. How do you declare events?**

* You declare an event similarly to how you declare a field. However, because events are intended to be used with delegates, the type of an event must be a delegate, and you must prefix the declaration with the event keyword. Use the following syntax to declare an event:
* `event delegateTypeName eventName`

**7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?**

* When an event calls a delegate it calls all the methods that have been subscribed to it using the compound assignment operator +=. Similarly you can unsubscribe a delegate from an event using the compound assignment operator -=.

**8. How do you raise an event? How do you declare code that raises an event?**

* You can raise an event by calling it like a method, the declaration is nearly identical. You can declare code to raise an event by using an if statement, a loop structure, or just calling it.

**9. Explain with specificity what happens when an event fires and that event has been attached to a
delegate.**

* You can raise an event by calling it like a method. When you raise an event, all the attached delegates are called in sequence.