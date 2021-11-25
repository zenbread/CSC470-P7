using System;
using System.Windows.Forms;

namespace P6
{
    public partial class FormIssueDashboard : Form
    {
        AppUser _CurrentAppUser;
        public FormIssueDashboard(AppUser appuser)
        {
            InitializeComponent();
            _CurrentAppUser = appuser;
        }
        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_CurrentAppUser.UserName,
                                                                           FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            FakeIssueRepository issueRepo = new FakeIssueRepository();
            Int32.TryParse(preferredProjectId, out int id);
            labelIssueAmount.Text = issueRepo.GetTotalNumberOfIssues(id).ToString();
            listBoxIssueMonth.DataSource = issueRepo.GetIssuesByMonth(id);
            listBoxIssueDiscoverer.DataSource = issueRepo.GetIssuesByDiscoverer(id);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
