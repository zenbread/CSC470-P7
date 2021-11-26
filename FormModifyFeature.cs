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
    public partial class FormModifyFeature : Form
    {
        Feature _feature;
        public FormModifyFeature(Feature feature)
        {
            InitializeComponent();
            _feature = feature;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModifyFeature_Load(object sender, EventArgs e)
        {
            CenterToParent();
            textBox1.Text = _feature.Title;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _feature.Title = textBox1.Text;
            FakeFeatureRepository fakeFeatRepo = new FakeFeatureRepository();
            string check = fakeFeatRepo.Modify(_feature);
            if (check != FakeFeatureRepository.NO_ERROR)
            {
                MessageBox.Show(check, "Attention");
                return;
            }
            this.Close();
        }
    }
}
