using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6
{
    public partial class FormIssueModify : Form
    {
        AppUser _CurrentAppUser;
        FakeIssueStatusRepository issueStatusRepo = new FakeIssueStatusRepository();
        FakePreferenceRepository fakePreference = new FakePreferenceRepository();
            
        public Issue _SelectedIssue;
        public FormIssueModify(AppUser appuser)
        {
            InitializeComponent();
            _CurrentAppUser = appuser;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormIssueModify_Load(object sender, EventArgs e)
        {
            CenterToParent();
            string preferredProjectId = fakePreference.GetPreference(_CurrentAppUser.UserName,
                                                               FakePreferenceRepository.PREFERENCE_PROJECT_ID);

            Int32.TryParse(preferredProjectId, out int ProjectId);
            FakeIssueRepository fakeIssueRepo = new FakeIssueRepository();

            dataGridView1.Columns.Add("I", "ID");
            dataGridView1.Columns.Add("T", "Title");
            dataGridView1.Columns.Add("DDate", "DiscoveryDate");
            dataGridView1.Columns.Add("D", "Discoverer");
            dataGridView1.Columns.Add("ID", "InitialDescrition");
            dataGridView1.Columns.Add("C", "Component");
            dataGridView1.Columns.Add("S", "Status");
            List<Issue> issues = fakeIssueRepo.GetAll(ProjectId);
            foreach (Issue i in issues)
            {
                dataGridView1.Rows.Add(i.Id, i.Title, i.DiscoveryDate, i.Discoverer, i.InitialDescription, i.Component, issueStatusRepo.GetValueById(i.IssueStatusId));
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string preferredProjectId = fakePreference.GetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID);

            Int32.TryParse(preferredProjectId, out int ProjectId);
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                _SelectedIssue = new Issue
                {
                    Id = (int)row.Cells[0].Value,
                    ProjectId = ProjectId,
                    Title = (string)row.Cells[1].Value,
                    DiscoveryDate = (DateTime)row.Cells[2].Value,
                    Discoverer = (string)row.Cells[3].Value,
                    InitialDescription = (string)row.Cells[4].Value,
                    Component = (string)row.Cells[5].Value,
                    IssueStatusId = issueStatusRepo.GetIdByStatus((string)row.Cells[6].Value),
                };

            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
