#### Name: Samer Khamisi

## C# HW02

**1. What is a local *variable*?**
	
* Variables that exist only within the scope of a small section of code or block

**2. What is a *statement*?**

* A command that performs an action, such as calculating a value and storing the result or displaying a message to a user. 
You combine statements to create methods. A statement is anything that ends with a semicolon.

**3. What is an *identifer*?**

* Identifiers are the names that you use to identify the elements in your programs, such as namespaces, classes, methods, 
and variables.	

**4. What is a *keyword*?**

* The C# language reserves 77 identifiers for its own use, and you cannot reuse these identifiers for your own purposes. 
These identifiers are called keywords

**5. What is a *variable*?**

* A variable is a storage location that holds a value. You can think of a variable as a box in the computer’s memory that holds 
temporary information. A name location in memory that may contain a value.

**6. How do you declare a variable? How do you assign a value to a variable? Can you have a variable that
does not have a value? Can you declare and initialize a variable in a single statement?**

* Write the name of the data type, followed by the name of the variable, followed by a semicolon.	
* You can assign a value to a variable through the equal sign, which is known as the assignment operator. Assignment operator takes 
the value on the right hand side and puts in the left
* You cannot have a variable without a value
* Yes

**7. What does Visual Studio do when you open a project (a .csproj file) without opening the solution (a
.sln file)? Why might this be a problem?**

* If you open a project rather than a solution, Visual Studio 2017 automatically creates a new solution file for it. 
This situation can be confusing if you are not aware of this feature because it can result in you accidentally generating 
multiple solutions for the same project.

**8. How are arithmetic operators and variable types related?**

* The operator you use depends on the value type.

**9. How do you turn an integer into a string?**

* Use int32.ToString method

**10. How do you turn a string into an integer?**

* The .NET Framework provides a method called Int32.Parse that you can use to convert a string value to an integer

**11. What is the difference between precedence and associativity? Give an example where this makes a
dfference.**

* Precedence governs the order in which an expression’s operators are evaluated, while Associativity 
is the direction (left or right) in which the operands of an operator are evaluated. 	
* If you perform the division fi rst, the result of the division (4/2) forms the left operand of the * operator, and the 
result of the whole expression is (4/2) * 6, or 12. If you perform the multiplication fi rst, the result of the 
multiplication (2 * 6) forms the right operand of the / operator, and the result of the whole expression is 4/(2 * 6), or 4/12.

**12. What is the *definite assignment rule*?**

* You must assign a value to a variable before you can use it; otherwise, your program will not compile. 

**13. How are the prefix and postfix increment and decrement operators evaluated differently?**

* The order in which the increment or decrement takes place in the statement. Prefix it is evaluated after the operation is ran, 
during postfix it is evalueated after.

**14. What is *string interpolation*?**

* Using string interpolatin you can direct the computer to evaluate an expression in a string

**15. What does the *var* keyword do?**

* You can ask the C# compiler to infer the type of a variable from an expression and use this 
type when declaring the variable by using the var keyword in place of the type