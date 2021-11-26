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
    public partial class FormCreateRequirement : Form
    {
        AppUser _CurrentAppUser;
        int _ProjectId;
        public FormCreateRequirement(AppUser user)
        {
            InitializeComponent();
            _CurrentAppUser = user;

            FakePreferenceRepository fakePreference = new FakePreferenceRepository();
            string preferredProjectId = fakePreference.GetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID);

            Int32.TryParse(preferredProjectId, out _ProjectId);
        }

        private void FormCreateRequirement_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FakeFeatureRepository fakeRepo = new FakeFeatureRepository();
            comboBox1.DataSource = fakeRepo.GetAll(_ProjectId);
            comboBox1.ValueMember = "Title";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "<Make Selection>";
            comboBox1.Select();
            textBox1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Feature f = comboBox1.SelectedItem as Feature;
            FakeRequirementRepository fakeRepo = new FakeRequirementRepository();
            string check = fakeRepo.Add(new Requirement { Id = 0, FeatureId = f.Id, ProjectId = _ProjectId, Statement = textBox1.Text });
            if (check != FakeRequirementRepository.NO_ERROR)
            {
                MessageBox.Show(check, "Attention");
                return;
            }
            this.Close();
        }
    }
}
