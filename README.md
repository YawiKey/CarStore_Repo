This Repository has a model of a Car Store that follows a Youtube Tutorial called C# Car Store Applications from Professor Sluiter

Below are the following problems and resolutions that happened in the making of it

Problem 01 : Non Compatible frameworks between the Class Library and Console App Classes
  Description: The Class library only had the option of .NET ( 2.0 up to 6.0) and the Console App only had avaliable the .NET Framework 4.6 - 4.8), when trying to use the reference - dependency way to link up the two projects it showed an error calling them "incompatible"
  Solution:
    a) Tried to link up different versions of the .NET and .NET framework per the suggestion that some of them may have compatibilities with a plugin
    b) Tried updating in the Visual Studio 2022 installer the versions of the frameworks or actualizing the 2022 version present in my computer
    c) VALID SOLUTION: installing the ASP.NET module from the Visual Studio 2022 installer. After it diferent Console App and ClassLibrary appeared

Problem 02: missing using a directuve or an assembly reference Error 
  Description: When doing the instance of the ClassLibrary in the Console App it still showed an error , ignoring the previous "Show posible fixes" - " Add reference to" option selected
  Solution: 
    a) VALID SOLUTION: manually write "using CarClassLibrary" at the top of the ConsoleApp class 
