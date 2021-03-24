#### Name: Samer Khamisi

## C# HW01

**1. What is a console app?**
	
* An application that runs in a Command Prompt window instead of providing a graphical user 
interface.

**2. List two differences between **.NET** *Framework* and **.NET** *Core*.**

* .Net Framework is used to create Windows desktop applications and server based applications
*.Net Core is used to create portable applications that run on other operating systems. 
It does not currently support creating desktop applications with a user interface.

**3. What does **Main()** (the main method) do in a console application?**

* Designates the program’s entry point, without Main() the program is not executable.

**4.Describe these three files: *TextHello.sln*, *TextHello.csproj*, and *AssemblyInfo.cs*.**

* TextHello.sln- This is the top-level solution file. Each application contains a 
single solution file. A solution can contain one or more projects, and Visual Studio 
2017 creates the solution file to help organize these projects.
* TextHello.csproj- This is the C# project file. Each project file references one or more 
files containing the source code and other artifacts for the project, such as graphics 
images. You must write all the source code in a single project in the same programming 
language.
* AssemblyInfo.cs- A special file that you can use to add attributes to a program, such 
as the name of the author, the date the program was written, and so on. You can specify 
additional attributes to modify the way in which the program runs.

**5.What is the purpose of a *namespace*?**

* Creates a container for items such as classes. Two classes with the same name will not be 
confused with each other if they live in different namespaces.

**6. Describe specifically what *using* statements do.**

* Brings the items in a namespace into scope and frees you from having to fully qualify the 
names of classes in your code.

**7. What is the entry point for a console app? What is the entry point for a *UWP* app?**

* Console app = Main Method
* UWP app = App.Xaml file

**8. What is an *assembly*?**

* A file that usually has the '.dll' file name extension, although strictly speaking, 
executable programs with the .exe file name extension are also assemblies. They are compiled libraries.

**9. How many different versions of the **WriteLine()** method does the *Console* class contain?**

* 19

**10. What is the relationship between an assembly and a namespace?**
	
* None
	
**11. What is a graphical app?**

* Referred to as Universal Windows Platform (UWP) apps because they enable you to create apps 
that function on any device that runs Windows, such as desktop computers, tablets, 
and phones.

**12. What does a *Build* do?**

* Compiles the C# code, resulting in a program that you can run. The Output window appears 
below the Code and Text Editor window.

**13. What is a *Bytecode*? What is Microsoft *CIL*? Do you think that CIL is bytecode? Why or why not?**

* Bytecode- Program code that has been compiled from source code into low-level code designed 
for a software interpreter. It may be executed by a virtual machine (such as a JVM) or 
further compiled into machine code, which is recognized by the processor.
* Microsoft CIL- Binary instruction set defined within the Common Language Infrastructure (CLI) 
specification. CIL instructions are executed by a CLI-compatible runtime environment such 
as the Common Language Runtime. CIL is object-oriented, stack-based bytecode.
* No, because bytecode is only readable by machines, whereas CIL is intended for people.

**14. What does **Debug** do?**

* Helps you step through your code and spot problems that prevent your applications 
from working correctly.
