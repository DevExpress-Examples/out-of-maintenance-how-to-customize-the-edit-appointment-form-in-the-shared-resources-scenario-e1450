# How to customize the Edit Appointment Form in the "Shared Resources" scenario


<p>This example illustrates how the appointment editing form with multiple resources selection can be implemented in a project with ASPxScheduler control bound to SQL Server.</p><p>The CarsXtraScheduling.sql file contains the data table script used to create a sample data table at the SQL server.</p><p>To switch the scheduler to multi-resource mode, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerAppointmentStorageBase_ResourceSharingtopic">ResourceSharing</a> property is set to true. A custom appointment editing form is implemented and the appointment field mapping for the ResourceIds property is specified.</p><p>Note: starting from the v2009 vol.2 release the standard appointment form contains an ASPxListBox control which provides the required functionality for assigning multiple resources. <br />
For ASPxScheduler releases prior 9.2, the following workaround is used.<br />
A custom appointment editing form contains a data-bound control with multiple selection capability. The control is based on a combination of <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxEditorsASPxCheckBoxtopic">ASPxCheckBox</a> and <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxHiddenFieldASPxHiddenFieldtopic">ASPxHiddenField</a> controls, enclosed into a <a href="http://msdn.microsoft.com/en-us/library/system.web.ui.webcontrols.repeater.aspx">Repeater</a> control template.</p>

<br/>


