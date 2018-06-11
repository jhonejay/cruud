using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBCrud
{
    public partial class Form1 : Form
    {
        bool isadd = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();

        }

        public void display()
        {

            try
            {
                BindingSource bindingsource = new BindingSource();

                List<DBPrepaidCards> rec = DBPrepaidCards.GetData();

                foreach (DBPrepaidCards data in rec)
                    bindingsource.Add(data);

                this.dataGridView_PrepaidCards.Refresh();
                this.dataGridView_PrepaidCards.DataSource = bindingsource;
                
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void cmd_add_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "0.0";
            txtCable.Text = "";
            txtPin.Text = "";
            isadd = true;

        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            isadd = false;
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            if (isadd == true)
            {
                //add new record
                DBPrepaidCards prep = new DBPrepaidCards(txtCable.Text, Int32.Parse(txtAmount.Text), txtPin.Text, "Pending", dateTimePicker_DateReg.Value, dateTimePicker_Expire.Value);

                prep.Add();

            }
            else { 
                //edit record
                int id = Int32.Parse( dataGridView_PrepaidCards.CurrentRow.Cells[0].Value.ToString());

                DBPrepaidCards rec = DBPrepaidCards.GetDataID(id);

                rec.Amount = Int32.Parse( txtAmount.Text);
                rec.CableType = txtCable.Text;
                rec.Date_Expired = dateTimePicker_Expire.Value;
                rec.Date_Registered = dateTimePicker_DateReg.Value;
                rec.Pin = txtPin.Text;

                rec.Update();

            }

            display();
        }

        private void dataGridView_PrepaidCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_PrepaidCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCable.Text = dataGridView_PrepaidCards.CurrentRow.Cells[1].Value.ToString();
            txtAmount.Text = dataGridView_PrepaidCards.CurrentRow.Cells[2].Value.ToString();

            txtPin.Text = dataGridView_PrepaidCards.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_DateReg.Value = DateTime.Parse( dataGridView_PrepaidCards.CurrentRow.Cells[5].Value.ToString());
            dateTimePicker_Expire.Value = DateTime.Parse(dataGridView_PrepaidCards.CurrentRow.Cells[6].Value.ToString());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            int id =Int32.Parse( dataGridView_PrepaidCards.CurrentRow.Cells[0].Value.ToString());

            DBPrepaidCards rec = DBPrepaidCards.GetDataID(id);

            rec.Delete();

            display();
        }
    }
}
