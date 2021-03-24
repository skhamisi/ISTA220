#### Name: Samer Khamisi

## C# HW18

**1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticket just submitted. What kind of data structure would you use, and why?**

* A queue, because it is first in first out

**2. You are building a tracking system for seasonal agricultural farm labor. The labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated first, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?**

* A stack, because it is first in last out

**3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?**

* A list, you wouldn't need to search it

**4. You are building an analytical database. Your requirement is that the database handle queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?**

* Hashset, because it's faster to find the data

**5. You are building a personnel directory, where searches are performed by last name, first name, middle name. What kind of data structure would you use, and why?**

* Dictionary, because you can search by keys rather than an index

**6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happen extremely quickly. What kind of data structure would you use, and why?**

* Dictionary

**7. What is a lambda expression? Give an example.**

* A lambda expression is an expression that returns a method, an example would be an anonymous function that you can inline in the code.

**8. What is the difference between lambda expressions and anonymous methods? What are the advantages of each?**

* Anonymous methods let you define a delegate without having to create a named method
