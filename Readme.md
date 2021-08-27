<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1450)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [UserAppointmentFormClass.cs](./CS/WebSite/App_Code/UserAppointmentFormClass.cs) (VB: [UserAppointmentFormClass.vb](./VB/WebSite/App_Code/UserAppointmentFormClass.vb))
* [UserAppointmentForm.ascx](./CS/WebSite/MyForms/UserAppointmentForm.ascx) (VB: [UserAppointmentForm.ascx](./VB/WebSite/MyForms/UserAppointmentForm.ascx))
* [UserAppointmentForm.ascx.cs](./CS/WebSite/MyForms/UserAppointmentForm.ascx.cs) (VB: [UserAppointmentForm.ascx.vb](./VB/WebSite/MyForms/UserAppointmentForm.ascx.vb))
<!-- default file list end -->
# How to customize the Edit Appointment Form in the "Shared Resources" scenario


<p>This example illustrates how the appointment editing form with multiple resources selection can be implemented in a project with ASPxScheduler control bound to SQL Server.</p><p>The CarsXtraScheduling.sql file contains the data table script used to create a sample data table at the SQL server.</p><p>To switch the scheduler to multi-resource mode, the <a href="https://documentation.devexpress.com/AspNet/3813/ASP-NET-WebForms-Controls/Scheduler/Concepts/Resources/Assigning-Appointments-to-Resources">ResourceSharing</a> property is set to true. A custom appointment editing form is implemented and the appointment field mapping for the ResourceIds property is specified.</p><p>Note: starting from the v2009 vol.2 release the standard appointment form contains an ASPxListBox control which provides the required functionality for assigning multiple resources. <br />
For ASPxScheduler releases prior 9.2, the following workaround is used.<br />
A custom appointment editing form contains a data-bound control with multiple selection capability. The control is based on a combination of <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxEditorsASPxCheckBoxtopic">ASPxCheckBox</a> and <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxHiddenFieldASPxHiddenFieldtopic">ASPxHiddenField</a> controls, enclosed into a <a href="http://msdn.microsoft.com/en-us/library/system.web.ui.webcontrols.repeater.aspx">Repeater</a> control template.</p>

<br/>


