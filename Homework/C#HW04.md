#### Name: Samer Khamisi

## C# HW04

**1. What are all possible values of Boolean expression?**

* Always evaluates to true or false

**2. List the equality operators. List the relational operators. List the logical operators. How are they the
same? How are they different?**

* Equality
==  Equal to
!=  Not equal to
* Relational
<   Less than
<=  Less than or equal to
>   Greater than
>=  Greater than or equal to
* Logical
&&   AND The outcome of the && operator is true if and only if both of the Boolean expressions it’s evaluating are true.
NOT
||   OR  The outcome of the || operator is true if either of the Boolean expressions it evaluates is true.

**3. What is the general concept of short circuiting? This question has a short and simple answer and you
do not need to have a detailed response.**

* Based on whether you're using the AND or OR operator, you code can decide to skip the remaining code in order to run more efficiently

**4. What are the differences in how short circuiting works for && and ||?**

* If the left operand of the && operator evaluates to false, the result of the entire expression must be false, regardless of the 
value of the right operand.
* If the value of the left operand of the || operator evaluates to true, the result of the entire expression must be true, irrespective 
of the value of the right operand.

**5. Look at the list of operators. What operator has the highest precedence? Which has the lowest?**

* ()- Highest precedence
* = - Lowest precedence

**6. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?**

* Allows you to perform more than one statement when a Boolean expression is true. A block also starts a new scope.

**7. In a switch statement, what happens if you omit break?**

* Without a break , the code will fall-through and continue

**8. The four keywords in a switch statement are switch, case, break, and default. Explain what each
keyword does.**

* Switch  - Switch statement finishes and the program continues at the first statement that follows the closing brace of the switch statement.
* Case    - The value of the expression is compared with the values of each Case, if there is a match, the associated block of code is executed.
* Break   - Breaks out of the switch block.
* Default - Optional and specifies some code to run if there is no case match.

**9. Look at the source listing below. It contains two methods: recurr1() and recurr2(). There is a
significant difference between the two methods. What is it?**

* Recurr2 involves tail recursion. The compiler turns recursive code into an iteration statement.

**10. (Not in book) What is a recursive method? Using a language you know (such as English), write a
recursive method that adds up the integers in a list of integers. The input to the method is a list of
integers and the output is a scalar value representing a sum.**

* The method calls itself, until a termination condition is met

