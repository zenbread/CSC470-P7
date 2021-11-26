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
    public partial class FormModifyRequirementText : Form
    {
        AppUser _CurrentAppUser;
        int _ProjectId;
        Requirement _SelectedReq;
        FakeRequirementRepository fakeReqRepo;
        public FormModifyRequirementText(Requirement req, AppUser user)
        {
            InitializeComponent();
            _CurrentAppUser = user;
            _SelectedReq = req;

            FakePreferenceRepository fakePreference = new FakePreferenceRepository();
            string preferredProjectId = fakePreference.GetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            fakeReqRepo = new FakeRequirementRepository();
            Int32.TryParse(preferredProjectId, out _ProjectId);
        }

        private void FormCreateRequirement_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FakeFeatureRepository fakeRepo = new FakeFeatureRepository();
            comboBox1.DataSource = fakeRepo.GetAll(_ProjectId);
            comboBox1.ValueMember = "Title";
            int index = comboBox1.FindString(fakeRepo.GetFeatureById(_SelectedReq.ProjectId, _SelectedReq.FeatureId).Title);
            comboBox1.SelectedIndex = index;
            comboBox1.Select();
            textBox1.Text = _SelectedReq.Statement;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Feature f = comboBox1.SelectedItem as Feature;
            _SelectedReq.Statement = textBox1.Text;
            _SelectedReq.FeatureId = f.Id;
            string check = fakeReqRepo.Modify(_SelectedReq);
            if (check != FakeRequirementRepository.NO_ERROR)
            {
                MessageBox.Show(check, "Attention");
                return;
            }
            this.Close();
        }
    }
}
