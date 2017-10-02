namespace DatabasePrototype {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelCreateNewFirstName = new System.Windows.Forms.Label();
            this.labelCreateNewLastName = new System.Windows.Forms.Label();
            this.labelCreateNewAge = new System.Windows.Forms.Label();
            this.labelCreateNewWorkPlace = new System.Windows.Forms.Label();
            this.labelCreateNewHomeAddress = new System.Windows.Forms.Label();
            this.panelCreateNew = new System.Windows.Forms.Panel();
            this.labelCreateCitizen = new System.Windows.Forms.Label();
            this.buttonCreateNewSubmit = new System.Windows.Forms.Button();
            this.textBoxCreateNewYCord = new System.Windows.Forms.TextBox();
            this.textBoxCreateNewXCord = new System.Windows.Forms.TextBox();
            this.textBoxCreateNewWorkPlace = new System.Windows.Forms.TextBox();
            this.textBoxCreateNewAge = new System.Windows.Forms.TextBox();
            this.textBoxCreateNewLastName = new System.Windows.Forms.TextBox();
            this.textBoxCreateNewFirstName = new System.Windows.Forms.TextBox();
            this.panelChange = new System.Windows.Forms.Panel();
            this.labelSelectedCitizen = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxChangeYCord = new System.Windows.Forms.TextBox();
            this.textBoxChangeXCord = new System.Windows.Forms.TextBox();
            this.textBoxChangeWorkPlace = new System.Windows.Forms.TextBox();
            this.textBoxChangeAge = new System.Windows.Forms.TextBox();
            this.textBoxChangeLastName = new System.Windows.Forms.TextBox();
            this.textBoxChangeFirstName = new System.Windows.Forms.TextBox();
            this.labelChangeFirstName = new System.Windows.Forms.Label();
            this.labelChangeHomeAddress = new System.Windows.Forms.Label();
            this.labelChangeLastName = new System.Windows.Forms.Label();
            this.labelChangeWorkPlace = new System.Windows.Forms.Label();
            this.labelChangeAge = new System.Windows.Forms.Label();
            this.panelDb = new System.Windows.Forms.Panel();
            this.listBoxCitizenList = new System.Windows.Forms.ListBox();
            this.buttonRefreshDb = new System.Windows.Forms.Button();
            this.panelCreateNew.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.panelDb.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCreateNewFirstName
            // 
            this.labelCreateNewFirstName.AutoSize = true;
            this.labelCreateNewFirstName.Location = new System.Drawing.Point(46, 90);
            this.labelCreateNewFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreateNewFirstName.Name = "labelCreateNewFirstName";
            this.labelCreateNewFirstName.Size = new System.Drawing.Size(122, 25);
            this.labelCreateNewFirstName.TabIndex = 0;
            this.labelCreateNewFirstName.Text = "First Name:";
            // 
            // labelCreateNewLastName
            // 
            this.labelCreateNewLastName.AutoSize = true;
            this.labelCreateNewLastName.Location = new System.Drawing.Point(46, 135);
            this.labelCreateNewLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreateNewLastName.Name = "labelCreateNewLastName";
            this.labelCreateNewLastName.Size = new System.Drawing.Size(121, 25);
            this.labelCreateNewLastName.TabIndex = 1;
            this.labelCreateNewLastName.Text = "Last Name:";
            // 
            // labelCreateNewAge
            // 
            this.labelCreateNewAge.AutoSize = true;
            this.labelCreateNewAge.Location = new System.Drawing.Point(46, 185);
            this.labelCreateNewAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreateNewAge.Name = "labelCreateNewAge";
            this.labelCreateNewAge.Size = new System.Drawing.Size(56, 25);
            this.labelCreateNewAge.TabIndex = 2;
            this.labelCreateNewAge.Text = "Age:";
            // 
            // labelCreateNewWorkPlace
            // 
            this.labelCreateNewWorkPlace.AutoSize = true;
            this.labelCreateNewWorkPlace.Location = new System.Drawing.Point(46, 231);
            this.labelCreateNewWorkPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreateNewWorkPlace.Name = "labelCreateNewWorkPlace";
            this.labelCreateNewWorkPlace.Size = new System.Drawing.Size(128, 25);
            this.labelCreateNewWorkPlace.TabIndex = 3;
            this.labelCreateNewWorkPlace.Text = "Work Place:";
            // 
            // labelCreateNewHomeAddress
            // 
            this.labelCreateNewHomeAddress.AutoSize = true;
            this.labelCreateNewHomeAddress.Location = new System.Drawing.Point(46, 277);
            this.labelCreateNewHomeAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreateNewHomeAddress.Name = "labelCreateNewHomeAddress";
            this.labelCreateNewHomeAddress.Size = new System.Drawing.Size(214, 25);
            this.labelCreateNewHomeAddress.TabIndex = 4;
            this.labelCreateNewHomeAddress.Text = "Home Address (X,Y):";
            // 
            // panelCreateNew
            // 
            this.panelCreateNew.Controls.Add(this.labelCreateCitizen);
            this.panelCreateNew.Controls.Add(this.buttonCreateNewSubmit);
            this.panelCreateNew.Controls.Add(this.textBoxCreateNewYCord);
            this.panelCreateNew.Controls.Add(this.textBoxCreateNewXCord);
            this.panelCreateNew.Controls.Add(this.textBoxCreateNewWorkPlace);
            this.panelCreateNew.Controls.Add(this.textBoxCreateNewAge);
            this.panelCreateNew.Controls.Add(this.textBoxCreateNewLastName);
            this.panelCreateNew.Controls.Add(this.textBoxCreateNewFirstName);
            this.panelCreateNew.Controls.Add(this.labelCreateNewFirstName);
            this.panelCreateNew.Controls.Add(this.labelCreateNewHomeAddress);
            this.panelCreateNew.Controls.Add(this.labelCreateNewLastName);
            this.panelCreateNew.Controls.Add(this.labelCreateNewWorkPlace);
            this.panelCreateNew.Controls.Add(this.labelCreateNewAge);
            this.panelCreateNew.Location = new System.Drawing.Point(68, 37);
            this.panelCreateNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCreateNew.Name = "panelCreateNew";
            this.panelCreateNew.Size = new System.Drawing.Size(468, 423);
            this.panelCreateNew.TabIndex = 5;
            // 
            // labelCreateCitizen
            // 
            this.labelCreateCitizen.AutoSize = true;
            this.labelCreateCitizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateCitizen.Location = new System.Drawing.Point(26, 31);
            this.labelCreateCitizen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreateCitizen.Name = "labelCreateCitizen";
            this.labelCreateCitizen.Size = new System.Drawing.Size(280, 31);
            this.labelCreateCitizen.TabIndex = 6;
            this.labelCreateCitizen.Text = "Create a new citizen";
            // 
            // buttonCreateNewSubmit
            // 
            this.buttonCreateNewSubmit.Location = new System.Drawing.Point(310, 338);
            this.buttonCreateNewSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateNewSubmit.Name = "buttonCreateNewSubmit";
            this.buttonCreateNewSubmit.Size = new System.Drawing.Size(100, 50);
            this.buttonCreateNewSubmit.TabIndex = 11;
            this.buttonCreateNewSubmit.Text = "Submit";
            this.buttonCreateNewSubmit.UseVisualStyleBackColor = true;
            this.buttonCreateNewSubmit.Click += new System.EventHandler(this.buttonCreateNewSubmit_Click);
            // 
            // textBoxCreateNewYCord
            // 
            this.textBoxCreateNewYCord.Location = new System.Drawing.Point(346, 273);
            this.textBoxCreateNewYCord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCreateNewYCord.Name = "textBoxCreateNewYCord";
            this.textBoxCreateNewYCord.Size = new System.Drawing.Size(62, 31);
            this.textBoxCreateNewYCord.TabIndex = 10;
            // 
            // textBoxCreateNewXCord
            // 
            this.textBoxCreateNewXCord.Location = new System.Drawing.Point(266, 273);
            this.textBoxCreateNewXCord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCreateNewXCord.Name = "textBoxCreateNewXCord";
            this.textBoxCreateNewXCord.Size = new System.Drawing.Size(62, 31);
            this.textBoxCreateNewXCord.TabIndex = 9;
            // 
            // textBoxCreateNewWorkPlace
            // 
            this.textBoxCreateNewWorkPlace.Location = new System.Drawing.Point(190, 223);
            this.textBoxCreateNewWorkPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCreateNewWorkPlace.Name = "textBoxCreateNewWorkPlace";
            this.textBoxCreateNewWorkPlace.Size = new System.Drawing.Size(218, 31);
            this.textBoxCreateNewWorkPlace.TabIndex = 8;
            // 
            // textBoxCreateNewAge
            // 
            this.textBoxCreateNewAge.Location = new System.Drawing.Point(190, 177);
            this.textBoxCreateNewAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCreateNewAge.Name = "textBoxCreateNewAge";
            this.textBoxCreateNewAge.Size = new System.Drawing.Size(112, 31);
            this.textBoxCreateNewAge.TabIndex = 7;
            // 
            // textBoxCreateNewLastName
            // 
            this.textBoxCreateNewLastName.Location = new System.Drawing.Point(190, 127);
            this.textBoxCreateNewLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCreateNewLastName.Name = "textBoxCreateNewLastName";
            this.textBoxCreateNewLastName.Size = new System.Drawing.Size(218, 31);
            this.textBoxCreateNewLastName.TabIndex = 6;
            // 
            // textBoxCreateNewFirstName
            // 
            this.textBoxCreateNewFirstName.Location = new System.Drawing.Point(190, 83);
            this.textBoxCreateNewFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCreateNewFirstName.Name = "textBoxCreateNewFirstName";
            this.textBoxCreateNewFirstName.Size = new System.Drawing.Size(218, 31);
            this.textBoxCreateNewFirstName.TabIndex = 5;
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.labelSelectedCitizen);
            this.panelChange.Controls.Add(this.buttonChange);
            this.panelChange.Controls.Add(this.textBoxChangeYCord);
            this.panelChange.Controls.Add(this.textBoxChangeXCord);
            this.panelChange.Controls.Add(this.textBoxChangeWorkPlace);
            this.panelChange.Controls.Add(this.textBoxChangeAge);
            this.panelChange.Controls.Add(this.textBoxChangeLastName);
            this.panelChange.Controls.Add(this.textBoxChangeFirstName);
            this.panelChange.Controls.Add(this.labelChangeFirstName);
            this.panelChange.Controls.Add(this.labelChangeHomeAddress);
            this.panelChange.Controls.Add(this.labelChangeLastName);
            this.panelChange.Controls.Add(this.labelChangeWorkPlace);
            this.panelChange.Controls.Add(this.labelChangeAge);
            this.panelChange.Location = new System.Drawing.Point(560, 37);
            this.panelChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(468, 423);
            this.panelChange.TabIndex = 6;
            // 
            // labelSelectedCitizen
            // 
            this.labelSelectedCitizen.AutoSize = true;
            this.labelSelectedCitizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedCitizen.Location = new System.Drawing.Point(26, 31);
            this.labelSelectedCitizen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedCitizen.Name = "labelSelectedCitizen";
            this.labelSelectedCitizen.Size = new System.Drawing.Size(227, 31);
            this.labelSelectedCitizen.TabIndex = 6;
            this.labelSelectedCitizen.Text = "Selected Citizen";
            // 
            // buttonChange
            // 
            this.buttonChange.Enabled = false;
            this.buttonChange.Location = new System.Drawing.Point(294, 338);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(118, 50);
            this.buttonChange.TabIndex = 11;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxChangeYCord
            // 
            this.textBoxChangeYCord.Enabled = false;
            this.textBoxChangeYCord.Location = new System.Drawing.Point(346, 273);
            this.textBoxChangeYCord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxChangeYCord.Name = "textBoxChangeYCord";
            this.textBoxChangeYCord.Size = new System.Drawing.Size(62, 31);
            this.textBoxChangeYCord.TabIndex = 10;
            // 
            // textBoxChangeXCord
            // 
            this.textBoxChangeXCord.Enabled = false;
            this.textBoxChangeXCord.Location = new System.Drawing.Point(266, 273);
            this.textBoxChangeXCord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxChangeXCord.Name = "textBoxChangeXCord";
            this.textBoxChangeXCord.Size = new System.Drawing.Size(62, 31);
            this.textBoxChangeXCord.TabIndex = 9;
            // 
            // textBoxChangeWorkPlace
            // 
            this.textBoxChangeWorkPlace.Enabled = false;
            this.textBoxChangeWorkPlace.Location = new System.Drawing.Point(190, 223);
            this.textBoxChangeWorkPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxChangeWorkPlace.Name = "textBoxChangeWorkPlace";
            this.textBoxChangeWorkPlace.Size = new System.Drawing.Size(218, 31);
            this.textBoxChangeWorkPlace.TabIndex = 8;
            // 
            // textBoxChangeAge
            // 
            this.textBoxChangeAge.Enabled = false;
            this.textBoxChangeAge.Location = new System.Drawing.Point(190, 177);
            this.textBoxChangeAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxChangeAge.Name = "textBoxChangeAge";
            this.textBoxChangeAge.Size = new System.Drawing.Size(112, 31);
            this.textBoxChangeAge.TabIndex = 7;
            // 
            // textBoxChangeLastName
            // 
            this.textBoxChangeLastName.Enabled = false;
            this.textBoxChangeLastName.Location = new System.Drawing.Point(190, 127);
            this.textBoxChangeLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxChangeLastName.Name = "textBoxChangeLastName";
            this.textBoxChangeLastName.Size = new System.Drawing.Size(218, 31);
            this.textBoxChangeLastName.TabIndex = 6;
            // 
            // textBoxChangeFirstName
            // 
            this.textBoxChangeFirstName.Enabled = false;
            this.textBoxChangeFirstName.Location = new System.Drawing.Point(190, 83);
            this.textBoxChangeFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxChangeFirstName.Name = "textBoxChangeFirstName";
            this.textBoxChangeFirstName.Size = new System.Drawing.Size(218, 31);
            this.textBoxChangeFirstName.TabIndex = 5;
            // 
            // labelChangeFirstName
            // 
            this.labelChangeFirstName.AutoSize = true;
            this.labelChangeFirstName.Location = new System.Drawing.Point(46, 90);
            this.labelChangeFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChangeFirstName.Name = "labelChangeFirstName";
            this.labelChangeFirstName.Size = new System.Drawing.Size(122, 25);
            this.labelChangeFirstName.TabIndex = 0;
            this.labelChangeFirstName.Text = "First Name:";
            // 
            // labelChangeHomeAddress
            // 
            this.labelChangeHomeAddress.AutoSize = true;
            this.labelChangeHomeAddress.Location = new System.Drawing.Point(46, 277);
            this.labelChangeHomeAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChangeHomeAddress.Name = "labelChangeHomeAddress";
            this.labelChangeHomeAddress.Size = new System.Drawing.Size(214, 25);
            this.labelChangeHomeAddress.TabIndex = 4;
            this.labelChangeHomeAddress.Text = "Home Address (X,Y):";
            // 
            // labelChangeLastName
            // 
            this.labelChangeLastName.AutoSize = true;
            this.labelChangeLastName.Location = new System.Drawing.Point(46, 135);
            this.labelChangeLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChangeLastName.Name = "labelChangeLastName";
            this.labelChangeLastName.Size = new System.Drawing.Size(121, 25);
            this.labelChangeLastName.TabIndex = 1;
            this.labelChangeLastName.Text = "Last Name:";
            // 
            // labelChangeWorkPlace
            // 
            this.labelChangeWorkPlace.AutoSize = true;
            this.labelChangeWorkPlace.Location = new System.Drawing.Point(46, 231);
            this.labelChangeWorkPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChangeWorkPlace.Name = "labelChangeWorkPlace";
            this.labelChangeWorkPlace.Size = new System.Drawing.Size(128, 25);
            this.labelChangeWorkPlace.TabIndex = 3;
            this.labelChangeWorkPlace.Text = "Work Place:";
            // 
            // labelChangeAge
            // 
            this.labelChangeAge.AutoSize = true;
            this.labelChangeAge.Location = new System.Drawing.Point(46, 185);
            this.labelChangeAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChangeAge.Name = "labelChangeAge";
            this.labelChangeAge.Size = new System.Drawing.Size(56, 25);
            this.labelChangeAge.TabIndex = 2;
            this.labelChangeAge.Text = "Age:";
            // 
            // panelDb
            // 
            this.panelDb.Controls.Add(this.listBoxCitizenList);
            this.panelDb.Controls.Add(this.buttonRefreshDb);
            this.panelDb.Location = new System.Drawing.Point(68, 512);
            this.panelDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDb.Name = "panelDb";
            this.panelDb.Size = new System.Drawing.Size(960, 327);
            this.panelDb.TabIndex = 7;
            // 
            // listBoxCitizenList
            // 
            this.listBoxCitizenList.FormattingEnabled = true;
            this.listBoxCitizenList.ItemHeight = 25;
            this.listBoxCitizenList.Location = new System.Drawing.Point(366, 44);
            this.listBoxCitizenList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCitizenList.Name = "listBoxCitizenList";
            this.listBoxCitizenList.Size = new System.Drawing.Size(534, 254);
            this.listBoxCitizenList.TabIndex = 1;
            this.listBoxCitizenList.SelectedIndexChanged += new System.EventHandler(this.listBoxCitizenList_SelectedIndexChanged);
            // 
            // buttonRefreshDb
            // 
            this.buttonRefreshDb.Location = new System.Drawing.Point(62, 123);
            this.buttonRefreshDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefreshDb.Name = "buttonRefreshDb";
            this.buttonRefreshDb.Size = new System.Drawing.Size(196, 79);
            this.buttonRefreshDb.TabIndex = 0;
            this.buttonRefreshDb.Text = "Refresh DB";
            this.buttonRefreshDb.UseVisualStyleBackColor = true;
            this.buttonRefreshDb.Click += new System.EventHandler(this.buttonRefreshDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 896);
            this.Controls.Add(this.panelDb);
            this.Controls.Add(this.panelChange);
            this.Controls.Add(this.panelCreateNew);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "DB Access Prototype";
            this.panelCreateNew.ResumeLayout(false);
            this.panelCreateNew.PerformLayout();
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.panelDb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCreateNewFirstName;
        private System.Windows.Forms.Label labelCreateNewLastName;
        private System.Windows.Forms.Label labelCreateNewAge;
        private System.Windows.Forms.Label labelCreateNewWorkPlace;
        private System.Windows.Forms.Label labelCreateNewHomeAddress;
        private System.Windows.Forms.Panel panelCreateNew;
        private System.Windows.Forms.Label labelCreateCitizen;
        private System.Windows.Forms.Button buttonCreateNewSubmit;
        private System.Windows.Forms.TextBox textBoxCreateNewYCord;
        private System.Windows.Forms.TextBox textBoxCreateNewXCord;
        private System.Windows.Forms.TextBox textBoxCreateNewWorkPlace;
        private System.Windows.Forms.TextBox textBoxCreateNewAge;
        private System.Windows.Forms.TextBox textBoxCreateNewLastName;
        private System.Windows.Forms.TextBox textBoxCreateNewFirstName;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.Label labelSelectedCitizen;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxChangeYCord;
        private System.Windows.Forms.TextBox textBoxChangeXCord;
        private System.Windows.Forms.TextBox textBoxChangeWorkPlace;
        private System.Windows.Forms.TextBox textBoxChangeAge;
        private System.Windows.Forms.TextBox textBoxChangeLastName;
        private System.Windows.Forms.TextBox textBoxChangeFirstName;
        private System.Windows.Forms.Label labelChangeFirstName;
        private System.Windows.Forms.Label labelChangeHomeAddress;
        private System.Windows.Forms.Label labelChangeLastName;
        private System.Windows.Forms.Label labelChangeWorkPlace;
        private System.Windows.Forms.Label labelChangeAge;
        private System.Windows.Forms.Panel panelDb;
        private System.Windows.Forms.ListBox listBoxCitizenList;
        private System.Windows.Forms.Button buttonRefreshDb;
    }
}

