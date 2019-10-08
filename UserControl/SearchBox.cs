using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Region.UserControll
{
    public partial class SearchBox : UserControl
    {
        public SearchBox()
        {
            InitializeComponent();
        }

        private void btnGetSearch_Click(object sender, EventArgs e)
        {
            AddinModule regionModule = AddinExpress.MSO.ADXAddinModule.CurrentInstance as AddinModule;
            var outlookApp = (Outlook.Application)regionModule.HostApplication;
            var currentFolder = outlookApp.Application.ActiveExplorer().CurrentFolder;
            Uri uri = new Uri("http://schemas.microsoft.com/mapi/proptag/");
            var searchKey = "@SQL=" + uri.ToString() + "0x0037001E like '%" + txtSearch.Text.Trim() + "%'";
            try
            {
                var results = currentFolder.Items.Restrict(searchKey);

                for (int i = 1; i <= results.Count; i++)
                {
                    var appointments = (Outlook.AppointmentItem)results.Item(i);
                    MessageBox.Show(appointments.Location);

                    if (Marshal.IsComObject(appointments))
                    {
                        var status = Marshal.ReleaseComObject(appointments);
                    }
                }
               
              

                if (Marshal.IsComObject(results))
                    Marshal.ReleaseComObject(results);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //outlookApp.
            //;
            //var currentOutlookApp =regionModule.OutlookApp.Application;
            //var scope = "";
            //scope = "'" + currentFolder + "'";
            //var result=currentOutlookApp.ad
            


           

            if (Marshal.IsComObject(currentFolder))
                Marshal.ReleaseComObject(currentFolder);

            if (Marshal.IsComObject(currentFolder))
                Marshal.ReleaseComObject(currentFolder);

            if (Marshal.IsComObject(outlookApp))
                Marshal.ReleaseComObject(outlookApp);

            if (Marshal.IsComObject(regionModule))
                Marshal.ReleaseComObject(regionModule);

        }
    }
}
