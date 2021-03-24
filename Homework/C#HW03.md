#### Name: Samer Khamisi

## C# HW03

**1. What is a method?**

* A method is a named block of code, that optionally accepts input and returns output.

**2. (Not in book) What is the difference between a function and a procedure/subprocedure/subroutine?**

* A function is a named block of code that returns a value and it does not give an action. A subroutine/subprocedure takes action, it does not return a value, it is a statement.

**3. What does a return statement do?**

* The returnType specifies the value that a method returns.

**4. What is an expression bodied method?**

* Uses the => sequence followed by the expression that defines the body of the method and a closing semicolon.
* For example:
double calculateFee(double dailyRate, int noOfDays) =>
dailyRate * noOfDays;

**5. What is the scope of a variable?**

* The scope of a variable is simply the region of the program in which that variable is usable.

**6. What is a field?**

* A field is a variable of any type that is declared directly in a class or struct.

**7. What is an overloaded method?**

* With method overloading, multiple methods can have the same name with different parameters.
* For example: Console.WriteLine();

**8. How do you call a method that requires arguments?**

* To call (execute) a method, write the method's name followed by two parentheses () with parameters and a semicolon;

**9. How do you write a method, that is, specify the method definition, that requires a parameter list?**

* State the returnType, the methodName, parameterList, method body included between two {}.

**10. How do you specify a parameter as optional when defining a method?**

* You can implement optional parameters by using default value.  In this way, you just simply define the optional parameters 
with their default value in the method definition.

**11. How do you pass an argument to a method as a named parameter?**

* To pass an argument as a named parameter, you specify the name of the parameter, followed by a colon and the value to use. 
You can add as many parameters as you want, just separate them with a comma.

**12. How do you return values from a method? Can you return multiple values from a method, and if so,
how?**

* To return a value from a method, you must include a return statement at the end of the processing in the method body.
* You can return multiple values from a method by returning a tuple, You indicate that a method returns a tuple by specifying a
list of types as part of the method defi nition; one type for each value returned.

**13. What is a tuple? How do you define a method that returns multiple values? Give an example of a
method that returns multiple values other than the example in the book.**

* The tuples feature provides concise syntax to group multiple data elements in a lightweight data structure. To define a tuple type, 
you specify types of all its data members and, optionally, the field names. Instead of defining out method parameters, you can group 
method results in a tuple return type. 

**14. Examine the method definition on page 83 of the book. Desk check the execution of this method.**
What do you discover? This is called recursion.

* 1 long factorial ( int dataValue )
2 {
3      if ( dataValue == 1)
4           return 1 ;
5       else
6          return dataValue * factorial ( dataValue - 1) ;
7 }
* A function that calls the function either directly or indirectly

**15. How does the compiler resolve an ambiguity between named arguments and optional parameters?**

* The compiler can distinguish between the methods because they have different parameter lists.

**16. The book states: "A key feature of C# and other languages designed for the .NET Framework is the
ability to interoperate with applications and components written with other technologies." What is
the COM and how is the CLR dependent on the COM?**

* Component Object Model (COM) is one of the principal technologies that underpins many Windows applications and services running outside 
the .NET Framework. The common language runtime (CLR) used by the .NET Framework is also heavily dependent on 
COM, as is the Windows Runtime of Windows 10. COM does not support overloaded methods; instead, it uses methods that can take 
optional parameters. To make it easier to incorporate COM libraries and components into a C# solution, C# also supports optional parameters.

