using System.Windows.Forms;

namespace P7
{
    public partial class FormMain : Form
    {
        private AppUser _CurrentAppUser = new AppUser();
        public FormMain()
        {
            InitializeComponent();
        }

        private void preferencesCreateProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateProject form = new FormCreateProject();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            // Force the user to login successfully or abort the application
            DialogResult isOK = DialogResult.OK;
            while (!_CurrentAppUser.IsAuthenticated && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentAppUser = login._CurrentAppUser;
                login.Dispose();
            }
            if (isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            this.Text = "Main - No Project Selected";
            while (selectAProject() == "")
            {
                DialogResult result = MessageBox.Show("A project must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
        }

        private void preferencesSelectProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            selectAProject();
        }

        private string selectAProject()
        {
            string selectedProject = "";
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_NAME,
                                                   form._SelectedProjectName);
                int selectedProjectId = form._SelectedProjectId;
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID,
                                                   selectedProjectId.ToString());
                this.Text = "Main - " + form._SelectedProjectName;
                selectedProject = form._SelectedProjectName;
            }
            form.Dispose();
            return selectedProject;
        }

        private void preferencesModifyProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyProject form = new FormModifyProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void preferencesRemoveProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRemoveProject form = new FormRemoveProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesDashboardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormIssueDashboard form = new FormIssueDashboard(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormIssueRecord form = new FormIssueRecord(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormIssueModify form = new FormIssueModify(_CurrentAppUser);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                FormIssueModifyRecord form2 = new FormIssueModifyRecord(form._SelectedIssue);
                form2.ShowDialog();
                form2.Dispose();
            }
            form.Dispose();
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormIssueModify form = new FormIssueModify(_CurrentAppUser);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                result =  MessageBox.Show($"Are you sure you want to remove: {form._SelectedIssue.Title}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FakeIssueRepository issueRepo = new FakeIssueRepository();
                    issueRepo.Remove(form._SelectedIssue);
                }
                else
                    MessageBox.Show("Remove Canceled.", "Attention");
            }
            form.Dispose();
        }

        private void createToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            FormCreateFeature form = new FormCreateFeature(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void modifyToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            FormSelectFeature sForm = new FormSelectFeature(_CurrentAppUser);
            DialogResult result = sForm.ShowDialog();
            Feature f = sForm._SelectedIssue;
            sForm.Dispose();
            if (result == DialogResult.OK)
            {
                FormModifyFeature form = new FormModifyFeature(f);
                form.ShowDialog();
                form.Dispose();
            }
        }

        private void removeToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            FormSelectFeature sForm = new FormSelectFeature(_CurrentAppUser);
            DialogResult result = sForm.ShowDialog();
            Feature f = sForm._SelectedIssue;
            sForm.Dispose();
            if (result == DialogResult.OK)
            {
                result = MessageBox.Show($"Are you sure you want to remove {f.Title}?", "Question", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FakeFeatureRepository fakeRepo = new FakeFeatureRepository();
                    fakeRepo.Remove(f);
                }

            }
        }

        private void createToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateRequirement form = new FormCreateRequirement(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void modifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyRequirement form = new FormModifyRequirement(_CurrentAppUser);
            DialogResult result = form.ShowDialog();
            Requirement r = form._SelectedReq;
            form.Dispose();
            if (result == DialogResult.OK)
            {
                FormModifyRequirementText mForm = new FormModifyRequirementText(r, _CurrentAppUser);
                mForm.ShowDialog();
                mForm.Dispose();
            }

        }

        private void removeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyRequirement form = new FormModifyRequirement(_CurrentAppUser);
            DialogResult result = form.ShowDialog();
            Requirement r = form._SelectedReq;
            form.Dispose();
            if (result == DialogResult.OK)
            {
                result = MessageBox.Show($"Are you sure you want to remove: {r.Statement}?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FakeRequirementRepository repo = new FakeRequirementRepository();
                    repo.Remove(r);
                }
            }
        }
    }
}
