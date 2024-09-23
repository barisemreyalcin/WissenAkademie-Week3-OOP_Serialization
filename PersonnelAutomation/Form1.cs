namespace PersonnelAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Title'larý combo box'a ekleyecem
            cmbTitle.Items.AddRange(Enum.GetNames(typeof(Title)));
        }
        #endregion

        #region Image Selection
        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Personnel Photo(png,jpg,gif)|*.jpg;*png;*gif;";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofd.FileName); // Resim dosyasýný picturebox control'ünün image property'sine ekledik.
                pbPicture.Tag = Path.GetExtension(ofd.FileName); // Dosya uzantýsýný alýr
            }
            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel();
            personnel = FillPersonnel(personnel);
            ListViewItem lvItem = FillListView(personnel);
            lvPersonnels.Items.Add(lvItem);
        }

        private ListViewItem FillListView(Personnel personnel)
        {
            ListViewItem lvItem = new ListViewItem(personnel.RepOfTurId);
            lvItem.SubItems.Add($"{personnel.FirstName} {personnel.LastName}");
            lvItem.SubItems.Add($"{personnel.BirthDate}");
            lvItem.SubItems.Add($"{personnel.Email}");
            lvItem.SubItems.Add($"{personnel.Phone}");
            lvItem.SubItems.Add($"{personnel.EmploymentStartDate}");
            lvItem.SubItems.Add($"{personnel.Title}");
            lvItem.Tag = personnel;

            return lvItem;
        }

        private Personnel FillPersonnel(Personnel personnel)
        {
            personnel.FirstName = txtFirstName.Text;
            personnel.LastName = txtLastName.Text;
            personnel.RepOfTurId = txtRepOfTurId.Text;
            personnel.BirthDate = dtBirthYear.Value;
            personnel.Email = txtEmail.Text;
            personnel.Phone = txtPhone.Text;
            personnel.EmploymentStartDate = dtEmploymentStartDate.Value;
            personnel.Title = (cmbTitle.Text == "" ? Title.Unspecified : (Title)Enum.Parse(typeof(Title), cmbTitle.Text)).ToString();
            personnel.PersonnelPic = Guid.NewGuid() + pbPicture.Tag.ToString();
            pbPicture.Image.Save(Application.StartupPath + "Images/" + personnel.PersonnelPic);

            return personnel;
        }
    }
}
