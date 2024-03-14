# Software Requirement Specification
- Here we define SWRS as software perspective.
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
- **[SWRS#001]** There are packages below those provide features to actor UA.NET.

> Gcl.Tcl<br>
> Gcl.Tcl.TaskManager<br>
> Gcl.Tcl.Task<br>
> Gcl.Tcl.Template<br>
> Gcl.Tcl.TemplateService<br>
> Gcl.Sul<br>
> Gcl.Sul.Wpf<br>

- **[SWRS#002]** Dtails of each package shall be defined in [2.features](#2_features).
- **[SWRS#006]** A Package diagram shall be handed in as a deliverable to show relationships between packages and UA.NET.
</details>

<div id="2_features"></div>
<details open>
<summary><font size="5"><b>2. Features</b></font></summary>

- [TOC](#toc)
<div id="2_1_gcl_tcl"></div>
<details open>
<summary><font size="5"><b>2.1. Gcl.Tcl</b></font></summary>

- [TOC](#toc)
- 
- **[SRS#007]** Gcl.Tcl is a package holding interfaces and classes for UA.NET and Gcl.Tcl itself.
- **[SRS#007]** Gcl.Tcl shall define enumeration type below and for UA.NET and Gcl.Tcl itself.
> TclTaskType<br>
>> Template<br>
>> TemplateService<br>
> TclTaskStatus<br>
>> None<br>
>> Initialized<br>
>> Idle<br>
>> Dormant<br>
>> Busy<br>
>> Terminated<br>

- **[SRS#008]** TclTaskType is tightly linked with UA.NET requirements.
- **[SRS#008]** Gcl.Tcl provide only templates as a sample code.
- **[SRS#008]** If there is some task feature UA.NET want, it shall be added as a new TclTaskType.
- **[SRS#008]** For example, UA.NET need sirial communication service, some kind of TclTaskType shall add, e.g., ScpService.
- **[SRS#008]** It should be coherent that coresponding Gcl.Tcl.ScpService would be managed as a submodule.
- **[SRS#008]** Gcl.Tcl shall play an intermediary role with system perspective view.
- **[SRS#008]** UA.NET and Tasks, e.g. Gcl.Tcl.ScpService are independent for each other, 


-
- **[SRS#008]** Gcl.Tcl shall dedine interfaces below to link UA.NET and Gcl.Tcl.
> ITclApplication<br>
- **[SRS#008]** ITclApplication shall dedine methods below to UA.NET to update UI controls on it when events are invoked by Gcl.Tcl.Manager.
> vidHandleTclTriggerContentChanged<br>
> vidHandleTclProgressChanged<br>
> vidHandleTclStatusChanged<br>
> vidHandleTclNotified<br>
- **[SRS#008]** ITclManager shall define methods below to provide task feature for UA.NET.
> s32Register
> vidStart
> vidPause
> vidResume
> vidStop
> enuGetStatus
- **[SRS#008]** ITclTask shall define methods below to Gcl.Tcl.Task for Gcl.Tcl.Manager.
> vidStart
> vidPause
> vidResume
> vidStop
> enuGetStatus
- **[SRS#008]** Gcl.Tcl shall define enumeration type below to UA.NET and Gcl.Tcl.
> TaskType : Template(mandatory), DxgnParser, Scp, Tcp, etc.
> TaskStatus : None, Initialized, Ready, Dormant, Paused, Busy, Terminated.
- **[SRS#008]** Gcl.Tcl shall dedine classes below in order to hand over arguments on each interface between UA.NET and Gcl.Tcl or Gcl.Tcl itself.
> EventTriggerContentArgs<br>
>> strContent<br>

> EventProgressArgs<br>
>> s32Maximum<br>
>> s32Value<br>

> EventStatusArgs<br>
>> strStatus<br>

> EventLogArgs<br>
>> strLog<br>

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