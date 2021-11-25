using System;
using System.Windows.Forms;

namespace P6
{
    public partial class FormIssueRecord : Form
    {
        AppUser _CurrentAppUser;
        FakeIssueRepository fakeIssueRepo = new FakeIssueRepository();
        public FormIssueRecord(AppUser appuser)
        {
            InitializeComponent();
            _CurrentAppUser = appuser;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormIssueRecord_Load(object sender, EventArgs e)
        {
            CenterToParent();

            FakeIssueStatusRepository fakeStatusRepo = new FakeIssueStatusRepository();
            FakeAppUserRepository fakeAppRepo = new FakeAppUserRepository();


            textBoxId.Text = fakeIssueRepo.GetNextId().ToString();
            comboBoxAuthor.DataSource = fakeAppRepo.GetAll();
            comboBoxStatus.DataSource = fakeStatusRepo.GetAll();
            textBoxTitle.Select();
        }

        private void buttonCreateIssue_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            Int32.TryParse(textBoxId.Text, out int issueId);
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_CurrentAppUser.UserName,
                                                               FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            Int32.TryParse(preferredProjectId, out int ProjectId);
            AppUser appuser = (AppUser)comboBoxAuthor.SelectedItem;
            IssueStatus status = (IssueStatus)comboBoxStatus.SelectedItem;

            issue.Id = issueId;
            issue.ProjectId = ProjectId;
            issue.Title = textBoxTitle.Text;
            issue.DiscoveryDate = dateTimePicker1.Value;
            issue.Discoverer = appuser.ToString();
            issue.InitialDescription = textBoxDescription.Text;
            issue.Component = textBoxComponent.Text;
            issue.IssueStatusId = status.Id;

            string check = fakeIssueRepo.Add(issue);
            if (!string.IsNullOrEmpty(check))
            {
                MessageBox.Show(check, "Attention");
                return;
            }
            Close();
        }
    }
}
