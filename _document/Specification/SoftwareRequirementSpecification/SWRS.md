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

- **[SWRS#002]** Details of each package shall be defined in **[2. features](#2_features)**.
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
- **[SRS#007]** Gcl.Tcl is a package of types, interfaces and classes for UA.NET and Gcl.Tcl.

<div id="2_1_1_gcl_tcl_types"></div>
<details open>
<summary><font size="5"><b>2.1.1 Gcl.Tcl types</b></font></summary>

- **[SRS#007]** Gcl.Tcl shall define enumeration type below and for UA.NET and Gcl.Tcl.

> TclTaskType
>> Template<br>
>> TemplateService<br>

> TclTaskStatus
>> None<br>
>> Initialized<br>
>> Idle<br>
>> Dormant<br>
>> Busy<br>
>> Terminated<br>

- **[SRS#008]** TclTaskType is tightly linked with UA.NET requirements.
- **[SRS#008]** Gcl.Tcl provide only templates as a sample code.
- **[SRS#008]** If there is some task feature UA.NET want, it shall be added as a new TclTaskType.
- **[SRS#008]** For example, if UA.NET need serial communication service then some kind of TclTaskType shall be added, e.g., ScpService.
- **[SRS#008]** It should be coherent that corresponding Gcl.Tcl.ScpService would be managed as a submodule.
- **[SRS#008]** Gcl.Tcl shall play an intermediary role as system perspective view.
- **[SRS#008]** UA.NET and Tasks, e.g. Gcl.Tcl.ScpService are independent for each other, 
</details>

<div id="2_1_2_gcl_tcl_interfaces"></div>
<details open>
<summary><font size="5"><b>2.1.2 Gcl.Tcl interfaces</b></font></summary>

- **[SRS#008]** Gcl.Tcl shall define interfaces below to link UA.NET and Gcl.Tcl.
> ITclApplication

- **[SRS#008]** ITclApplication shall define event handlers below and those shall be implemented by UA.NET to update UI controls on it, when events are invoked by Gcl.Tcl.TaskManager.
> vidHandleTclTriggerContentChanged<br>
> vidHandleTclProgressChanged<br>
> vidHandleTclStatusChanged<br>
> vidHandleTclLogNotified<br>

- **[SRS#008]** Gcl.Tcl shall define interfaces below to link UA.NET and Gcl.Tcl.TaskManager.
> IGclTaskManager

- **[SRS#008]** ITclManager shall define methods below and those shall be implemented by Gcl.Tcl.TaskManager to provide task control features for UA.NET.
> s32Register<br>
> vidStart<br>
> vidPause<br>
> vidResume<br>
> vidStop<br>
> enuGetStatus<br>

- **[SRS#008]** ITclManager shall define event handlers below and those shall be implemented by Gcl.Tcl.TaskManager to compose and invoke events to UA.NET, when events are invoked by Gcl.Tcl.Task.
> vidHandleTaskEntry<br>
> vidHandleTaskProgressChanged<br>
> vidHandleTaskStatusChanged<br>
> vidHandleTaskLogNotified<br>
> vidHandleTaskExit<br>

- **[SRS#008]** ITclTask shall define methods below and those shall be implemented by Gcl.Tcl.Task to provide task control methods for Gcl.Tcl.TaskManager.
> vidStart<br>
> vidPause<br>
> vidResume<br>
> vidStop<br>
> enuGetStatus<br>
</details>

<div id="2_1_3_gcl_tcl_classes"></div>
<details open>
<summary><font size="5"><b>2.1.3 Gcl.Tcl classes</b></font></summary>

- **[SRS#008]** Gcl.Tcl shall define classes in order to hand over arguments on each interface defined in Gcl.Tcl.
- **[SRS#008]** Gcl.Tcl shall define event handler arguments below of each method defined in ITclApplication.
> EventTclTriggerContentChangedArgs<br>

>> strContent<br>

> EventTclProgressChangedArgs<br>

>> s32Maximum<br>
>> s32Value<br>

> EventTclStatusChanged<br>

>> strStatus<br>

> EventTclLogNotified<br>

>> strLog<br>

</details>



# 20240314

- **[SRS#008]** Gcl.Tcl shall define method arguments below of each method defined in ITclTaskManager.
> EventTclTriggerContentChangedArgs<br>

>> strContent<br>

> EventTclProgressChangedArgs<br>

>> s32Maximum<br>
>> s32Value<br>

> EventTclStatusChanged<br>

>> strStatus<br>

> EventTclLogNotified<br>

>> strLog<br>

- **[SRS#008]** Gcl.Tcl shall define method arguments below of each method defined in ITclTask.
> EventTclTriggerContentChangedArgs<br>

>> strContent<br>

> EventTclProgressChangedArgs<br>

>> s32Maximum<br>
>> s32Value<br>

> EventTclStatusChanged<br>

>> strStatus<br>

> EventTclLogNotified<br>

>> strLog<br>



</details>






</details>

<div id="2_2_gcl_tcl_task"></div>
<details open>
<summary><font size="5"><b>2.2. Gcl.Tcl.Task</b></font></summary>

- [TOC](#toc)
- **[SRS#013]** SUL is a static class library.
- **[SRS#014]** SUL shall provide general purpose methods.
- **[SRS#015]** SUL is an independent library.
- **[SRS#016]** SUL shall be used by others as a sub module.
</details>
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