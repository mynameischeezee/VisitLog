namespace VisitLog.PresentationLayer
{
    partial class AddVisiterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVisiterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_Date = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Duration = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ID_Value = new System.Windows.Forms.Label();
            this.txtBox_Room = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_PIB = new System.Windows.Forms.TextBox();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_Room = new System.Windows.Forms.Label();
            this.lbl_PIB = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.PictureBox();
            this.btn_Remove = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtBox_Date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBox_Duration);
            this.panel1.Controls.Add(this.lbl_ID_Value);
            this.panel1.Controls.Add(this.txtBox_Room);
            this.panel1.Controls.Add(this.txtBox_PIB);
            this.panel1.Controls.Add(this.lbl_Duration);
            this.panel1.Controls.Add(this.lbl_Room);
            this.panel1.Controls.Add(this.lbl_PIB);
            this.panel1.Controls.Add(this.lbl_ID);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 195);
            this.panel1.TabIndex = 0;
            // 
            // txtBox_Date
            // 
            this.txtBox_Date.BackColor = System.Drawing.Color.White;
            this.txtBox_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Date.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBox_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.txtBox_Date.Location = new System.Drawing.Point(238, 134);
            this.txtBox_Date.Mask = "00/00/0000 90:00";
            this.txtBox_Date.Name = "txtBox_Date";
            this.txtBox_Date.Size = new System.Drawing.Size(121, 20);
            this.txtBox_Date.TabIndex = 29;
            this.txtBox_Date.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Дата відвідування:";
            // 
            // txtBox_Duration
            // 
            this.txtBox_Duration.BackColor = System.Drawing.Color.White;
            this.txtBox_Duration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Duration.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBox_Duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.txtBox_Duration.Location = new System.Drawing.Point(303, 103);
            this.txtBox_Duration.Mask = "00000";
            this.txtBox_Duration.Name = "txtBox_Duration";
            this.txtBox_Duration.Size = new System.Drawing.Size(45, 20);
            this.txtBox_Duration.TabIndex = 25;
            this.txtBox_Duration.ValidatingType = typeof(int);
            // 
            // lbl_ID_Value
            // 
            this.lbl_ID_Value.AutoSize = true;
            this.lbl_ID_Value.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.lbl_ID_Value.Location = new System.Drawing.Point(53, 2);
            this.lbl_ID_Value.Name = "lbl_ID_Value";
            this.lbl_ID_Value.Size = new System.Drawing.Size(37, 30);
            this.lbl_ID_Value.TabIndex = 24;
            this.lbl_ID_Value.Text = "ID";
            // 
            // txtBox_Room
            // 
            this.txtBox_Room.BackColor = System.Drawing.Color.White;
            this.txtBox_Room.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Room.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBox_Room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.txtBox_Room.Location = new System.Drawing.Point(206, 70);
            this.txtBox_Room.Mask = "00000";
            this.txtBox_Room.Name = "txtBox_Room";
            this.txtBox_Room.Size = new System.Drawing.Size(45, 20);
            this.txtBox_Room.TabIndex = 20;
            this.txtBox_Room.ValidatingType = typeof(int);
            // 
            // txtBox_PIB
            // 
            this.txtBox_PIB.BackColor = System.Drawing.Color.White;
            this.txtBox_PIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_PIB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_PIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.txtBox_PIB.Location = new System.Drawing.Point(206, 39);
            this.txtBox_PIB.Name = "txtBox_PIB";
            this.txtBox_PIB.Size = new System.Drawing.Size(344, 20);
            this.txtBox_PIB.TabIndex = 18;
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_Duration.Location = new System.Drawing.Point(3, 93);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(294, 30);
            this.lbl_Duration.TabIndex = 17;
            this.lbl_Duration.Text = "Тривалість відвідування:";
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_Room.Location = new System.Drawing.Point(3, 62);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(205, 30);
            this.lbl_Room.TabIndex = 14;
            this.lbl_Room.Text = "Номер кімнати:";
            // 
            // lbl_PIB
            // 
            this.lbl_PIB.AutoSize = true;
            this.lbl_PIB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_PIB.Location = new System.Drawing.Point(3, 32);
            this.lbl_PIB.Name = "lbl_PIB";
            this.lbl_PIB.Size = new System.Drawing.Size(197, 30);
            this.lbl_PIB.TabIndex = 13;
            this.lbl_PIB.Text = "ПІБ Відвідувача:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbl_ID.Location = new System.Drawing.Point(3, 2);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(44, 30);
            this.lbl_ID.TabIndex = 12;
            this.lbl_ID.Text = "ID:";
            // 
            // btn_Next
            // 
            this.btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Next.BackgroundImage")));
            this.btn_Next.Location = new System.Drawing.Point(514, 213);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(50, 50);
            this.btn_Next.TabIndex = 26;
            this.btn_Next.TabStop = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            this.btn_Next.MouseEnter += new System.EventHandler(this.btn_Next_MouseEnter);
            this.btn_Next.MouseLeave += new System.EventHandler(this.btn_Next_MouseLeave);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackgroundImage = global::VisitLog.Properties.Resources.RemoveButton;
            this.btn_Remove.Location = new System.Drawing.Point(14, 213);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(50, 50);
            this.btn_Remove.TabIndex = 25;
            this.btn_Remove.TabStop = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            this.btn_Remove.MouseEnter += new System.EventHandler(this.btn_Remove_MouseEnter);
            this.btn_Remove.MouseLeave += new System.EventHandler(this.btn_Remove_MouseLeave);
            // 
            // AddVisiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(580, 272);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddVisiterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVisiterForm";
            this.Load += new System.EventHandler(this.AddVisiterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_Room;
        private System.Windows.Forms.Label lbl_PIB;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtBox_PIB;
        private System.Windows.Forms.MaskedTextBox txtBox_Room;
        private System.Windows.Forms.Label lbl_ID_Value;
        private System.Windows.Forms.PictureBox btn_Remove;
        private System.Windows.Forms.PictureBox btn_Next;
        private System.Windows.Forms.MaskedTextBox txtBox_Duration;
        private System.Windows.Forms.MaskedTextBox txtBox_Date;
        private System.Windows.Forms.Label label1;
    }
}