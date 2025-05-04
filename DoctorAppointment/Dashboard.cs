using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace DoctorAppointment
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelIndicator2_Click(object sender, EventArgs e)
        {

        }

        private void labelIndicator3_Click(object sender, EventArgs e)
        {

        }

        private void labelIndicator4_Click(object sender, EventArgs e)
        {

        }

        private void btnAppointSchedule_Click(object sender, EventArgs e)
        {
            labelIndicator1.ForeColor = System.Drawing.Color.Red;
            labelIndicator2.ForeColor = System.Drawing.Color.Black;
            labelIndicator3.ForeColor = System.Drawing.Color.Black;
            labelIndicator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = false;
            panel4.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnPatientRecord_Click(object sender, EventArgs e)
        {
            labelIndicator1.ForeColor = System.Drawing.Color.Black;
            labelIndicator2.ForeColor = System.Drawing.Color.Red;
            labelIndicator3.ForeColor = System.Drawing.Color.Black;
            labelIndicator4.ForeColor = System.Drawing.Color.Black;

            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;

        }


        private void btnBillPay_Click(object sender, EventArgs e)
        {
            labelIndicator1.ForeColor = System.Drawing.Color.Black;
            labelIndicator2.ForeColor = System.Drawing.Color.Black;
            labelIndicator3.ForeColor = System.Drawing.Color.Black;
            labelIndicator4.ForeColor = System.Drawing.Color.Red;

            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.FormClosed += Dashboard_FormClosed;


            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                String name = txtName.Text;
                String address = txtAddress.Text;
                Int64 contact = Convert.ToInt64(txtContact.Text);
                int age = Convert.ToInt32(txtAge.Text);
                String gender = comboGender.Text;
                String blood = comboBlood.Text;
                String any = txtAny.Text;
                int pid = Convert.ToInt32(txtPid.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=RASHED-REFAT\\SQLEXPRESS;Initial Catalog=drappointment;Integrated Security=True;";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddPatient values ('" + name + "', '" + address + "','" + contact + "','" + age + "','" + gender + "','" + blood + "','" + any + "','" + pid + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid or Incomplete Data!");
            }
            MessageBox.Show("Data Saved!");

            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtAge.Clear();
            txtPid.Clear();
            txtAny.Clear();
            comboBlood.ResetText();
            comboGender.ResetText();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                String fullname = drName.Text;
                String specialization = drSpecialization.Text;
                String qualification = drQualification.Text;
                Int64 drcontact = Convert.ToInt64(drContact.Text);
                String schedule = drSchedule.Text;
                Int64 fee = Convert.ToInt64(drFee.Text);
                int drid = Convert.ToInt32(did.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=RASHED-REFAT\\SQLEXPRESS;Initial Catalog=drappointment;Integrated Security=True;";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddDoctor values ('" + fullname + "', '" + specialization + "','" + qualification + "','" + drcontact + "','" + schedule + "','" + fee + "','" + drid + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid or Incomplete Data!");
            }
            MessageBox.Show("Data Saved!");


            drName.Clear();
            drSpecialization.Clear();
            drQualification.Clear();
            drContact.Clear();
            drSchedule.Clear();
            drFee.Clear();
            did.Clear();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fieldS_TextChanged(object sender, EventArgs e)
        {
            if (fieldS.Text != "")
            {
                String field = fieldS.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=RASHED-REFAT\\SQLEXPRESS;Initial Catalog=drappointment;Integrated Security=True;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM AddDoctor WHERE Specialization = @Specialization";
                cmd.Parameters.AddWithValue("@Specialization", field);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }



        }

        private void btnDoctorManagement_Click(object sender, EventArgs e)
        {
            labelIndicator1.ForeColor = System.Drawing.Color.Black;
            labelIndicator2.ForeColor = System.Drawing.Color.Black;
            labelIndicator3.ForeColor = System.Drawing.Color.Red;
            labelIndicator4.ForeColor = System.Drawing.Color.Black;


            panel3.Visible = true;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            try
            {
                String field = fieldS.Text;
                String patientname = pName.Text;
                int patientAge = Convert.ToInt32(pAge.Text);
                String doctorName = dName.Text;
                String appointmentDate = aDate.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=RASHED-REFAT\\SQLEXPRESS;Initial Catalog=drappointment;Integrated Security=True;";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO AppointmentSchedule (Field, Patient_Name, Patient_Age, Doctor_Name, Appointment_Date) " +
                                  "VALUES ('" + field + "','" + patientname + "', '" + patientAge + "', '" + doctorName + "', '" + appointmentDate + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid or Incomplete Data! \n" + ex.Message);
            }
                MessageBox.Show("Appointment Saved!");

            fieldS.Clear();
            pName.Clear();
            pAge.Clear();
            dName.Clear();
            aDate.Clear();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                String patientsName = txtPName.Text.Trim();
                String paymethod = comboPMethod.Text.Trim();
                String amountText = txtAmount.Text.Trim();

                if (string.IsNullOrEmpty(patientsName))
                {
                    MessageBox.Show("Patient's name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(paymethod))
                {
                    MessageBox.Show("Payment method is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(amountText) || !decimal.TryParse(amountText, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("A valid payment amount is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=RASHED-REFAT\\SQLEXPRESS;Initial Catalog=drappointment;Integrated Security=True;";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Billing (Patients_Name, Payment_Method, Amount) VALUES (@PatientsName, @PaymentMethod, @Amount)";
                cmd.Parameters.AddWithValue("@PatientsName", patientsName);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymethod);
                cmd.Parameters.AddWithValue("@Amount", amount);

                con.Open(); 
                cmd.ExecuteNonQuery();
                con.Close(); 

                MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPName.Clear();
                txtAmount.Clear();
                comboPMethod.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unsuccessful Transaction!!!\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

