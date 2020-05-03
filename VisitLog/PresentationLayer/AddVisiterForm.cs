using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitLog.BussinesLogicLayer;

namespace VisitLog.PresentationLayer
{
    public partial class AddVisiterForm : Form
    {
        public Main_Form form;

        public AddVisiterForm()
        {
            InitializeComponent();
        }
        private void AddVisiterForm_Load(object sender, EventArgs e)
        {
            lbl_ID_Value.Text = VisitLogMain.ID.ID.ToString();

        }
        private void btn_Remove_MouseEnter(object sender, EventArgs e)
        {
            btn_Remove.BackgroundImage = (System.Drawing.Image)(Properties.Resources.RemoveButtonHover);
        }
        private void btn_Remove_MouseLeave(object sender, EventArgs e)
        {
            btn_Remove.BackgroundImage = (System.Drawing.Image)(Properties.Resources.RemoveButton);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

                DialogResult result = MessageBox.Show("Зміни не будуть збережені,  покинути форму ?", "Увага !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                VisitLogMain.ID.ID -= 1;
                form.Show();
                this.Close();
                }
            

        }

        private void btn_Next_MouseEnter(object sender, EventArgs e)
        {
            btn_Next.Image = Properties.Resources.NextHover;
        }

        private void btn_Next_MouseLeave(object sender, EventArgs e)
        {
            btn_Next.Image = Properties.Resources.Next;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBox_PIB.Text) && !string.IsNullOrEmpty(txtBox_Room.Text) && !string.IsNullOrEmpty(txtBox_Date.Text) && !string.IsNullOrEmpty(txtBox_Duration.Text))
                {
                    DateTime date = DateTime.Parse(txtBox_Date.Text);
                    
                    VisitLogMain.Visits.Add(new Visit(txtBox_PIB.Text, lbl_ID_Value.Text, txtBox_Room.Text, date, float.Parse(txtBox_Duration.Text)));
                    form.Show();
                    form.AddVisitsToListBox();
                    this.Close();
                }
                else
                {
                    throw new InvalidOperationException("Emty fields been deycted.");
                }
            }
            catch
            {
                MessageBox.Show("Не всі поля було заповнено, або дата буле введено невірно ! Будь ласка, заповніть усі поля данними !", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

       
    }
}
