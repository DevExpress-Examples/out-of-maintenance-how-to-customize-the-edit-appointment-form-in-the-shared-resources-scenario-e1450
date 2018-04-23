Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.XtraScheduler
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports System.Drawing
Imports System.Data.SqlClient

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Private lastInsertedAppointmentId As Integer



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Protected Sub ASPxScheduler1_AppointmentRowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxScheduler.ASPxSchedulerDataInsertingEventArgs)
        e.NewValues.Remove("ID")

    End Sub

    Protected Sub ASPxScheduler1_AppointmentRowInserted(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxScheduler.ASPxSchedulerDataInsertedEventArgs)
        e.KeyFieldValue = Me.lastInsertedAppointmentId

    End Sub
    Protected Sub ASPxScheduler1_AppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
        Dim count As Integer = e.Objects.Count
        'System.Diagnostics.Debug.Assert(count == 1);
        Dim apt As Appointment = CType(e.Objects(0), Appointment)
        Dim storage As ASPxSchedulerStorage = DirectCast(sender, ASPxSchedulerStorage)
        storage.SetAppointmentId(apt, lastInsertedAppointmentId)
    End Sub

    Protected Sub CarsSchedulingDataSource_Inserted(ByVal sender As Object, ByVal e As SqlDataSourceStatusEventArgs)
        Dim connection As SqlConnection = CType(e.Command.Connection, SqlConnection)
        Using cmd As New SqlCommand("SELECT IDENT_CURRENT('CarScheduling')", connection)
            Me.lastInsertedAppointmentId = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Sub
    Protected Sub ASPxScheduler1_BeforeExecuteCallbackCommand(ByVal sender As Object, ByVal e As SchedulerCallbackCommandEventArgs)
        If e.CommandId = SchedulerCallbackCommandId.AppointmentSave Then
            e.Command = New MyAppointmentSaveCallbackCommand(DirectCast(sender, ASPxScheduler))
        End If

    End Sub
End Class

