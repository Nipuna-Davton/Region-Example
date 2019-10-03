using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using AddinExpress.MSO;
using AddinExpress.OL;

namespace Region
{
    /// <summary>
    ///   Add-in Express Add-in Module
    /// </summary>
    [GuidAttribute("851A10B7-46F0-4F8E-9058-1459336D167F"), ProgId("Region.AddinModule")]
    public partial class AddinModule : AddinExpress.MSO.ADXAddinModule
    {
        public AddinModule()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            // Please add any initialization code to the AddinInitialize event handler
        }
 
        #region Add-in Express automatic code
 
        // Required by Add-in Express - do not modify
        // the methods within this region
 
        public override System.ComponentModel.IContainer GetContainer()
        {
            if (components == null)
                components = new System.ComponentModel.Container();
            return components;
        }
 
        [ComRegisterFunctionAttribute]
        public static void AddinRegister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXRegister(t);
        }
 
        [ComUnregisterFunctionAttribute]
        public static void AddinUnregister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXUnregister(t);
        }
 
        public override void UninstallControls()
        {
            base.UninstallControls();
        }

        #endregion

        public static new AddinModule CurrentInstance 
        {
            get
            {
                return AddinExpress.MSO.ADXAddinModule.CurrentInstance as AddinModule;
            }
        }

        public Outlook._Application OutlookApp
        {
            get
            {
                return (HostApplication as Outlook._Application);
            }
        }

        [Obsolete]
        private void adxRibbonButton1_OnClick(object sender, IRibbonControl control, bool pressed)
        {
            var inspectorObj = OutlookApp.Application.ActiveInspector();
            try
            {


              
                if (inspectorObj != null)
                {
                    var appointmentObj = (Outlook.AppointmentItem)inspectorObj.CurrentItem;
                    rbnLblTitle.Caption = "Title :-"+appointmentObj.Subject;
                    rbnLblStartTime.Caption = "Start Time:- " + appointmentObj.Start.ToString();
                    rbnLblEndTime.Caption = "End Time:- " + appointmentObj.End.ToString();
                    rbnLblLocation.Caption = "Location:- " + appointmentObj.Location;

                    Region1 appointmentFormObj = (Region1)adxOlFormsCollectionGetAppointmentDetails.GetCurrentForm(EmbeddedFormStates.Visible);
                    if (appointmentFormObj!=null)
                    {
                        appointmentFormObj.SetLableValues();
                        if (Marshal.IsComObject(appointmentFormObj))
                        {
                            Marshal.ReleaseComObject(appointmentFormObj);
                        }
                    }

                }

                

            }
            catch (Exception ex)
            {

                rbnLblTitle.Caption = ex.Message;
            }
            finally
            {
                if (Marshal.IsComObject(inspectorObj))
                {
                     Marshal.ReleaseComObject(inspectorObj);
                }
                    
            }
           
        }

        public void ClearRibbonLables()
        {
            
            rbnLblTitle.Caption = "";
            rbnLblStartTime.Caption = "";
            rbnLblEndTime.Caption = "";
            rbnLblLocation.Caption = "";
        }

        private void adxOlFormsManager1_ADXNewInspector(object inspectorObj)
        {
            ClearRibbonLables();
        }
    }
}

