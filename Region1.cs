using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AddinExpress.OL;
  
namespace Region
{
    public partial class Region1 : AddinExpress.OL.ADXOlForm
    {
        public Region1()
        {
            InitializeComponent();
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            var inspectorObj = (Outlook.Inspector)this.InspectorObj;
            try
            {
                

             
                if (inspectorObj!=null)
                {
                    var appointmentObj = (Outlook.AppointmentItem)inspectorObj.CurrentItem;
                    lblSubject.Text = appointmentObj.Subject;

                }

            }
            catch (Exception ex)
            {

                lblSubject.Text = ex.Message;
            }
            finally
            {
              
            }
          
        }

        public void SetLableValues()
        {
            try
            {
                var inspectorObj = (Outlook.Inspector)this.InspectorObj;
                var appointmentObj = (Outlook.AppointmentItem)inspectorObj.CurrentItem;
                lblSubject.Text = "Title :-" + appointmentObj.Subject;
                lblStartTime.Text = " Start Time:- " + appointmentObj.Start.ToString();
                lblEndTime.Text= " End Time:- " + appointmentObj.End.ToString();
                lblLocation.Text = " Location:- " + appointmentObj.Location;
            }
            catch (Exception ex)
            {

                lblSubject.Text = ex.Message;
            }
          

           
        }

        private void Region1_ADXAfterFormHide(object sender, ADXAfterFormHideEventArgs e)
        {
            try
            {
                AddinModule regionModule = AddinExpress.MSO.ADXAddinModule.CurrentInstance as AddinModule;
                regionModule.ClearRibbonLables();
                if (Marshal.IsComObject(regionModule))
                    Marshal.ReleaseComObject(regionModule);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Region1_Load(object sender, EventArgs e)
        {

        }
    }
}
