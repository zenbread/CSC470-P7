using System;
using System.Windows.Forms;

namespace P7
{
    public partial class FormCreateFeature : Form
    {
        AppUser _CurrentAppUser;
        public FormCreateFeature(AppUser user)
        {
            InitializeComponent();
            _CurrentAppUser = user;
        }

        private void FormCreateFeature_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository fakeFeatRepo = new FakeFeatureRepository();
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID);

            Int32.TryParse(preferredProjectId, out int ProjectId);
            string check = fakeFeatRepo.Add(new Feature { Id = 0, ProjectId = ProjectId, Title = textBox1.Text });
            if (check != FakeFeatureRepository.NO_ERROR)
            {
                MessageBox.Show(check, "", MessageBoxButtons.OK);
                return;
            }
            this.Close();
        }
    }
}
