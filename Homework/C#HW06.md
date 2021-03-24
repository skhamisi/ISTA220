#### Name: Samer Khamisi

## C# HW06

**1. What is an exception?**

* Any unexpected or exceptional situations that occur when a program is running.

**2. What happens in a try block if the program executes without errors?**

* If none of the statements generates an exception, they all run, one after the other, to completion.

**3. How does the catch mechanism work for unhandled exceptions?**

* A catch handler is intended to capture and handle a specifi c type of exception, and you can have multiple 
catch handlers after a try block, each one designed to trap and process a specifi c exception.

**4. What happens in a program if an exception block fails to handle an particular error?**

* Throws OverFlowException, the method immediately exits and execution returns to the calling method.

**5. What is the parent class for all exceptions? How does this work?**

* Exception

**6. How do you determine the type of an error?**

* Exception.GetType Method

**7. What is the purpose of integer checking?**

* To ensure that there is no overflow 

**8. What is the range of values that a signed Int32 type can contain? State the lowest value and the
highest value.**

* -2,147,483,648 to 2,147,483,647

**9. What is the range of values than an unsigned Int32 type can contain? State the lowest value and the
highest value. What is the difference between a signed integer and an unsigned integer? Can signed
integers and unsigned integers represent the same amount of numbers?**

* 0 to 4,294,967,295
* Unsigned integers do not include negative numbers and so allow for a higher ceiling for positive numbers. 

**10. What does the finally block do?**

* The finally block will execute when the try/catch block leaves the execution, no matter what condition cause it. 
It always executes whether the try block terminates normally or terminates due to an exception.