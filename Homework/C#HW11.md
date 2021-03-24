#### Name: Samer Khamisi

## C# HW11

**1. What is a parameter array?**

* An array that is automatically created by the compiler when you pass the proper amount of parameters for the method
* When you need an indefinite number of arguments, you can declare a parameter array, which 
allows a procedure to accept an array of values for a parameter.

**2. How do you define a method that takes an arbitrary number of arguments?**

* By using the params keyword as the parameter modifier

**3. How do you call a method that takes an arbitrary number of arguments?**

* By calling the method name and passing your arguments as parameters.

**4. Why can't you use an array to pass an arbitrary number of arguments to a method?**

* You can use an array but you would have to write out each array separately

**5. How many parameters can a method have?**

* As many as you want

**6. Do parameter arguments have to have the same type?**

* No, they will be put in an object array

**7. What is the difference between a method that takes a parameter argument and one that takes optional
arguments?**

* One that takes optional arguments has a fixed parameter list
* One that takes a parameter arguments can have an arbitrary list of parameters and none of them have a default value.

**8. How do you define a method that takes different (and arbitrary) types of arguments?**

* By using an object array (params object [] paramList)

**9. Write a method that accepts any number of arguments of a given type.**

* double Max(params double[] values)

**10. Write a method that accepts any number of arguments of any type.**

* You can't