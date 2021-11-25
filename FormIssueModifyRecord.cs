using System;
using System.Windows.Forms;

namespace P6
{
    public partial class FormIssueModifyRecord : Form
    {
        Issue _Issue;
        FakeIssueRepository fakeIssueRepo = new FakeIssueRepository();
        public FormIssueModifyRecord(Issue issue)
        {
            InitializeComponent();
            _Issue = issue;
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


            textBoxId.Text = _Issue.Id.ToString();
            textBoxTitle.Text = _Issue.Title;
            dateTimePicker1.Value = _Issue.DiscoveryDate;
            comboBoxAuthor.DataSource = fakeAppRepo.GetAll();
            int index = comboBoxAuthor.FindString(_Issue.Discoverer);
            comboBoxAuthor.SelectedIndex = index;
            textBoxComponent.Text = _Issue.Component;
            comboBoxStatus.DataSource = fakeStatusRepo.GetAll();
            index = comboBoxStatus.FindString(fakeStatusRepo.GetValueById(_Issue.IssueStatusId));
            comboBoxStatus.SelectedIndex = index;
            textBoxDescription.Text = _Issue.InitialDescription;
            textBoxTitle.Select();
        }

        private void buttonCreateIssue_Click(object sender, EventArgs e)
        {
            _Issue.Title = textBoxTitle.Text;
            _Issue.DiscoveryDate = dateTimePicker1.Value;
            AppUser appuser = (AppUser)comboBoxAuthor.SelectedItem;
            _Issue.Discoverer = appuser.ToString();
            _Issue.Component = textBoxComponent.Text;
            IssueStatus status = (IssueStatus)comboBoxStatus.SelectedItem;
            _Issue.IssueStatusId = status.Id;
            _Issue.InitialDescription = textBoxDescription.Text;

            fakeIssueRepo.Modify(_Issue);
            Close();
        }
    }
}
