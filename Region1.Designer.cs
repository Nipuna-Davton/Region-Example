namespace Region
{
    partial class Region1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
  
  
        /// <summary>
        /// Clean uppreparation[n++] = " any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
  
        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetSubject = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.searchBox1 = new Region.UserControll.SearchBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetSubject
            // 
            this.btnGetSubject.Location = new System.Drawing.Point(13, 31);
            this.btnGetSubject.Name = "btnGetSubject";
            this.btnGetSubject.Size = new System.Drawing.Size(75, 23);
            this.btnGetSubject.TabIndex = 0;
            this.btnGetSubject.Text = "Get Title";
            this.btnGetSubject.UseVisualStyleBackColor = true;
            this.btnGetSubject.Visible = false;
            this.btnGetSubject.Click += new System.EventHandler(this.btn_subject_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(143, 36);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(0, 13);
            this.lblSubject.TabIndex = 1;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(222, 36);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(0, 13);
            this.lblStartTime.TabIndex = 3;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(222, 58);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(0, 13);
            this.lblEndTime.TabIndex = 4;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(222, 78);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 13);
            this.lblLocation.TabIndex = 5;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.searchBox1);
            this.pnlMain.Location = new System.Drawing.Point(7, 177);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(758, 118);
            this.pnlMain.TabIndex = 6;
            // 
            // searchBox1
            // 
            this.searchBox1.Location = new System.Drawing.Point(33, 3);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(631, 100);
            this.searchBox1.TabIndex = 0;
            // 
            // Region1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 304);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnGetSubject);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Region1";
            this.Text = "Region1";
            this.ADXAfterFormHide += new AddinExpress.OL.ADXOlForm.ADXAfterFormHideEventHandler(this.Region1_ADXAfterFormHide);
            this.Load += new System.EventHandler(this.Region1_Load);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnGetSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Panel pnlMain;
        private UserControll.SearchBox searchBox1;
    }
}
