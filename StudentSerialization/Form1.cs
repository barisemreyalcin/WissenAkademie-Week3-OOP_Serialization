using System.Text.Json;

namespace StudentSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Student student = null;

            if (
                txtFullName.Text.Trim() == "" ||
                dtBirthDate.Value.Date == DateTime.Now.Date ||
                txtEmail.Text.Trim() == "" ||
                txtPhone.Text.Trim() == "" ||
                txtDepartment.Text.Trim() == "" ||
                txtGpa.Text.Trim() == "" ||
                rtxtAbout.Text.Trim() == ""
            )
            {
                MessageBox.Show("Please, fill all the inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                student = new Student();

                student.StudentId = 536;
                student.FullName = txtFullName.Text;
                student.BirthDate = dtBirthDate.Value;
                student.Email = txtEmail.Text;
                student.Phone = txtPhone.Text;
                student.Department = txtDepartment.Text;
                student.Gpa = double.Parse(txtGpa.Text);
                student.About = rtxtAbout.Text;
            }

            try
            {
                if (student != null)
                {
                    FileStream stream = new FileStream("Students.json", FileMode.Append, FileAccess.Write);
                    using (stream) // using aþaðýdaki block bittiðinde stream'i otomatik kapatýr
                    {
                        JsonSerializer.Serialize(stream, student);
                        MessageBox.Show("Student info written in Students.json file", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We have a problem writing data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            try
            {
                FileStream stream = new FileStream("Students.json", FileMode.Open, FileAccess.Read);

                student = JsonSerializer.Deserialize<Student>(stream);
                txtFullName.Text = student.FullName;
                dtBirthDate.Value = student.BirthDate;
                txtEmail.Text = student.Email;
                txtPhone.Text = student.Phone;
                txtDepartment.Text = student.Department;
                txtGpa.Text = student.Gpa.ToString();
                rtxtAbout.Text = student.About;
            }
            catch (Exception)
            {
                MessageBox.Show("We have problem reading json data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}
