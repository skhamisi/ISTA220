#### Name: Samer Khamisi

## C# HW05

**1. What is a compound assignment operator? How does it work?**

* Used to combine any arithmetic operator with the assignment operator

**2. List all the compound assignment operators.**

* *=
* /=
* %=
* +=
* -=

**3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by
50.**

* int var += 5 or int var = var + 5
* int var -= 50 or int var = count - 50

**4. How long does a while loop run?**

* Until the condition evaluates to false

**5. What is an iteration variable? (Not in book)**

* A variable that changes with each iteration of the loop

**6. What happens if you don't change the loop variable in the body of the while loop block?**

* The loop goes on infinitely

**7. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of
them? What happens if you omit all of them?**

* The initialization, termination condition (Boolean expression) , and the update statement.
* You can omit any of the three parts of a for statement. If you omit the Boolean expression, it defaults to true. If you omit the initialization and update parts, 
you have a strangely spelled while loop

**8. How do you guarantee that a loop runs at least once?**

* Use a do while loop

**9. What does the break statement do?**

* Used a break statement to jump out of the body of an iteration statement

**10. What does the continue statement do?**

* The continue statement causes the program to perform the next iteration of the loop immediately (after reevaluating the Boolean expression).

**11. (Thought question) Can you think of any reason why you would want to have an infinite loop? An
"infinite loop" is a loop without an update variable that in effect runs forever. As you will see, these
kinds of loops are written intentionally to perform various kinds of tasks.**

* For a web server or windows service