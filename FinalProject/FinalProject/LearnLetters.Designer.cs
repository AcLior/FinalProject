
namespace FinalProject
{
    partial class LearnLetters
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLetters = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picWord = new System.Windows.Forms.PictureBox();
            this.picLetter = new System.Windows.Forms.PictureBox();
            this.txtWord = new System.Windows.Forms.RichTextBox();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLetter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ": בחר אות";
            // 
            // cmbLetters
            // 
            this.cmbLetters.FormattingEnabled = true;
            this.cmbLetters.Items.AddRange(new object[] {
            "א",
            "ב",
            "ג",
            "ד",
            "ה",
            "ו",
            "ז",
            "ח",
            "ט",
            "י",
            "כ",
            "ל",
            "מ",
            "נ",
            "ס",
            "ע",
            "פ",
            "צ",
            "ק",
            "ר",
            "ש",
            "ת"});
            this.cmbLetters.Location = new System.Drawing.Point(667, 64);
            this.cmbLetters.Name = "cmbLetters";
            this.cmbLetters.Size = new System.Drawing.Size(121, 21);
            this.cmbLetters.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSound);
            this.groupBox1.Controls.Add(this.txtWord);
            this.groupBox1.Controls.Add(this.picLetter);
            this.groupBox1.Controls.Add(this.picWord);
            this.groupBox1.Location = new System.Drawing.Point(217, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // picWord
            // 
            this.picWord.Location = new System.Drawing.Point(54, 19);
            this.picWord.Name = "picWord";
            this.picWord.Size = new System.Drawing.Size(145, 125);
            this.picWord.TabIndex = 0;
            this.picWord.TabStop = false;
            // 
            // picLetter
            // 
            this.picLetter.Location = new System.Drawing.Point(230, 43);
            this.picLetter.Name = "picLetter";
            this.picLetter.Size = new System.Drawing.Size(100, 83);
            this.picLetter.TabIndex = 1;
            this.picLetter.TabStop = false;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(34, 150);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(190, 61);
            this.txtWord.TabIndex = 2;
            this.txtWord.Text = "";
            // 
            // btnSound
            // 
            this.btnSound.Image = global::FinalProject.Properties.Resources.sound;
            this.btnSound.Location = new System.Drawing.Point(230, 150);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(75, 61);
            this.btnSound.TabIndex = 3;
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(350, 283);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // LearnLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbLetters);
            this.Controls.Add(this.label1);
            this.Name = "LearnLetters";
            this.Text = "LearnLetters";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLetter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLetters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.RichTextBox txtWord;
        private System.Windows.Forms.PictureBox picLetter;
        private System.Windows.Forms.PictureBox picWord;
        private System.Windows.Forms.Button btnNext;
    }
}