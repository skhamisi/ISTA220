#### Name: Samer Khamisi

## C# HW16

**1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.**

* ~ The not operator, displays the opposite. zero's and ones are reversed
* << Left Shift operator, far two left numbers are dropped and two zeros are add to the end (Raises by power of 2)
* | OR operator, returns value if either or contain a 1. 
* & AND operator, returns if both contain a 1.
* ^ XOR operator, returns value if one or the other has it but not both

**2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid C# code.**

* Right Shift operator,  opposite  of left shift (Decreases by inverse power of 2)

**3. Explain in detail this code: bits & (1 << index);**

* Bits is compared using &, 1 is left shifted number of index

**4. Explain in detail this code: bits |= (1 << index);.**

* Bits is compared the compound operator |= 1 is left shifted number indicated by index

**5. Explain in detail this code: bits &= (1 << index);.**

* Bits is compared using compound operator &= left shifted number indicated by index

**6. How does C# interpret this? bool peek = bits[n];**

* Retrieve a bool at whatever index n is set to.

**7. How does C# interpret this? bits[n] = true;**

* set the bits at index n to true

**8. How does C# interpret this? bits[n] ^= true;**

* It compares bits index n to itself and if that's true it will return true

**9. Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:**

* (a) permission = 0 = 
* (b) permission = 1 = 
* (c) permission = 2 = 
* (d) permission = 3 = 
* (e) permission = 4 = 
* (f) permission = 5 = 
* (g) permission = 6 = 
* (h) permission = 7 = 

**10. Answer the previous question by converting the decimal permissions into binary permissions. What
does this tell you about using this scheme of permissions?**

* (a) permission = 0 = 0000
* (b) permission = 1 = 0001
* (c) permission = 2 = 0010
* (d) permission = 3 = 0011
* (e) permission = 4 = 0100
* (f) permission = 5 = 0101
* (g) permission = 6 = 0110
* (h) permission = 7 = 0111

