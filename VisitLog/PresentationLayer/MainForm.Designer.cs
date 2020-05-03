namespace VisitLog
{
    partial class Main_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_HeaderName = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_PIB_List = new System.Windows.Forms.Label();
            this.lstBox_Visiters = new System.Windows.Forms.ListBox();
            this.btn_Remove = new System.Windows.Forms.PictureBox();
            this.btn_Add = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_PIB = new System.Windows.Forms.Label();
            this.lbl_Room = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lstBox_DatesList = new System.Windows.Forms.ListBox();
            this.lbl_AddDates = new System.Windows.Forms.Label();
            this.lbl_PIB_Value = new System.Windows.Forms.Label();
            this.lbl_ID_Value = new System.Windows.Forms.Label();
            this.lbl_Room_Value = new System.Windows.Forms.Label();
            this.lbl_Date_Value = new System.Windows.Forms.Label();
            this.lbl_Day_Value = new System.Windows.Forms.Label();
            this.lbl_Duration_Value = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_HeaderName);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 35);
            this.panel1.TabIndex = 0;
            // 
            // lbl_HeaderName
            // 
            this.lbl_HeaderName.AutoSize = true;
            this.lbl_HeaderName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_HeaderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lbl_HeaderName.Location = new System.Drawing.Point(30, 9);
            this.lbl_HeaderName.Name = "lbl_HeaderName";
            this.lbl_HeaderName.Size = new System.Drawing.Size(160, 21);
            this.lbl_HeaderName.TabIndex = 1;
            this.lbl_HeaderName.Text = "Журнал Віввідувань";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.Image = global::VisitLog.Properties.Resources.CloseButton15px;
            this.btn_Close.Location = new System.Drawing.Point(1242, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(26, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_PIB_List
            // 
            this.lbl_PIB_List.AutoSize = true;
            this.lbl_PIB_List.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PIB_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lbl_PIB_List.Location = new System.Drawing.Point(28, 103);
            this.lbl_PIB_List.Name = "lbl_PIB_List";
            this.lbl_PIB_List.Size = new System.Drawing.Size(190, 30);
            this.lbl_PIB_List.TabIndex = 2;
            this.lbl_PIB_List.Text = "ПІБ Відвідувача";
            // 
            // lstBox_Visiters
            // 
            this.lstBox_Visiters.BackColor = System.Drawing.Color.White;
            this.lstBox_Visiters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBox_Visiters.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstBox_Visiters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lstBox_Visiters.FormattingEnabled = true;
            this.lstBox_Visiters.ItemHeight = 20;
            this.lstBox_Visiters.Location = new System.Drawing.Point(33, 137);
            this.lstBox_Visiters.Name = "lstBox_Visiters";
            this.lstBox_Visiters.Size = new System.Drawing.Size(500, 540);
            this.lstBox_Visiters.TabIndex = 3;
            this.lstBox_Visiters.SelectedIndexChanged += new System.EventHandler(this.lstBox_Visiters_SelectedIndexChanged);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackgroundImage = global::VisitLog.Properties.Resources.RemoveButton;
            this.btn_Remove.Location = new System.Drawing.Point(483, 83);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(50, 50);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.TabStop = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            this.btn_Remove.MouseEnter += new System.EventHandler(this.btn_Remove_MouseEnter);
            this.btn_Remove.MouseLeave += new System.EventHandler(this.btn_Remove_MouseLeave);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::VisitLog.Properties.Resources.AddButton;
            this.btn_Add.Location = new System.Drawing.Point(427, 83);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(50, 50);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.TabStop = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.MouseEnter += new System.EventHandler(this.btn_Add_MouseEnter);
            this.btn_Add.MouseLeave += new System.EventHandler(this.btn_Add_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::VisitLog.Properties.Resources.SearchBar330x40px;
            this.panel2.Controls.Add(this.txtBox_Search);
            this.panel2.Location = new System.Drawing.Point(30, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 50);
            this.panel2.TabIndex = 1;
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.BackColor = System.Drawing.Color.White;
            this.txtBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.txtBox_Search.Location = new System.Drawing.Point(50, 14);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(267, 20);
            this.txtBox_Search.TabIndex = 0;
            this.txtBox_Search.Text = "Введіть ПІБ Відвідувача";
            this.txtBox_Search.TextChanged += new System.EventHandler(this.txtBox_Search_TextChanged);
            this.txtBox_Search.Enter += new System.EventHandler(this.txtBox_Search_Enter);
            this.txtBox_Search.Leave += new System.EventHandler(this.txtBox_Search_Leave);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_ID.Location = new System.Drawing.Point(539, 137);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(44, 30);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Text = "ID:";
            // 
            // lbl_PIB
            // 
            this.lbl_PIB.AutoSize = true;
            this.lbl_PIB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_PIB.Location = new System.Drawing.Point(539, 167);
            this.lbl_PIB.Name = "lbl_PIB";
            this.lbl_PIB.Size = new System.Drawing.Size(197, 30);
            this.lbl_PIB.TabIndex = 7;
            this.lbl_PIB.Text = "ПІБ Відвідувача:";
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_Room.Location = new System.Drawing.Point(539, 197);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(205, 30);
            this.lbl_Room.TabIndex = 8;
            this.lbl_Room.Text = "Номер кімнати:";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_Date.Location = new System.Drawing.Point(539, 227);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(229, 30);
            this.lbl_Date.TabIndex = 9;
            this.lbl_Date.Text = "Дата відвідування:";
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_Day.Location = new System.Drawing.Point(539, 257);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(229, 30);
            this.lbl_Day.TabIndex = 10;
            this.lbl_Day.Text = "День відвідування:";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_Duration.Location = new System.Drawing.Point(539, 287);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(294, 30);
            this.lbl_Duration.TabIndex = 11;
            this.lbl_Duration.Text = "Тривалість відвідування:";
            // 
            // lstBox_DatesList
            // 
            this.lstBox_DatesList.BackColor = System.Drawing.Color.White;
            this.lstBox_DatesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBox_DatesList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstBox_DatesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lstBox_DatesList.FormattingEnabled = true;
            this.lstBox_DatesList.ItemHeight = 20;
            this.lstBox_DatesList.Location = new System.Drawing.Point(544, 357);
            this.lstBox_DatesList.Name = "lstBox_DatesList";
            this.lstBox_DatesList.Size = new System.Drawing.Size(302, 320);
            this.lstBox_DatesList.TabIndex = 12;
            // 
            // lbl_AddDates
            // 
            this.lbl_AddDates.AutoSize = true;
            this.lbl_AddDates.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AddDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_AddDates.Location = new System.Drawing.Point(539, 324);
            this.lbl_AddDates.Name = "lbl_AddDates";
            this.lbl_AddDates.Size = new System.Drawing.Size(261, 30);
            this.lbl_AddDates.TabIndex = 13;
            this.lbl_AddDates.Text = "Інші дні відвідування:";
            // 
            // lbl_PIB_Value
            // 
            this.lbl_PIB_Value.AutoSize = true;
            this.lbl_PIB_Value.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PIB_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lbl_PIB_Value.Location = new System.Drawing.Point(742, 167);
            this.lbl_PIB_Value.Name = "lbl_PIB_Value";
            this.lbl_PIB_Value.Size = new System.Drawing.Size(187, 30);
            this.lbl_PIB_Value.TabIndex = 14;
            this.lbl_PIB_Value.Text = "ПІБ відвідувача";
            // 
            // lbl_ID_Value
            // 
            this.lbl_ID_Value.AutoSize = true;
            this.lbl_ID_Value.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lbl_ID_Value.Location = new System.Drawing.Point(589, 137);
            this.lbl_ID_Value.Name = "lbl_ID_Value";
            this.lbl_ID_Value.Size = new System.Drawing.Size(175, 30);
            this.lbl_ID_Value.TabIndex = 15;
            this.lbl_ID_Value.Text = "ID відвідувача";
            // 
            // lbl_Room_Value
            // 
            this.lbl_Room_Value.AutoSize = true;
            this.lbl_Room_Value.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Room_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lbl_Room_Value.Location = new System.Drawing.Point(742, 197);
            this.lbl_Room_Value.Name = "lbl_Room_Value";
            this.lbl_Room_Value.Size = new System.Drawing.Size(336, 30);
            this.lbl_Room_Value.TabIndex = 16;
            this.lbl_Room_Value.Text = "Номер кімнати відвідувача";
            // 
            // lbl_Date_Value
            // 
            this.lbl_Date_Value.AutoSize = true;
            this.lbl_Date_Value.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Date_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lbl_Date_Value.Location = new System.Drawing.Point(774, 227);
            this.lbl_Date_Value.Name = "lbl_Date_Value";
            this.lbl_Date_Value.Size = new System.Drawing.Size(222, 30);
            this.lbl_Date_Value.TabIndex = 17;
            this.lbl_Date_Value.Text = "Дата відвідування";
            // 
            // lbl_Day_Value
            // 
            this.lbl_Day_Value.AutoSize = true;
            this.lbl_Day_Value.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Day_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lbl_Day_Value.Location = new System.Drawing.Point(774, 257);
            this.lbl_Day_Value.Name = "lbl_Day_Value";
            this.lbl_Day_Value.Size = new System.Drawing.Size(222, 30);
            this.lbl_Day_Value.TabIndex = 18;
            this.lbl_Day_Value.Text = "День відвідування";
            // 
            // lbl_Duration_Value
            // 
            this.lbl_Duration_Value.AutoSize = true;
            this.lbl_Duration_Value.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Duration_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lbl_Duration_Value.Location = new System.Drawing.Point(839, 287);
            this.lbl_Duration_Value.Name = "lbl_Duration_Value";
            this.lbl_Duration_Value.Size = new System.Drawing.Size(287, 30);
            this.lbl_Duration_Value.TabIndex = 19;
            this.lbl_Duration_Value.Text = "Тривалість відвідування";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 754);
            this.Controls.Add(this.lbl_Duration_Value);
            this.Controls.Add(this.lbl_Day_Value);
            this.Controls.Add(this.lbl_Date_Value);
            this.Controls.Add(this.lbl_Room_Value);
            this.Controls.Add(this.lbl_ID_Value);
            this.Controls.Add(this.lbl_PIB_Value);
            this.Controls.Add(this.lbl_AddDates);
            this.Controls.Add(this.lstBox_DatesList);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_Day);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Room);
            this.Controls.Add(this.lbl_PIB);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lstBox_Visiters);
            this.Controls.Add(this.lbl_PIB_List);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_HeaderName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Label lbl_PIB_List;
        private System.Windows.Forms.ListBox lstBox_Visiters;
        private System.Windows.Forms.PictureBox btn_Add;
        private System.Windows.Forms.PictureBox btn_Remove;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_PIB;
        private System.Windows.Forms.Label lbl_Room;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Day;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.ListBox lstBox_DatesList;
        private System.Windows.Forms.Label lbl_AddDates;
        private System.Windows.Forms.Label lbl_PIB_Value;
        private System.Windows.Forms.Label lbl_ID_Value;
        private System.Windows.Forms.Label lbl_Room_Value;
        private System.Windows.Forms.Label lbl_Date_Value;
        private System.Windows.Forms.Label lbl_Day_Value;
        private System.Windows.Forms.Label lbl_Duration_Value;
    }
}

