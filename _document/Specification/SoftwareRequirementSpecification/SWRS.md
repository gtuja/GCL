# Software Requirement Specification
- Here we define SWRS as software perspective.
- As usual SWRS shall define specification according to the higher specification, SRS.

<div id="toc"></div>
<details open>
<summary><font size="5"><b>Table of Contents</b></font></summary>

- [History](#history)
- [Abbreviation](#abbreviation)
- [1. Software Organization](#1_software_organization)
- [2. Feature](#2_feature)
- [2.1. Gcl.Tcl](#2_1_gcl_tcl)
- [2.1.1. Gcl.Tcl Type](#2_1_1_gcl_tcl_type)
- [2.1.2. Gcl.Tcl Interface](#2_1_2_gcl_tcl_interface)
- [2.1.3. Gcl.Tcl Class](#2_1_3_gcl_tcl_class)
- [2.2. Gcl.Sul](#2_2_gcl_sul)
- [2.2.1. Gcl.Sul.Xml](#2_2_1_gcl_sul_xml)
- [2.3. Gcl.Sul.Wpf](#2_3_gcl_sul_wpf)
- [2.3.1. Gcl.Sul.Wpf.UI](#2_3_1_gcl_sul_wpf_ui)
- [3. Reference](#3_reference)
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

<div id="1_software_organization"></div>
<details open>
<summary><font size="5"><b>1. Software Organization</b></font></summary>

- [TOC](#toc)
- **[SWRS#001]** There are packages below, those provide features to actor AKA. UA.NET.

> **Gcl.Tcl**<br>
> **Gcl.Tcl.TaskManager**<br>
> **Gcl.Tcl.Task**<br>
> **Gcl.Tcl.Template**<br>
> **Gcl.Tcl.TemplateService**<br>
> **Gcl.Sul**<br>
> **Gcl.Sul.Wpf**<br>

- **[SWRS#002]** Details of each package shall be defined in ***[2. feature](#2_feature)***.
- **[SWRS#003]** A Package diagram shall be handed in as a deliverable to show relationships between packages and **UA.NET**.
</details>

<div id="2_feature"></div>
<details open>
<summary><font size="5"><b>2. Feature</b></font></summary>

- [TOC](#toc)
<div id="2_1_gcl_tcl"></div>
<details open>
<summary><font size="5"><b>2.1. Gcl.Tcl</b></font></summary>

- [TOC](#toc)
- **[SWRS#004]** **Gcl.Tcl** is a package of types, interfaces, and classes for **UA.NET** and **Gcl.Tcl.*.**
- **[SWRS#005]** **Gcl.Tcl** shall play an intermediary role between **UA.NET**, **Gcl.Tcl.*.**
- **[SWRS#006]** **Gcl.Tcl** shall provide templates, i.e., **Gcl.Tcl.Template**, **Gcl.Tcl.TemplateService**, as a sample code.
- **[SWRS#007]** As an example, let's say that **UA.NET** needs some task feature of serial communication protocol service, e.g., **Gcl.Tcl.TaskScpService**.
- **[SWRS#008]** **Gcl.Tcl** shall define a new task type, e.g., *Gcl.Tcl.TaskType.ScpService*. 
- **[SWRS#009]** **UA.NET** shall pass that type as a member of arguments, **Gcl.Tcl.TclRegisterArgs**, of interface *s32TaskRegister* defined in ***ITclTaskManager***.
- **[SWRS#010]** From now on, **UA.NET** and **Gcl.Tcl.TaskScpService** are fully independent from each other, as long as they implement interfaces defined in **Gcl.Tcl** for each other.
- **[SWRS#011]** This concept is the heart of **Gcl.Tcl**, in other word, event driven design concept.
- **[SWRS#012]** Additionally **Gcl.Tcl.Task, Gcl.Tcl.TaskManager**, and **UA.NET** shall be implemented as an ***[event aggregator design pattern](https://martinfowler.com/eaaDev/EventAggregator.html)***.

<div id="2_1_1_gcl_tcl_type"></div>
<details open>
<summary><font size="5"><b>2.1.1 Gcl.Tcl Type</b></font></summary>

- [TOC](#toc)
- **[SWRS#013]** **Gcl.Tcl** shall define types below, for **UA.NET** and **Gcl.Tcl.*.**

> **TclTaskType**
>> *Template*<br>
>> *TemplateService*<br>

> **TclTaskStatus**
>> *None*<br>
>> *Initialized*<br>
>> *Idle*<br>
>> *Dormant*<br>
>> *Busy*<br>
>> *Terminated*<br>

- **[SWRS#014]** **TclTaskType** is tightly linked with **UA.NET** requirement.
- **[SWRS#015]** **TclTaskType** shall correspond to each **UA.NET** requirement as mentioned at ***[2.1. Gcl.Tcl](#2_1_gcl_tcl)***.
- **[SWRS#016]** **TclTaskStatus** shall represent current status of a task, e.g., **Gcl.Tcl.TaskTemplate**.
</details>

<div id="2_1_2_gcl_tcl_interface"></div>
<details open>
<summary><font size="5"><b>2.1.2 Gcl.Tcl Interface</b></font></summary>

- [TOC](#toc)
- **[SWRS#017]** **Gcl.Tcl** shall define interfaces below to link **UA.NET** and **Gcl.Tcl.**

> ***ITclApplication***<br>
> ***ITclTaskManager***<br>
> ***ITclTask***<br>

- **[SWRS#018]** ***ITclApplication*** shall define event handlers below, those shall be implemented by **UA.NET** to do something, e.g., update UI controls on it, etc, when events, e.g., *evtTclTaskStarted*, *evtTclTaskProgressChanged*, *evtTclTaskTerminated*, *evtTclAsserted*, are invoked by **Gcl.Tcl.TaskManager**.

> *vidHandleTclStarted*<br>
> *vidHandleTclProgressChanged*<br>
> *vidHandleTclTerminated*<br>
> *vidHandleTclAsserted*<br>

- **[SWRS#019]** These event handlers shall be handed over to **Gcl.Tcl.TaskManager** as method arguments, i.e., **TclRegisterArgs**, through *s32TclRegister* defined in ***Gcl.Tcl.ITaskManager***.

- **[SWRS#020]** ***ITclTaskManager*** shall define events below, those shall be invoked by **Gcl.Tcl.TaskManager**.

> *evtTclStarted*<br>
> *evtTclProgressChanged*<br>
> *evtTclTerminated*<br>
> *evtTclAsserted*<br>

- **[SWRS#021]** **Gcl.Tcl.TaskManager** shall implement these events and invoke them to **UA.NET** as needed.
- **[SWRS#022]** The *evtTclStarted* shall be invoked when any of **Gcl.Tcl.Task** registered is started, e.g., *evtTaskEntry* is invoked, etc.
- **[SWRS#023]** The *evtTclProgressChanged* shall be invoked when any of **Gcl.Tcl.Task** registered reports progress, e.g., *evtTaskProgressChanged* is invoked, etc.
- **[SWRS#024]** The *evtTclTerminated* shall be invoked when any of **Gcl.Tcl.Task** registered is terminated, e.g., *evtTaskExit* is invoked, etc.
- **[SWRS#025]** The *evtTclAsserted* shall be invoked when there is something to assert to **UA.NET**, e.g. error, exception, warning, log, etc.
- **[SWRS#026]** **Gcl.Tcl.TaskManager** shall aggregate events, i.e., invoked by **Gcl.Tcl.Task** registered, and invoke these events to **UA.NET** as needed.
- **[SWRS#027]** ***ITclManager*** shall define event handlers below and those shall be implemented by **Gcl.Tcl.TaskManager**.

> *vidHandleTaskEntry*<br>
> *vidHandleTaskProgressChanged*<br>
> *vidHandleTaskExit*<br>
> *vidHandleTaskAsserted*<br>

- **[SWRS#028]** ***ITclManager*** shall define methods below, those shall be implemented by **Gcl.Tcl.TaskManager** to provide task features for **UA.NET**.

> *s32Register*<br>
> *vidStart*<br>
> *vidPause*<br>
> *vidResume*<br>
> *vidStop*<br>
> *enuGetStatus*<br>
> *vidDeregister*<br>

- **[SWRS#029]** ***ITclTask*** shall define events below, those shall be invoked by **Gcl.Tcl.Task\*.**, e.g., **Gcl.Tcl.TaskTemplate**.

> *evtTaskEntry*<br>
> *evtTaskProgressChanged*<br>
> *evtTaskExit*<br>
> *evtTaskAsserted*<br>

- **[SWRS#030]** **Gcl.Tcl.Task** shall implement these events and invoke them to **Gcl.Tcl.TaskManager** as needed.
- **[SWRS#031]** The *evtTaskEntry* shall be invoked when **Gcl.Tcl.Task\*.** is started.
- **[SWRS#032]** The *evtTaskProgressChanged* shall be invoked  when **Gcl.Tcl.Task\*.** reports progress.
- **[SWRS#033]** The *evtTaskExit* shall be invoked when **Gcl.Tcl.Task\*.** exits.
- **[SWRS#034]** The *evtTaskAsserted* shall be invoked when there is something to assert to **Gcl.Tcl.TaskManager**, e.g. error, exception, warning, log, etc.
- **[SWRS#035]** ***ITclTask*** shall define methods below, those shall be implemented by **Gcl.Tcl.Task** to provide task features for **Gcl.Tcl.TaskManager**.

> *vidTaskStart*<br>
> *vidTaskPause*<br>
> *vidTaskResume*<br>
> *vidTaskStop*<br>
> *enuTaskGetStatus*<br>
</details>

<div id="2_1_3_gcl_tcl_class"></div>
<details open>
<summary><font size="5"><b>2.1.3 Gcl.Tcl Class</b></font></summary>

- [TOC](#toc)
- **[SWRS#036]** **Gcl.Tcl** shall define classes to hand over arguments on each methods defined in it.
- **[SWRS#037]** **Gcl.Tcl** shall define event handler arguments below for each method defined in ***ITclTaskManager*** and ***ITclTask***.
  
> **EventTclStartedArgs**<br>
> **EventTclProgressChangedArgs**<br>
> **EventTclTerminatedArgs**<br>
> **EventTclAssertedArgs**<br>
> **EventTaskEntryArgs**<br>
> **EventTaskProgressChangedArgs**<br>
> **EventTaskExitArgs**<br>
> **EventTaskAssertedArgs**<br>

- **[SWRS#038]** **Gcl.Tcl** shall define method arguments for **UA.NET** and **Gcl.Tcl.TaskManager** shall be able to hand over arguments to **Gcl.Tcl.TaskManager** and **Gcl.Tcl.Task**.

> **TclRegisterArgs**<br>
> **TclStartArgs**<br>
> **TclPauseArgs**<br>
> **TclResumeArgs**<br>
> **TclStopArgs**<br>
> **TclGetStatusArgs**<br>
> **TclDeregisterArgs**<br>
> **TaskStartArgs**<br>
> **TaskPauseArgs**<br>
> **TaskResumeArgs**<br>
> **TaskStopArgs**<br>
> **TaskGetStatusArgs**<br>
</details>
</details>

<div id="2_2_gcl_sul"></div>
<details open>
<summary><font size="5"><b>2.2. Gcl.Sul</b></font></summary>

- [TOC](#toc)
- **[SWRS#039]** ***Gcl.Sul*** is a static class library utility for general purpose.
- **[SWRS#040]** It should be coherent that ***Gcl.Sul*** shall be managed as a sub module.

<div id="2_2_1_gcl_sul_xml"></div>
<details open>
<summary><font size="5"><b>2.2.1. Gcl.Sul.Xml</b></font></summary>

- [TOC](#toc)
- **[SWRS#041]** ***Gcl.Sul.Xml*** is a static class library utility for xml processing.
- **[SWRS#042]** ***Gcl.Sul.Xml*** shall provide static methods below.
> *lstGetElementsByName*<br>
> *attrGetAttributeByName*<br>
</details>
</details>

<div id="2_3_gcl_sul_wpf"></div>
<details open>
<summary><font size="5"><b>2.3. Gcl.Sul.Wpf</b></font></summary>

- [TOC](#toc)
- **[SWRS#043]** ***Gcl.Sul.Wpf*** is a static class library utility for WPF feature.
- **[SWRS#044]** It should be coherent that ***Gcl.Sul.Wpf*** shall be managed as a sub module.

<div id="2_3_1_gcl_sul_wpf_ui"></div>
<details open>
<summary><font size="5"><b>2.3.1. Gcl.Sul.Wpf.UI</b></font></summary>

- [TOC](#toc)
- **[SWRS#045]** ***Gcl.Sul.Wpf.UI*** is a static class library utility for WPF user interface.
- **[SWRS#046]** ***Gcl.Sul.Wpf.UI*** shall provide static methods below.
> *vidUpdateRichTextBox*<br>
</details>
</details>
</details>

<div id="3_reference"></div>
<details open>
<summary><font size="5"><b>3. Reference</b></font></summary>

- [TOC](#toc)


</details>

Copyleft 2024 Gtuja. All right reversed.