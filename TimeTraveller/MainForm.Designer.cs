using System.Drawing;
using System.Windows.Forms;

namespace TimeTraveller
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            btnTravel = new Button();
            label2 = new Label();
            numHours = new NumericUpDown();
            cbAuto = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 16);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Hours:";
            // 
            // btnTravel
            // 
            btnTravel.Location = new Point(12, 12);
            btnTravel.Name = "btnTravel";
            btnTravel.Size = new Size(93, 23);
            btnTravel.TabIndex = 2;
            btnTravel.Text = "Time Travel";
            btnTravel.UseVisualStyleBackColor = true;
            btnTravel.Click += btnTravel_Click;
            // 
            // label2
            // 
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(305, 140);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // numHours
            // 
            numHours.Location = new Point(159, 14);
            numHours.Maximum = new decimal(new int[] { 32768, 0, 0, 0 });
            numHours.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            numHours.Name = "numHours";
            numHours.Size = new Size(79, 23);
            numHours.TabIndex = 1;
            numHours.TextAlign = HorizontalAlignment.Right;
            numHours.ValueChanged += numHours_ValueChanged;
            // 
            // cbAuto
            // 
            cbAuto.AutoSize = true;
            cbAuto.Location = new Point(265, 15);
            cbAuto.Name = "cbAuto";
            cbAuto.Size = new Size(52, 19);
            cbAuto.TabIndex = 4;
            cbAuto.Text = "Auto";
            cbAuto.UseVisualStyleBackColor = true;
            cbAuto.CheckedChanged += cbAuto_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 214);
            Controls.Add(cbAuto);
            Controls.Add(numHours);
            Controls.Add(label2);
            Controls.Add(btnTravel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "TimeMachine";
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHours;
        private CheckBox cbAuto;
    }
}