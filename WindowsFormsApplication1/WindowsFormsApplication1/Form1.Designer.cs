namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMeetingType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxMeetingActions = new System.Windows.Forms.TextBox();
            this.textBoxMeetingStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonLastCreatedMeeting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Meeting Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date/Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Meeting Actions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Meeting Status";
            // 
            // comboBoxMeetingType
            // 
            this.comboBoxMeetingType.FormattingEnabled = true;
            this.comboBoxMeetingType.Items.AddRange(new object[] {
            "Finance",
            "MANCO",
            "Project Team Leaders(PTL)"});
            this.comboBoxMeetingType.Location = new System.Drawing.Point(112, 57);
            this.comboBoxMeetingType.Name = "comboBoxMeetingType";
            this.comboBoxMeetingType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMeetingType.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // textBoxMeetingActions
            // 
            this.textBoxMeetingActions.Location = new System.Drawing.Point(112, 127);
            this.textBoxMeetingActions.Multiline = true;
            this.textBoxMeetingActions.Name = "textBoxMeetingActions";
            this.textBoxMeetingActions.Size = new System.Drawing.Size(200, 20);
            this.textBoxMeetingActions.TabIndex = 17;
            // 
            // textBoxMeetingStatus
            // 
            this.textBoxMeetingStatus.Location = new System.Drawing.Point(112, 159);
            this.textBoxMeetingStatus.Name = "textBoxMeetingStatus";
            this.textBoxMeetingStatus.Size = new System.Drawing.Size(200, 22);
            this.textBoxMeetingStatus.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "RESOLUTION APPLICATION SYSTEM";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCreate.Location = new System.Drawing.Point(12, 226);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(94, 49);
            this.buttonCreate.TabIndex = 21;
            this.buttonCreate.Text = "Create Meeting";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonUpdate.Location = new System.Drawing.Point(112, 226);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(106, 49);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Update Meeting Status";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonViewAll.Location = new System.Drawing.Point(224, 226);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(88, 49);
            this.buttonViewAll.TabIndex = 23;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonLastCreatedMeeting
            // 
            this.buttonLastCreatedMeeting.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonLastCreatedMeeting.Location = new System.Drawing.Point(318, 226);
            this.buttonLastCreatedMeeting.Name = "buttonLastCreatedMeeting";
            this.buttonLastCreatedMeeting.Size = new System.Drawing.Size(101, 49);
            this.buttonLastCreatedMeeting.TabIndex = 24;
            this.buttonLastCreatedMeeting.Text = "View Last Created Meeting";
            this.buttonLastCreatedMeeting.UseVisualStyleBackColor = false;
            this.buttonLastCreatedMeeting.Click += new System.EventHandler(this.buttonLastCreatedMeeting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 308);
            this.Controls.Add(this.buttonLastCreatedMeeting);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMeetingStatus);
            this.Controls.Add(this.textBoxMeetingActions);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxMeetingType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMeetingType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxMeetingActions;
        private System.Windows.Forms.TextBox textBoxMeetingStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonLastCreatedMeeting;
    }
}

