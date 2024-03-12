# Software Requirement Specification
- Here we define SWRS regarding software implementation.
- As usual SWRS shall define specification according to the higer specification, SRS.

<div id="toc"></div>
<details open>
<summary><font size="5"><b>Table of Contents</b></font></summary>

- [History](#history)
- [Abbreviation](#abbreviation)
- [1. System Organization](#1_system_organization)
- [2. Features](#2_features)
- [2.1. UA.NET](#2_1_ua_net)
- [2.2. GCL](#2_2_gcl)
- [2.3. SUL](#2_3_sul)

</details>

<div id="history"></div>
<details open>
<summary><font size="5"><b>History</b></font></summary> 

- [TOC](#toc)
- draft
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
- **[SRS#005]** SUL is a class library also, provides general purpose utilities in GCL as a sub-module.
- **[SRS#006]** High level design shall be handed in as a deliverable to show relationships between actors.
</details>

<div id="2_features"></div>
<details open>
<summary><font size="5"><b>2. Features</b></font></summary>

- [TOC](#toc)
<div id="2_1_ua_net"></div>
<details open>
<summary><font size="5"><b>2.1. UA.NET</b></font></summary>

- [TOC](#toc)
- **[SRS#007]** UA.NET shall compose UI controls on it to accept user action.
- **[SRS#008]** UA.NET shall implement event handlers to update UI controls on it when events are invoked by GCL.
</details>

<div id="2_2_gcl"></div>
<details open>
<summary><font size="5"><b>2.2. GCL</b></font></summary>

- [TOC](#toc)
- **[SRS#009]** GCL shall define interfaces below between GCL and UA.NET.
> 1. define interfaces of event handler methods shall be implemented by UA.NET.
> 2. provide interfaces for task feature, e.g., register, start, stop, pause, resume, fetch status., to UA.NET.
- **[SRS#010]** GCL shall define interface arguments on each task feature.
- **[SRS#011]** GCL shall define events, e.g., trigger, progress, log, status.
- **[SRS#012]** GCL shall composite proper events during task processing with event handlers set by UA.NET.  
</details>

<div id="2_3_sul"></div>
<details open>
<summary><font size="5"><b>2.3. SUL</b></font></summary>

- [TOC](#toc)
- **[SRS#013]** SUL is a static class library.
- **[SRS#014]** SUL shall provide general purpose methods.
- **[SRS#015]** SUL is an independent library.
- **[SRS#016]** SUL shall be used by others as a sub module.
</details>
</details>


Copyleft 2024 Gtuja. All right reversed.