# System Requirement Specification
- Here we define SRS regarding ovrall system.
- Details shall be define lower specification, e.g, SWRS, SWDD.
# History
- v0.1(draft)
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
# Table of Contents
-
-
# System composition
- **[SRS#001]** There are three actors in this system, i.e., UA.NET, GCL, SUL.
- **[SRS#002]** UA.NET shall need fetaure, e.g., time-consuming task, service, etc.
- **[SRS#003]** GCL itself is a class library that provides something convenient features to UA.NET.
- **[SRS#004]** As the first, GCL shall provide some task feature AKA TCL.
- **[SRS#007]** SUL is a class library also, provides general purpose utilities in GCL as a sub-module.
- **[SRS#007]** High level design shall be handed in as a deliverable to show relationships between actors.

# Features
## UA.NET
- **[SRS#008]** UA.NET should handle UI controls on it.
- **[SRS#009]** UA.NET should implement event handlers to update UI controls when an event invoked by GCL.
## GCL
- **[SRS#010]** GCL should define interfaces below between GCL and UA.NET.
> 1. define interfaces of event handler methods shall be implemented by UA.NET.
> 2. provide interfaces for feature task TCL, e.g., register, start, stop, pause, resume, fetch status., to UA.NET.
- **[SRS#011]** GCL should define arguments on each TCL feature.
- **[SRS#012]** GCL should define events, e.g., trigger, progress, log, status.
- GCL should composite proper events during process with event handlers set by UA.NET.  
## SUL
- **[SRS#013]** TL should provide interfaces, e.g., start, stop, pause, resume, fetch status, to control itself by TCL.
- **[SRS#014]** TL shall invoke events, e.g., entry, progress, exit, log, while doing something.
- **[SRS#015]** What should TL do is feature specific, shall be defined at *[SWDD](https://github.com/gtuja/GCL/blob/main/_document/Specification/SoftwareDetailedDesign/SWDD.md)*.
- **[SRS#016]** TL shall be implemented by each features, e.g., Template, Doxygen Parser, etc.

Copyleft 2024 Gtuja. All right reversed.