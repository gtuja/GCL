****
# GCL
G? class library
# Preface
This project started as a hobby, teach myself C#, not to mention very open source.<br>
Actually I'm not good at .net programming, neighter english.<br>
Have been living in embedded world about 20 years with data sheet, peripheral, interrupt, etc.<br>
It's time to turn around and find a way to hand over something to my fellow.<br>
Some kind of UML, e.g., package diagram, class diagram, sequence diagram, etc, shall be a good way to that<br>
so I'd like to mention those with iterative work flow on github as possible as I can.<br>
Believe in occam's razor but insight should not have come without enormous exprience.<br>
Hopely this is the first step for that.<br>

# Abbreviation
- GCL : G? Class Library
- TCL : Task Control Library
- ATL : Abstract Task Library
- TL : Task Library
- SUL : Static utility Library
- UA.NET : User Application on .NET platform
- VSC : Visual Studio Code
- SRS : System Requirement Specification
- SWRS : Software Requirement Specification
- SWDD : Software Detailed Design
- UML : Unified Modeling Language
- UI : User Interface
- 
# Table of contents
> 1. SRS
>> 1.1. Overview<br>
>> 1.2. System organization<br>
>> 1.3. Feature<br>
>>> 1.3.1. UA.NET<br>
>>> 1.3.2. GCL<br>
>> 1.4. Deliverable<br>
> 2. SWRS
>> 2.1. Overview<br>
>> 2.2. Software architecture<br>
>> 1.3. Deliverable<br>
> 3. SWDD
>> 3.1. TCL<br>
>> 3.2. ATL<br>
>> 3.3. TL<br>
>> 3.4. SUL<br>
>> 3.5. Deliverable<br>

## 1. SRS
### 1.1. Overview
- UA.NET might have needs some kind of time-consuming tasks or services.
- GCL itselft is a class library that provide something convenient features to UA.NET.
- As the first feature GCL shall provide task feature AKA TCL.
- TL is a class library that do something for UA.NET through TCL.
### 1.2. System organization
- There are three actors in this system, i.e., UA.NET, GCL, TL.
- UA.NET, GCL and TL should handle features defined at 1.3.
### 1.3. Feature
#### 1.3.1. UA.NET
- UA.NET should handle UI controls on it.
- UA.NET should implement event handlers to update UI controls when events invoked by TL through TCL.
#### 1.3.2. GCL
- GCL should define interfaces below between GCL and UA.NET. to handle TL.
> 1. define interfaces of event handler methods shall be implemented by UA.NET.
> 2. provide interfacs for task control features, e.g., register, start, stop, pause, resume, fetch status., to UA.NET.
- GCL should define arguments on on each task control features.
- GCL should events, e.g., entry, progress, exit, log, invoked by TL with event handlers set by UA.NET.  
#### 1.3.3. TL
- GCL provide interfaces, e.g., start, stop, pause, resume, fetch status, to contorl itself by TCL.



### 1.1. TCL
- TCL is a class library.
- TCL 
- TCL shall be implemented as a C# project, i.e., TaskClassLibrary.csproj, using VSC.
- TCL shall be referenced by any UA [using .NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-8-0), as an example following the steps below on VSC Terminal of your UA solution.
> 1. dotnet sln add .\GCL\TCL\TaskClassLibrary.csproj
> 2. dotnet add .\***UA***\***UA***.csproj reference .\GCL\TCL\TaskClassLibrary.csproj
- TCL should define interfaces, e.g.,  

## <a name="pookie2"></a>2. SUL
-
-
-
-
-
-
-

## <a name="pookie3"></a>3. TSK
-
-
-
-
-
-
-

2024/3/9 Seho.Seo
