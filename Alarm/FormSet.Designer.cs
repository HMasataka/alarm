
namespace Alarm
{
    partial class FormSet
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
            this.radioButtonAlarm = new System.Windows.Forms.RadioButton();
            this.numericUpDownAlmHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlmMnt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimMnt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimSec = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioButtonTimer = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimSec)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonAlarm
            // 
            this.radioButtonAlarm.AutoSize = true;
            this.radioButtonAlarm.Location = new System.Drawing.Point(164, 58);
            this.radioButtonAlarm.Name = "radioButtonAlarm";
            this.radioButtonAlarm.Size = new System.Drawing.Size(84, 29);
            this.radioButtonAlarm.TabIndex = 0;
            this.radioButtonAlarm.TabStop = true;
            this.radioButtonAlarm.Text = "Alarm";
            this.radioButtonAlarm.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAlmHour
            // 
            this.numericUpDownAlmHour.Location = new System.Drawing.Point(164, 122);
            this.numericUpDownAlmHour.Name = "numericUpDownAlmHour";
            this.numericUpDownAlmHour.Size = new System.Drawing.Size(180, 31);
            this.numericUpDownAlmHour.TabIndex = 2;
            this.numericUpDownAlmHour.ValueChanged += new System.EventHandler(this.NumericUpDownAlm_ValueChanged);
            // 
            // numericUpDownAlmMnt
            // 
            this.numericUpDownAlmMnt.Location = new System.Drawing.Point(164, 207);
            this.numericUpDownAlmMnt.Name = "numericUpDownAlmMnt";
            this.numericUpDownAlmMnt.Size = new System.Drawing.Size(180, 31);
            this.numericUpDownAlmMnt.TabIndex = 3;
            this.numericUpDownAlmMnt.ValueChanged += new System.EventHandler(this.NumericUpDownAlm_ValueChanged);
            // 
            // numericUpDownTimMnt
            // 
            this.numericUpDownTimMnt.Location = new System.Drawing.Point(423, 122);
            this.numericUpDownTimMnt.Name = "numericUpDownTimMnt";
            this.numericUpDownTimMnt.Size = new System.Drawing.Size(180, 31);
            this.numericUpDownTimMnt.TabIndex = 4;
            this.numericUpDownTimMnt.ValueChanged += new System.EventHandler(this.NumericUpDownTim_ValueChanged);
            // 
            // numericUpDownTimSec
            // 
            this.numericUpDownTimSec.Location = new System.Drawing.Point(423, 207);
            this.numericUpDownTimSec.Name = "numericUpDownTimSec";
            this.numericUpDownTimSec.Size = new System.Drawing.Size(180, 31);
            this.numericUpDownTimSec.TabIndex = 5;
            this.numericUpDownTimSec.ValueChanged += new System.EventHandler(this.NumericUpDownTim_ValueChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(164, 330);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 34);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(423, 330);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimer
            // 
            this.radioButtonTimer.AutoSize = true;
            this.radioButtonTimer.Location = new System.Drawing.Point(423, 58);
            this.radioButtonTimer.Name = "radioButtonTimer";
            this.radioButtonTimer.Size = new System.Drawing.Size(81, 29);
            this.radioButtonTimer.TabIndex = 8;
            this.radioButtonTimer.TabStop = true;
            this.radioButtonTimer.Text = "Timer";
            this.radioButtonTimer.UseVisualStyleBackColor = true;
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonTimer);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownTimSec);
            this.Controls.Add(this.numericUpDownTimMnt);
            this.Controls.Add(this.numericUpDownAlmMnt);
            this.Controls.Add(this.numericUpDownAlmHour);
            this.Controls.Add(this.radioButtonAlarm);
            this.Name = "FormSet";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAlarm;
        private System.Windows.Forms.NumericUpDown numericUpDownAlmHour;
        private System.Windows.Forms.NumericUpDown numericUpDownAlmMnt;
        private System.Windows.Forms.NumericUpDown numericUpDownTimMnt;
        private System.Windows.Forms.NumericUpDown numericUpDownTimSec;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButtonTimer;
    }
}