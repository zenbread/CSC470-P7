using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7
{
    public partial class FormSelectFeature : Form
    {
        AppUser _CurrentUser;
        int _ProjectId;
        public Feature _SelectedIssue = null;
        public FormSelectFeature(AppUser user)
        {
            InitializeComponent();
            _CurrentUser = user;
            FakePreferenceRepository fakePreference = new FakePreferenceRepository();
            string preferredProjectId = fakePreference.GetPreference(_CurrentUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID);

            Int32.TryParse(preferredProjectId, out _ProjectId);
        }


        private void FormSelectFeature_Load(object sender, EventArgs e)
        {
            CenterToParent();

            FakeFeatureRepository featRepo = new FakeFeatureRepository();
            List<Feature> features = featRepo.GetAll(_ProjectId);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = features;
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dataGridView1.SelectedRows)
            {
                Feature f = r.DataBoundItem as Feature;
                _SelectedIssue = f;
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }
    }
}
