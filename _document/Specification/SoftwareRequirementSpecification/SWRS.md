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
- **[SWRS#001]** There are packages below, those provide features to actor AKA. UA.NET.

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
- **[SWRS#004]** Gcl.Tcl is a package of types, interfaces, and classes for UA.NET and Gcl.Tcl.*.
- **[SWRS#005]** Gcl.Tcl shall play an intermediary role between UA.NET, Gcl.Tcl.*.
- **[SWRS#006]** Gcl.Tcl shall provide templates, i.e., Gcl.Tcl.Template, Gcl.Tcl.TemplateService, as a sample code.
- **[SWRS#007]** As an example, let's say that UA.NET needs some task feature of serial communication protocol service, e.g., Gcl.Tcl.TaskScpService.
- **[SWRS#008]** Gcl.Tcl shall define a new task type, e.g., Gcl.Tcl.TaskType.ScpService. 
- **[SWRS#009]** UA.NET shall pass that type as a member of arguments, Gcl.Tcl.TclRegisterArgs, of s32TaskRegister in Gcl.Tcl.TaskManager interfaces.
- **[SWRS#010]** From now on, UA.NET and Gcl.Tcl.TaskScpService are fully independent from each other, as long as they implement interfaces defined in Gcl.Tcl for each other.
- **[SWRS#011]** This concept is the heart of Gcl.Tcl, in other word, event driven design concept.
- **[SWRS#012]** Additionally Gcl.Tcl.Task, Gcl.Tcl.TaskManager, and UA.NET shall be implemented as an **[event aggregator design pattern](https://martinfowler.com/eaaDev/EventAggregator.html)**.

<div id="2_1_1_gcl_tcl_types"></div>
<details open>
<summary><font size="5"><b>2.1.1 Gcl.Tcl types</b></font></summary>

- **[SWRS#013]** Gcl.Tcl shall define enumeration types below, for UA.NET and Gcl.Tcl.*.

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

<div id="2_1_1_1_gcl_type_tcl_task_type"></div>
<details open>
<summary><font size="5"><b>2.1.1.1. Gcl.Tcl TclTaskType</b></font></summary>

- [TOC](#toc)
- **[SWRS#014]** TclTaskType is tightly linked with UA.NET requirement.
- **[SWRS#015]** TclTaskType shall correspond to each UA.NET requirement as mentioned at **[2.1. Gcl.Tcl](#2_1_gcl_tcl)**.
</details>

<div id="2_1_1_2_gcl_type_tcl_task_status"></div>
<details open>
<summary><font size="5"><b>2.1.1.1. Gcl.Tcl TclTaskStatus</b></font></summary>

- [TOC](#toc)
- **[SWRS#016]** TclTaskStatus shall represent current status of a task, e.g., Gcl.Tcl.TaskTemplate.
</details>
</details>

<div id="2_1_2_gcl_tcl_interface"></div>
<details open>
<summary><font size="5"><b>2.1.2 Gcl.Tcl interface</b></font></summary>

- **[SRS#008]** Gcl.Tcl shall define interfaces below to link UA.NET and Gcl.Tcl.*.

> ITclApplication<br>
> ITclTaskManager<br>
> ITclTask<br>

<div id="2_1_2_1_gcl_tcl_interface_itcl_application"></div>
<details open>
<summary><font size="5"><b>2.1.2.1 Gcl.Tcl ITclTaskApplication</b></font></summary>

- **[SRS#008]** ITclApplication shall define event handlers below, those shall be implemented by UA.NET to do something, e.g., update UI controls on it, etc, when events, e.g., evtTclStarted, evtTclProgressChanged, evtTclTerminated, evtTclAsserted, are invoked by Gcl.Tcl.TaskManager.
- **[SRS#008]** These event handlers shall be handed over to Gcl.Tcl.TaskManager as an interface argument, i.e., TclRegisterArgs, through s32TclRegisterTask defined in Gcl.Tcl.ITaskManager.
- **[SRS#008]** Detail of each event itself shall be defined in **[2.1.2.2 Gcl.Tcl ITclTaskManager](#2_1_2_2_gcl_tcl_interface_itcl_task_manager)**.

> vidHandleTclStarted<br>
> vidHandleTclProgressChanged<br>
> vidHandleTclTerminated<br>
> vidHandleTclAsserted<br>
</details>

<div id="2_1_2_2_gcl_tcl_interface_itcl_task_manager"></div>
<details open>
<summary><font size="5"><b>2.1.2.2 Gcl.Tcl ITclTaskManager</b></font></summary>

- **[SRS#008]** ITclTaskManager shall define events below, those shall be invoked by Gcl.Tcl.TaskManager.

> evtTclStarted<br>
> evtTclProgressChanged<br>
> evtTclTerminated<br>
> evtTclAsserted<br>

- **[SRS#008]** Gcl.Tcl.TaskManager shall invoke these events to UA.NET as needed.
- **[SRS#008]** The evtTclStarted shall be invoked when any of Gcl.Tcl.Task registered is started, e.g., evtTaskEntry is invoked, etc.
- **[SRS#008]** The evtTclProgressChanged shall be invoked when any of Gcl.Tcl.Task registered reports progress, e.g., evtTaskProgressChanged is invoked, etc.
- **[SRS#008]** The evtTclTerminated shall be invoked when any of Gcl.Tcl.Task registered is terminated, e.g., evtTaskExit is invoked, etc.
- **[SRS#008]** The evtTclAsserted shall be invoked when there is something to assert to UA.NET, e.g. error, exception, warning, log, etc. 
- **[SRS#008]** ITclManager shall aggregate events, e.g., evtTaskEntry, evtTaskProgressChanged, evtTaskExit, evtTaskAsserted, invoked by Gcl.Tcl.Task registered, and invoke events, e.g., evtTaskStarted, evtTclProgressChanged, evtTclTerminated, evtTclAsserted, to UA.NET as needed.
**[2.1.2.1 Gcl.Tcl ITclApplication](#2_1_2_1_gcl_tcl_interface_itcl_application)**.
- **[SRS#008]** ITclManager shall define event handlers below, those shall be implemented by Gcl.Tcl.TaskManager.

> vidHandleTaskEntry<br>
> vidHandleTaskProgressChanged<br>
> vidHandleTaskExit<br>
> vidHandleTaskAsserted<br>

- **[SRS#008]** ITclManager shall define methods below, those shall be implemented by Gcl.Tcl.TaskManager to provide task features for UA.NET.

> s32Register<br>
> vidStart<br>
> vidPause<br>
> vidResume<br>
> vidStop<br>
> enuGetStatus<br>
> vidDeregister<br>
</details>


<div id="2_1_2_3_gcl_tcl_interface_itcl_task"></div>
<details open>
<summary><font size="5"><b>2.1.2.3 Gcl.Tcl ITclTask</b></font></summary>

- **[SRS#008]** ITclTask shall define events below, those shall be invoked by Gcl.Tcl.Task*, e.g., Gcl.Tcl.TaskTemplate.

> evtTaskEntry<br>
> evtTaskProgressChanged<br>
> evtTaskExit<br>
> evtTaskAsserted<br>

- **[SRS#008]** Gcl.Tcl.TaskManager shall handle these events, **[2.1.2.2. Gcl.Tcl.ITclTaskManager](#2_1_2_2_gcl_tcl_interface_itcl_task_manager)**.
- **[SRS#008]** Gcl.Tcl.Task shall implement these events and invoke them to Gcl.Tcl.TaskManager as needed.
- **[SRS#008]** The evtTaskEntry shall be invoked when Gcl.Tcl.Task is started.
- **[SRS#008]** The evtTaskProgressChanged shall be invoked when Gcl.Tcl.Task reports progress.
- **[SRS#008]** The evtTaskExit shall be invoked when Gcl.Tcl.Task exits.
- **[SRS#008]** The evtTaskAsserted shall be invoked when there is something to assert to Gcl.Tcl.TaskManager, e.g. error, exception, warning, log, etc.
- **[SRS#008]** Event handlers are defined in ITclTaskManager **[2.1.2.2 Gcl.Tcl ITclTaskManager](#2_1_2_2_gcl_tcl_interface_itcl_task_manager)**.
- **[SRS#008]** ITclTask shall define methods below, those shall be implemented by Gcl.Tcl.Task to provide task features for Gcl.Tcl.TaskManager.

> vidTaskStart<br>
> vidTaskPause<br>
> vidTaskResume<br>
> vidTaskStop<br>
> enuTaskGetStatus<br>
</details>
</details>


<div id="2_1_3_gcl_tcl_classes"></div>
<details open>
<summary><font size="5"><b>2.1.3 Gcl.Tcl classes</b></font></summary>

- **[SRS#008]** Gcl.Tcl shall define classes in order to hand over arguments on each interface defined in Gcl.Tcl.
- **[SRS#008]** Gcl.Tcl shall define tcl event handler arguments below of each method defined in ITclApplication.
> EventTclTriggerContentChangedArgs<br>
> EventTclProgressChangedArgs<br>
> EventTclStatusChanged<br>
> EventTclLogNotified<br>
- **[SRS#008]** Gcl.Tcl shall define tcl method arguments below those of each method defined in ITaskManager.

> TclTaskRegisterArgs<br>
> TclTaskStartArgs<br>
> TclTaskPauseArgs<br>
> TclTaskResumeArgs<br>
> TclTaskStopArgs<br>
> TclTaskStatusArgs<br>
> TclTaskDeregisterArgs<br>

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