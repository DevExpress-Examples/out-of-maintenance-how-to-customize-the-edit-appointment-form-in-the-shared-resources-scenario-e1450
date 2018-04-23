using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.XtraScheduler;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using System.Drawing;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page {
	int lastInsertedAppointmentId;



	protected void Page_Load(object sender, EventArgs e) {
	}	

	protected void ASPxScheduler1_AppointmentRowInserting(object sender, DevExpress.Web.ASPxScheduler.ASPxSchedulerDataInsertingEventArgs e) {
		e.NewValues.Remove("ID");

	}

	protected void ASPxScheduler1_AppointmentRowInserted(object sender, DevExpress.Web.ASPxScheduler.ASPxSchedulerDataInsertedEventArgs e) {
		e.KeyFieldValue = this.lastInsertedAppointmentId;

	}
	protected void ASPxScheduler1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e) {
		int count = e.Objects.Count;
		//System.Diagnostics.Debug.Assert(count == 1);
		Appointment apt = (Appointment)e.Objects[0];
		ASPxSchedulerStorage storage = (ASPxSchedulerStorage)sender;
		storage.SetAppointmentId(apt, lastInsertedAppointmentId);
	}

	protected void CarsSchedulingDataSource_Inserted(object sender, SqlDataSourceStatusEventArgs e) {
		SqlConnection connection = (SqlConnection)e.Command.Connection;
		using (SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('CarScheduling')", connection)) {			
			this.lastInsertedAppointmentId = Convert.ToInt32(cmd.ExecuteScalar());
		}
	}
    protected void ASPxScheduler1_BeforeExecuteCallbackCommand(object sender, SchedulerCallbackCommandEventArgs e) {
        if(e.CommandId == SchedulerCallbackCommandId.AppointmentSave) {
            e.Command = new MyAppointmentSaveCallbackCommand((ASPxScheduler)sender);
        }

    }
}

