# Software Requirement Specification
- Here we define SWRS with software perspective.
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
- **[SWRS#001]** There are packages below those provide features to actor AKA UA.NET.

> Gcl.Tcl<br>
> Gcl.Tcl.TaskManager<br>
> Gcl.Tcl.Task<br>
> Gcl.Tcl.Template<br>
> Gcl.Tcl.TemplateService<br>
> Gcl.Sul<br>
> Gcl.Sul.Wpf<br>

- **[SWRS#002]** Details of each package shall be defined in **[2. features](#2_features)**.
- **[SWRS#003]** A Package diagram shall be handed in as a deliverable to show relationships between packages and UA.NET.
</details>

<div id="2_features"></div>
<details open>
<summary><font size="5"><b>2. Features</b></font></summary>

- [TOC](#toc)
<div id="2_1_gcl_tcl"></div>
<details open>
<summary><font size="5"><b>2.1. Gcl.Tcl</b></font></summary>

- [TOC](#toc)
- **[SWRS#004]** Gcl.Tcl is a package of types, events, interfaces and classes for UA.NET and Gcl.Tcl itself.
- **[SWRS#005]** Gcl.Tcl shall play an intermediary role as system perspective view.
- **[SWRS#006]** Gcl.Tcl shall provide templates, i.e., Gcl.Tcl.Template, Gcl.Tcl.TemplateService, as a sample code.
- **[SWRS#007]** For an example, If UA.NET needs some task feature of serial communication protocol service, e.g., Gcl.Tcl.TaskScpService.
- **[SWRS#008]** Gcl.Tcl shall define new task type, e.g., Gcl.Tcl.TaskType.ScpService. 
- **[SWRS#009]** UA.NET shall pass that type as a member of arguments, Gcl.Tcl.TclRegisterArgs, using s32TaskRegister in Gcl.Tcl.TaskManager interfaces.
- **[SWRS#010]** After that, UA.NET and Gcl.Tcl.TaskScpService is fully independent from each other, as long as they implement features defined in Gcl.Tcl each other.
- **[SWRS#011]** These feature are the heart of Gcl.Tcl, in other word event driven design concept.
- **[SWRS#012]** Additionally Gcl.Tcl and UA.NET shall be implemented as an **[event aggregator design pattern](https://martinfowler.com/eaaDev/EventAggregator.html)**.

<div id="2_1_1_gcl_tcl_types"></div>
<details open>
<summary><font size="5"><b>2.1.1 Gcl.Tcl types</b></font></summary>

- **[SWRS#013]** Gcl.Tcl shall define enumeration type below and for UA.NET and Gcl.Tcl.

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

- **[SWRS#014]** TclTaskType is tightly linked with UA.NET requirement.
- **[SWRS#015]** TclTaskType shall correspond to each UA.NET requirement as mentioned at **[2.1. Gcl.Tcl](#2_1_gcl_tcl)**.
- **[SWRS#016]** TclTaskStatus shall represent current status of a task, Gcl.Tcl.TaskXxxx, e.g., Gcl.Tcl.TaskScpService.
</details>

<div id="2_1_2_gcl_tcl_events"></div>
<details open>
<summary><font size="5"><b>2.1.2 Gcl.Tcl events</b></font></summary>

- **[SWRS#017]** Gcl.Tcl shall define events below as members in ITclApplication to link UA.NET and Gcl.Tcl.
- **[SWRS#018]** Event handlers for each event shall be implemented by UA.NET.

> evtTclTriggerContentChanged<br>
> evtTclProgressChanged<br>
> evtTclStatusChanged<br>
> evtTclLogNotified<br>

- **[SWRS#017]** Gcl.Tcl.TaskManager shall invoke these events when it compose events invoked by Gcl.Tcl.TaskXxxx. 
- **[SWRS#017]** Gcl.Tcl.TaskManager shall invoke evtTclTriggerContentChanged when there are 
- **[SWRS#017]** Gcl.Tcl shall define events below as members in ITclApplication 

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
> vidDeregister<br>

- **[SRS#008]** ITclManager shall define event handlers below and those shall be implemented by Gcl.Tcl.TaskManager to compose events invoked by Gcl.Tcl.Task and invoke events to UA.NET as needed.
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
> vidDeregister<br>

- **[SRS#008]** ITclManager shall define event handlers below and those shall be implemented by Gcl.Tcl.TaskManager to compose events invoked by Gcl.Tcl.Task and invoke events to UA.NET as needed.
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
- **[SRS#008]** Gcl.Tcl shall define tcl event handler arguments below of each method defined in ITclApplication.
> EventTclTriggerContentChangedArgs<br>

>> strContent<br>

> EventTclProgressChangedArgs<br>

>> s32Maximum<br>
>> s32Value<br>

> EventTclStatusChanged<br>

>> strStatus<br>

> EventTclLogNotified<br>

>> strLog<br>

- **[SRS#008]** Gcl.Tcl shall define tcl method arguments below those of each method defined in ITaskManager.
> TclTaskRegisterArgs<br>

>> enuTaskType<br>

> TclTaskStartArgs<br>

>> s32TaskId<br>

> TclTaskPauseArgs<br>

>> s32TaskId<br>

> TclTaskResumeArgs<br>

>> s32TaskId<br>

> TclTaskStopArgs<br>

>> s32TaskId<br>

> TclTaskStatusArgs<br>

>> s32TaskId<br>

> TclTaskDeregisterArgs<br>

>> s32TaskId<br>

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

- **[SRS#008]** Gcl.Tcl shall define task event handler arguments below, those of each method defined in ITclTaskManager.

> TaskStartArgs<br>

>> TBD<br>

> TaskPauseArgs<br>

>> TBD<br>

> TaskResumeArgs<br>

>> TBD<br>

> TaskStopArgs<br>

>> TBD<br>

> TaskStatusArgs<br>

>> TBD<br>

- **[SRS#008]** Gcl.Tcl shall define task event arguments below of each method defined in ITclTask.


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