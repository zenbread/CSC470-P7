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
    public partial class FormModifyRequirement : Form
    {
        AppUser _CurrentAppUser;
        int _ProjectId;
        public Requirement _SelectedReq;
        FakeRequirementRepository fakeReqRepo;
        private bool first = true;
        List<Requirement> data = new List<Requirement>();
        public FormModifyRequirement(AppUser user)
        {
            InitializeComponent();
            _CurrentAppUser = user;

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
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "<Make Selection>";
            comboBox1.Select();
            button2.Enabled = false;
            first = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!first)
            {
                if (!(comboBox1.SelectedItem is Feature f))
                    return;
                List<Requirement> reqs = fakeReqRepo.GetAll(_ProjectId);
                data.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("I", "Id");
                dataGridView1.Columns.Add("T", "Title");
                foreach (Requirement r in reqs)
                {
                    if (r.FeatureId == f.Id)
                        dataGridView1.Rows.Add(r.Id, r.Statement);
                }
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int id =  (int)r.Cells[0].Value;
                _SelectedReq = fakeReqRepo.GetRequirementById(id);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
