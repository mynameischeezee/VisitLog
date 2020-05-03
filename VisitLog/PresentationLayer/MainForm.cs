using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitLog.PresentationLayer;
using VisitLog.DataAccessLayer;
using VisitLog.BussinesLogicLayer;
using System.IO;

namespace VisitLog
{
    public partial class Main_Form :Form
    {

        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            Settings.FolderInitialization();

           
            VisitLogMain.ID = JsonComponent.DeSerialize<VisiterID>(Settings.SettingsFolder, "Settings");
            if (VisitLogMain.ID.ID > 0)
            {
                VisitLogMain.Visits = JsonComponent.DeSerialize<List<Visit>>(Settings.VisitLogListFolder, "Visits");
                AddVisitsToListBox();
            }
            else
            {
                VisitLogMain.Visits = new List<Visit>();
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtBox_Search_Enter(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "Введіть ПІБ Відвідувача")
            {
                txtBox_Search.Text = "";
                txtBox_Search.ForeColor = Color.FromArgb(142, 153, 164);
            }
        }
        private void txtBox_Search_Leave(object sender, EventArgs e)
        {
            if (txtBox_Search.Text == "")
            {
                txtBox_Search.Text = "Введіть ПІБ Відвідувача";
                txtBox_Search.ForeColor = Color.FromArgb(216, 216, 216);
            }
        }
        private void btn_Add_MouseEnter(object sender, EventArgs e)
        {
            btn_Add.BackgroundImage = (Properties.Resources.AddButtonHover);
        }
        private void btn_Add_MouseLeave(object sender, EventArgs e)
        {
            btn_Add.BackgroundImage = (Properties.Resources.AddButton);
        }
        private void btn_Remove_MouseEnter(object sender, EventArgs e)
        {
            btn_Remove.BackgroundImage = (Properties.Resources.RemoveButtonHover);
        }
        private void btn_Remove_MouseLeave(object sender, EventArgs e)
        {
            btn_Remove.BackgroundImage = (Properties.Resources.RemoveButton);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            VisitLogMain.ID.AddID();
            AddVisiterForm addVisiter = new AddVisiterForm();
            addVisiter.form = this;
            this.Hide();
            addVisiter.Show();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            JsonComponent.Serialize(VisitLogMain.ID, Settings.SettingsFolder, "Settings");
            JsonComponent.Serialize(VisitLogMain.Visits, Settings.VisitLogListFolder, "Visits");
        }
        public void AddVisitsToListBox()
        {
            lstBox_Visiters.Items.Clear();
            
            foreach (Visit visit in VisitLogMain.Visits)
            {
                lstBox_Visiters.Items.Add(visit.PIB + $" ({visit.Date.ToString("dd/MM/yyyy")})");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Видалити обрані елемети ?", "Увага !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (lstBox_Visiters.SelectedIndex >= 0)
                {
                    VisitLogMain.Visits.RemoveAt(lstBox_Visiters.SelectedIndex);
                    AddVisitsToListBox();
                }
            }
            

        }

        private void lstBox_Visiters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var culture = new System.Globalization.CultureInfo("uk-UA");
            if (lstBox_Visiters.SelectedIndex >= 0)
            {
                lstBox_DatesList.Items.Clear();
                lbl_ID_Value.Text = VisitLogMain.Visits[lstBox_Visiters.SelectedIndex].ID;
                lbl_PIB_Value.Text = VisitLogMain.Visits[lstBox_Visiters.SelectedIndex].PIB;
                lbl_Room_Value.Text = VisitLogMain.Visits[lstBox_Visiters.SelectedIndex].RoomNumber;
                lbl_Duration_Value.Text = VisitLogMain.Visits[lstBox_Visiters.SelectedIndex].Duration.ToString();
                lbl_Date_Value.Text = VisitLogMain.Visits[lstBox_Visiters.SelectedIndex].Date.ToString("dd/MM/yyyy");
                lbl_Day_Value.Text = culture.DateTimeFormat.GetDayName(VisitLogMain.Visits[lstBox_Visiters.SelectedIndex].Date.Date.DayOfWeek);
                foreach (Visit visit in VisitLogMain.Visits)
                {
                    if (visit.RoomNumber.Contains(VisitLogMain.Visits[lstBox_Visiters.SelectedIndex].RoomNumber))
                    {
                        if (visit.Date != VisitLogMain.Visits[lstBox_Visiters.SelectedIndex].Date)
                        {
                          lstBox_DatesList.Items.Add($" {visit.Date.ToString("dd/MM/yyyy")} - {culture.DateTimeFormat.GetDayName(visit.Date.Date.DayOfWeek)}");
                        }
                        
                    }

                }
            }
            
        }

        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Search.Text != "Введіть ПІБ Відвідувача" && txtBox_Search.Text != "")
            {
                lstBox_Visiters.Items.Clear();
                foreach (Visit visit in VisitLogMain.Visits)
                {
                    if (visit.PIB.Contains(txtBox_Search.Text))
                    {
                        lstBox_Visiters.Items.Add(visit.PIB + $" ({visit.Date.ToString("dd/MM/yyyy")})");
                    }

                }
            }
            else
            {
                AddVisitsToListBox();
            }
            
        }
    }
}
