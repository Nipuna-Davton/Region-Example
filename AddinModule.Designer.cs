namespace Region
{
    partial class AddinModule
    {
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.adxOlFormsManager1 = new AddinExpress.OL.ADXOlFormsManager(this.components);
            this.adxOlFormsCollectionGetAppointmentDetails = new AddinExpress.OL.ADXOlFormsCollectionItem(this.components);
            this.rbnDetectTitleTab = new AddinExpress.MSO.ADXRibbonTab(this.components);
            this.rbnGroupDetectTitle = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.rbnBtnGetDetails = new AddinExpress.MSO.ADXRibbonButton(this.components);
            this.rbnSeparatorSubjectButton = new AddinExpress.MSO.ADXRibbonSeparator(this.components);
            this.rbnLblTitle = new AddinExpress.MSO.ADXRibbonLabel(this.components);
            this.rbnLblStartTime = new AddinExpress.MSO.ADXRibbonLabel(this.components);
            this.rbnLblEndTime = new AddinExpress.MSO.ADXRibbonLabel(this.components);
            this.rbnSeparatorLables = new AddinExpress.MSO.ADXRibbonSeparator(this.components);
            this.rbnLblLocation = new AddinExpress.MSO.ADXRibbonLabel(this.components);
            // 
            // adxOlFormsManager1
            // 
            this.adxOlFormsManager1.Items.Add(this.adxOlFormsCollectionGetAppointmentDetails);
            this.adxOlFormsManager1.ADXNewInspector += new AddinExpress.OL.ADXOlFormsManager.NewInspector_EventHandler(this.adxOlFormsManager1_ADXNewInspector);
            this.adxOlFormsManager1.SetOwner(this);
            // 
            // adxOlFormsCollectionGetAppointmentDetails
            // 
            this.adxOlFormsCollectionGetAppointmentDetails.AlwaysShowHeader = true;
            this.adxOlFormsCollectionGetAppointmentDetails.CloseButton = true;
            this.adxOlFormsCollectionGetAppointmentDetails.FormClassName = "Region.Region1";
            this.adxOlFormsCollectionGetAppointmentDetails.InspectorItemTypes = AddinExpress.OL.ADXOlInspectorItemTypes.olAppointment;
            this.adxOlFormsCollectionGetAppointmentDetails.InspectorLayout = AddinExpress.OL.ADXOlInspectorLayout.BottomSubpane;
            // 
            // rbnDetectTitleTab
            // 
            this.rbnDetectTitleTab.Caption = "Detect Title";
            this.rbnDetectTitleTab.Controls.Add(this.rbnGroupDetectTitle);
            this.rbnDetectTitleTab.Id = "adxRibbonTab_76a1ff2675d348d8b3c51147aa5e1a13";
            this.rbnDetectTitleTab.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookAppointment;
            // 
            // rbnGroupDetectTitle
            // 
            this.rbnGroupDetectTitle.Controls.Add(this.rbnBtnGetDetails);
            this.rbnGroupDetectTitle.Controls.Add(this.rbnSeparatorSubjectButton);
            this.rbnGroupDetectTitle.Controls.Add(this.rbnLblTitle);
            this.rbnGroupDetectTitle.Controls.Add(this.rbnLblStartTime);
            this.rbnGroupDetectTitle.Controls.Add(this.rbnLblEndTime);
            this.rbnGroupDetectTitle.Controls.Add(this.rbnSeparatorLables);
            this.rbnGroupDetectTitle.Controls.Add(this.rbnLblLocation);
            this.rbnGroupDetectTitle.Id = "adxRibbonGroup_b534315a4ddb4cba8118c8c1b9ea2c8a";
            this.rbnGroupDetectTitle.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.rbnGroupDetectTitle.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookAppointment;
            // 
            // rbnBtnGetDetails
            // 
            this.rbnBtnGetDetails.Caption = "Get Appointment Details";
            this.rbnBtnGetDetails.Id = "adxRibbonButton_66ff8f7c05cd484b8a3394886cba3366";
            this.rbnBtnGetDetails.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.rbnBtnGetDetails.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookAppointment;
            this.rbnBtnGetDetails.Size = AddinExpress.MSO.ADXRibbonXControlSize.Large;
            this.rbnBtnGetDetails.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxRibbonButton1_OnClick);
            // 
            // rbnSeparatorSubjectButton
            // 
            this.rbnSeparatorSubjectButton.Id = "adxRibbonSeparator_f89d857f38504d81a74c1c6bec318744";
            this.rbnSeparatorSubjectButton.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookAppointment;
            // 
            // rbnLblTitle
            // 
            this.rbnLblTitle.Id = "adxRibbonLabel_c552f17d69a64c68b86edea896f99185";
            this.rbnLblTitle.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookAppointment;
            // 
            // rbnLblStartTime
            // 
            this.rbnLblStartTime.Id = "adxRibbonLabel_f5ead49430324a2e865d45d6b74c9803";
            this.rbnLblStartTime.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookAppointment;
            // 
            // rbnLblEndTime
            // 
            this.rbnLblEndTime.Id = "adxRibbonLabel_4069b2d6d5074142a464a02da04799fd";
            this.rbnLblEndTime.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookAppointment;
            // 
            // rbnSeparatorLables
            // 
            this.rbnSeparatorLables.Id = "adxRibbonSeparator_52e6f88b49124e95be8bb4d6bf13727e";
            this.rbnSeparatorLables.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookAppointment;
            // 
            // rbnLblLocation
            // 
            this.rbnLblLocation.Id = "adxRibbonLabel_b36f7214b8a24fc8932f97129921778b";
            this.rbnLblLocation.Ribbons = AddinExpress.MSO.ADXRibbons.msrOutlookAppointment;
            // 
            // AddinModule
            // 
            this.AddinName = "Region";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaOutlook;

        }
        #endregion

        private AddinExpress.OL.ADXOlFormsManager adxOlFormsManager1;
        private AddinExpress.MSO.ADXRibbonTab rbnDetectTitleTab;
        private AddinExpress.MSO.ADXRibbonGroup rbnGroupDetectTitle;
        private AddinExpress.MSO.ADXRibbonButton rbnBtnGetDetails;
        private AddinExpress.MSO.ADXRibbonLabel rbnLblTitle;
        private AddinExpress.MSO.ADXRibbonSeparator rbnSeparatorSubjectButton;
        private AddinExpress.MSO.ADXRibbonLabel rbnLblStartTime;
        private AddinExpress.MSO.ADXRibbonLabel rbnLblEndTime;
        private AddinExpress.MSO.ADXRibbonLabel rbnLblLocation;
        private AddinExpress.MSO.ADXRibbonSeparator rbnSeparatorLables;
        private AddinExpress.OL.ADXOlFormsCollectionItem adxOlFormsCollectionGetAppointmentDetails;
    }
}

