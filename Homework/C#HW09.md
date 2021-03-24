#### Name: Samer Khamisi

## C# HW09

**1. What is an enum?**

* A value type whose values are limited to a set of symbolic names.

**2. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols,
like Private, Corporal, Sergeant or Lieutenant, Captain, Major?**

* enum Ranks {Airmen Basic = 1, Airman, Airman First Class, Senior Airman, Staff Sergeant, Technical Sergeant, Master Sergeant}

**3. Using the Ranks enum, assign a rank to yourself and a friend.**

* Rank Samer = Rank.Sergeant;
* Rank Joe = Rank.Sergeant;

**4. Determine the numeric index of particular ranks, using the Ranks enum.**

* 0, 1, 2, 3

**5. How do you select the type of an enum?**

* When you create the enum you use after the name use a colon and then the type you want to use.
* enum Ranks : short {Airmen Basic = 1, Airman, Airman First Class, Senior Airman, Staff Sergeant, Technical Sergeant, Master Sergeant}

**6. What is a struct?**

* A structure is a value type. Like a class, a structure can have its own fields, methods, and constructors.

**7. List some differences between classes and structs.**

* Structure is a value type, a class is a reference type
* Structures live on the stack, classes live on the heap
* structures cannot declare default constructors 
* A structure will not allow you to initialize instance fields at their point of declaration

**8. Are structs stored on the stack or on the heap? What about enums?**

* structs are stored on the stack.
* enums are on the stack

**9. Review the documentation for the C# System.Int32 struct. List the fields. List the methods.**

* Fields: MaxValue, MinValue
* Methods: CompareTo(Int32), CompareTo(Object), ToString(), TryParse(String, Int32) and many more

**10. Declare a struct named DOD with four branches.**

* public struct DOD { public string Army, Marines, Navy, Airforce; }

**11. Why can't you create a default constructor for a struct?**

* Because the complier will always create one for structs.

**12. What is CIL? What does the CLR do to the CIL?**

* Common Intermediate Language
* The CLR converts the CIR into something that the computer can understand.