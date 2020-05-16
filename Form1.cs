using AI_EstimateManday.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_EstimateManday
{
    public partial class Form1 : Form
    {
        MLService ml;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowe_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDataset.Text = dialog.FileName;
                    ml = new MLService();
                }
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtDataset.Text))
            {
                string rawSource = File.ReadAllText(txtDataset.Text);
                int iteration = int.Parse(txtIteration.Text);
                List<MandayDataSet> dataset = JsonConvert.DeserializeObject<List<MandayDataSet>>(rawSource);
                double[] weiths = ml.Train(dataset, iteration);
                lblW_dev_level.Text =string.Format("{0:0.000}", weiths[0]);
                lblW_manday.Text = string.Format("{0:0.000}", weiths[1]);
                lblW_Skill.Text = string.Format("{0:0.000}", weiths[2]);
                lblW_complete.Text = string.Format("{0:0.000}", weiths[3]);
            }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (ml != null)
            {
                double[] input = new double[] { double.Parse(txtDevLevel.Text), double.Parse(txtManday.Text), double.Parse(txtSkillCompatible.Text), double.Parse(txtPercentComplete.Text) };
                double predict = ml.Predict(input);
                double md = Double.Parse(txtManday.Text);
                if (predict >= 0.55)
                {
                    lblSuggestion.Text =  $"{md} Mds";
                }
                else if (predict >= 0.54)
                {
                    

                    lblSuggestion.Text = md + (md * 10 / 100) + " Mds";
                }
                else if (predict > 0.53)
                {
                   

                    lblSuggestion.Text = md + (md * 30 / 100) + " Mds";
                }
                else
                {
                    lblSuggestion.Text = md + (md * 50 / 100) + " Mds";
                }
            }
        }
    }
}
