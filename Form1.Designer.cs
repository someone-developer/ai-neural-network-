namespace AI_EstimateManday
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDataset = new System.Windows.Forms.TextBox();
            this.btnBrowe = new System.Windows.Forms.Button();
            this.txtDevLevel = new System.Windows.Forms.TextBox();
            this.txtManday = new System.Windows.Forms.TextBox();
            this.txtSkillCompatible = new System.Windows.Forms.TextBox();
            this.txtPercentComplete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblW_dev_level = new System.Windows.Forms.Label();
            this.lblW_manday = new System.Windows.Forms.Label();
            this.lblW_Skill = new System.Windows.Forms.Label();
            this.lblW_complete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDataset
            // 
            this.txtDataset.Location = new System.Drawing.Point(38, 25);
            this.txtDataset.Name = "txtDataset";
            this.txtDataset.Size = new System.Drawing.Size(549, 20);
            this.txtDataset.TabIndex = 0;
            // 
            // btnBrowe
            // 
            this.btnBrowe.Location = new System.Drawing.Point(593, 22);
            this.btnBrowe.Name = "btnBrowe";
            this.btnBrowe.Size = new System.Drawing.Size(33, 23);
            this.btnBrowe.TabIndex = 1;
            this.btnBrowe.Text = "...";
            this.btnBrowe.UseVisualStyleBackColor = true;
            this.btnBrowe.Click += new System.EventHandler(this.btnBrowe_Click);
            // 
            // txtDevLevel
            // 
            this.txtDevLevel.Location = new System.Drawing.Point(38, 135);
            this.txtDevLevel.Name = "txtDevLevel";
            this.txtDevLevel.Size = new System.Drawing.Size(50, 20);
            this.txtDevLevel.TabIndex = 2;
            // 
            // txtManday
            // 
            this.txtManday.Location = new System.Drawing.Point(104, 135);
            this.txtManday.Name = "txtManday";
            this.txtManday.Size = new System.Drawing.Size(50, 20);
            this.txtManday.TabIndex = 3;
            // 
            // txtSkillCompatible
            // 
            this.txtSkillCompatible.Location = new System.Drawing.Point(171, 135);
            this.txtSkillCompatible.Name = "txtSkillCompatible";
            this.txtSkillCompatible.Size = new System.Drawing.Size(77, 20);
            this.txtSkillCompatible.TabIndex = 4;
            // 
            // txtPercentComplete
            // 
            this.txtPercentComplete.Location = new System.Drawing.Point(273, 135);
            this.txtPercentComplete.Name = "txtPercentComplete";
            this.txtPercentComplete.Size = new System.Drawing.Size(87, 20);
            this.txtPercentComplete.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dev level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Skill compatible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Percent complate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Suggestion Manday:";
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.ForeColor = System.Drawing.Color.Green;
            this.lblSuggestion.Location = new System.Drawing.Point(312, 180);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(77, 31);
            this.lblSuggestion.TabIndex = 11;
            this.lblSuggestion.Text = "1 Md";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Traning Iteration";
            // 
            // txtIteration
            // 
            this.txtIteration.Location = new System.Drawing.Point(42, 69);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(82, 20);
            this.txtIteration.TabIndex = 12;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(130, 66);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(46, 23);
            this.btnTrain.TabIndex = 14;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(366, 133);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(68, 23);
            this.btnPredict.TabIndex = 15;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // lblW_dev_level
            // 
            this.lblW_dev_level.AutoSize = true;
            this.lblW_dev_level.Location = new System.Drawing.Point(42, 158);
            this.lblW_dev_level.Name = "lblW_dev_level";
            this.lblW_dev_level.Size = new System.Drawing.Size(13, 13);
            this.lblW_dev_level.TabIndex = 16;
            this.lblW_dev_level.Text = "0";
            // 
            // lblW_manday
            // 
            this.lblW_manday.AutoSize = true;
            this.lblW_manday.Location = new System.Drawing.Point(108, 158);
            this.lblW_manday.Name = "lblW_manday";
            this.lblW_manday.Size = new System.Drawing.Size(13, 13);
            this.lblW_manday.TabIndex = 17;
            this.lblW_manday.Text = "0";
            // 
            // lblW_Skill
            // 
            this.lblW_Skill.AutoSize = true;
            this.lblW_Skill.Location = new System.Drawing.Point(175, 158);
            this.lblW_Skill.Name = "lblW_Skill";
            this.lblW_Skill.Size = new System.Drawing.Size(13, 13);
            this.lblW_Skill.TabIndex = 18;
            this.lblW_Skill.Text = "0";
            // 
            // lblW_complete
            // 
            this.lblW_complete.AutoSize = true;
            this.lblW_complete.Location = new System.Drawing.Point(279, 158);
            this.lblW_complete.Name = "lblW_complete";
            this.lblW_complete.Size = new System.Drawing.Size(13, 13);
            this.lblW_complete.TabIndex = 19;
            this.lblW_complete.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 249);
            this.Controls.Add(this.lblW_complete);
            this.Controls.Add(this.lblW_Skill);
            this.Controls.Add(this.lblW_manday);
            this.Controls.Add(this.lblW_dev_level);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIteration);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPercentComplete);
            this.Controls.Add(this.txtSkillCompatible);
            this.Controls.Add(this.txtManday);
            this.Controls.Add(this.txtDevLevel);
            this.Controls.Add(this.btnBrowe);
            this.Controls.Add(this.txtDataset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataset;
        private System.Windows.Forms.Button btnBrowe;
        private System.Windows.Forms.TextBox txtDevLevel;
        private System.Windows.Forms.TextBox txtManday;
        private System.Windows.Forms.TextBox txtSkillCompatible;
        private System.Windows.Forms.TextBox txtPercentComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblW_dev_level;
        private System.Windows.Forms.Label lblW_manday;
        private System.Windows.Forms.Label lblW_Skill;
        private System.Windows.Forms.Label lblW_complete;
    }
}

