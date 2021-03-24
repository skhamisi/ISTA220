 #### Name: Samer Khamisi

## C# HW15

**1. What is the difference between a property and a field?**

* Properties hide fields
* A field has no implantation a property does

**2. What is the difference between a property and a method?**

* Properties contain fields and methods define behavior.

**3. What is your understanding of encapsulation?**

* It hides parts of the code, so other people can't access your information

**4. Some languages are case insensitive, that is, an "a" and an "A" are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifiers? Do you think that the difference in case in the initial character of two different
identifiers is sufficient to distinguish them?**

* It makes it difficult to find errors when case is the only thing that separates names.

**5. Give an example that is not in the book of an instance where you might want to use a read-only
property. Give an example not in the book of an instance where you might want to use s write-only
property.**

* Read-Only: Name, Model Number Something that you don't want to change.
* Write-Only: ID number

**6. Can you think of a reason why you might ever want to make getters and setters private? Give an
example. Also, make a case why getters and setters should never be private.**

* Get and set was are never supposed to be private so you can access the data

**7. What are restrictions on the use of properties?**

* You can assign a value through a property of a strut or class only after the class or structs has been initialized
* You can't use a property as a ref or out argument to a method
* A property cannot have more than one get or set accessor
* Get and set can't take any Parameters
* Can't use the const keyword

**8. What is an object initializer? What is the syntax for an object initializer?**

* When you create an object and initialize the values from the properties as parameters.
* Object name = new Object(Parameters from properties)