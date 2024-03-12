# System Requirement Specification
- Here we define SRS regarding overall system.
- Details shall be define lower specification, e.g, SWRS, SWDD.

<div id="toc"></div>
<details open>
<summary><font size="5"><b># Table of Contents</b></font></summary>

- [History](#history)
- [Abbreviation](#abbreviation)
- [1. System Organization](#1_system_organization)
- [History](#history)
- [History](#history)
</details>

<div id="history"></div>
<details open>
<summary><font size="5"><b>History</b></font></summary> 

- [TOC](#toc)
- v0.1(draft)
- 
</details>

<div id="abbreviation"></div>
<details open>
<summary><font size="5"><b>Abbreviation</b></font></summary>

- [TOC](#toc)
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
</details>


<div id="1_system_organization"></div>
<details open>
<summary><font size="5"><b>1. System Organization</b></font></summary>

- [TOC](#toc)
- **[SRS#001]** There are three actors in this system, i.e., UA.NET, GCL, SUL.
- **[SRS#002]** UA.NET shall need features, e.g., time-consuming task, service, etc.
- **[SRS#003]** GCL itself is a class library that provides something convenient features to UA.NET.
- **[SRS#004]** As the first feature, GCL shall provide some task feature AKA TCL.
- **[SRS#007]** SUL is a class library also, provides general purpose utilities in GCL as a sub-module.
- **[SRS#007]** High level design shall be handed in as a deliverable to show relationships between actors.
</details>

<div id="2_features"></div>
<details open>
<summary><font size="5"><b>2. Features</b></font></summary>

- [TOC](#toc)
<div id="2_1_ua_net"></div>
<details open>
<summary><font size="5"><b>2.1. UA.NET</b></font></summary>

- [TOC](#toc)
- **[SRS#008]** UA.NET shall handle UI controls on it.
- **[SRS#009]** UA.NET shall implement event handlers to update UI controls on it when events are invoked by GCL.
</details>

<div id="2_2_gcl"></div>
<details open>
<summary><font size="5"><b>2.2. GCL</b></font></summary>

- [TOC](#toc)
- **[SRS#010]** GCL shall define interfaces below between GCL and UA.NET.
> 1. define interfaces of event handler methods shall be implemented by UA.NET.
> 2. provide interfaces for feature task TCL, e.g., register, start, stop, pause, resume, fetch status., to UA.NET.
- **[SRS#011]** GCL shall define arguments on each TCL feature.
- **[SRS#012]** GCL shall define events, e.g., trigger, progress, log, status.
- **[SRS#012]** GCL shall composite proper events during process using event handlers set by UA.NET.  
</details>

<div id="2_3_sul"></div>
<details open>
<summary><font size="5"><b>2.3. SUL</b></font></summary>

- [TOC](#toc)
- **[SRS#013]** TL should provide interfaces, e.g., start, stop, pause, resume, fetch status, to control itself by TCL.
- **[SRS#014]** TL shall invoke events, e.g., entry, progress, exit, log, while doing something.
- **[SRS#015]** What should TL do is feature specific, shall be defined at *[SWDD](https://github.com/gtuja/GCL/blob/main/_document/Specification/SoftwareDetailedDesign/SWDD.md)*.
- **[SRS#016]** TL shall be implemented by each features, e.g., Template, Doxygen Parser, etc.
</details>
</details>


Copyleft 2024 Gtuja. All right reversed.