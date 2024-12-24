
namespace StoneshardSaveScum
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxSaveLoc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxBackUpLoc = new TextBox();
            buttonChooseSaveLoc = new Button();
            buttonChooseBackUpLoc = new Button();
            buttonMakeBackUp = new Button();
            buttonRestoreExitSave = new Button();
            SuspendLayout();
            // 
            // textBoxSaveLoc
            // 
            textBoxSaveLoc.Enabled = false;
            textBoxSaveLoc.Location = new Point(156, 12);
            textBoxSaveLoc.Multiline = true;
            textBoxSaveLoc.Name = "textBoxSaveLoc";
            textBoxSaveLoc.PlaceholderText = "eg: C:\\Users\\Username\\AppData\\Local\\StoneShard\\characters_v1\\character_1\\exitsave_1";
            textBoxSaveLoc.ReadOnly = true;
            textBoxSaveLoc.Size = new Size(497, 23);
            textBoxSaveLoc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 15);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 1;
            label1.Text = "Stoneshard Save Location:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 54);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 3;
            label2.Text = "Backup Save Location:";
            // 
            // textBoxBackUpLoc
            // 
            textBoxBackUpLoc.Enabled = false;
            textBoxBackUpLoc.Location = new Point(156, 51);
            textBoxBackUpLoc.Name = "textBoxBackUpLoc";
            textBoxBackUpLoc.PlaceholderText = "Any folder. eg: C:\\Users\\Username\\Games\\Save\\Stoneshard";
            textBoxBackUpLoc.ReadOnly = true;
            textBoxBackUpLoc.Size = new Size(497, 23);
            textBoxBackUpLoc.TabIndex = 2;
            // 
            // buttonChooseSaveLoc
            // 
            buttonChooseSaveLoc.Location = new Point(659, 15);
            buttonChooseSaveLoc.Name = "buttonChooseSaveLoc";
            buttonChooseSaveLoc.Size = new Size(119, 23);
            buttonChooseSaveLoc.TabIndex = 4;
            buttonChooseSaveLoc.Text = "Select Folder";
            buttonChooseSaveLoc.UseVisualStyleBackColor = true;
            buttonChooseSaveLoc.Click += buttonChooseSaveLoc_Click;
            // 
            // buttonChooseBackUpLoc
            // 
            buttonChooseBackUpLoc.Location = new Point(659, 51);
            buttonChooseBackUpLoc.Name = "buttonChooseBackUpLoc";
            buttonChooseBackUpLoc.Size = new Size(119, 23);
            buttonChooseBackUpLoc.TabIndex = 5;
            buttonChooseBackUpLoc.Text = "Select Folder";
            buttonChooseBackUpLoc.UseVisualStyleBackColor = true;
            buttonChooseBackUpLoc.Click += buttonChooseBackUpLoc_Click;
            // 
            // buttonMakeBackUp
            // 
            buttonMakeBackUp.Location = new Point(5, 91);
            buttonMakeBackUp.Name = "buttonMakeBackUp";
            buttonMakeBackUp.Size = new Size(242, 69);
            buttonMakeBackUp.TabIndex = 6;
            buttonMakeBackUp.Text = "Backup (require Save and Exit first)";
            buttonMakeBackUp.UseVisualStyleBackColor = true;
            buttonMakeBackUp.Click += buttonMakeBackUp_Click;
            // 
            // buttonRestoreExitSave
            // 
            buttonRestoreExitSave.Location = new Point(275, 91);
            buttonRestoreExitSave.Name = "buttonRestoreExitSave";
            buttonRestoreExitSave.Size = new Size(242, 69);
            buttonRestoreExitSave.TabIndex = 7;
            buttonRestoreExitSave.Text = "Restore Exit Save from Backup1 (will overwrite exist one)";
            buttonRestoreExitSave.UseVisualStyleBackColor = true;
            buttonRestoreExitSave.Click += buttonRestoreExitSave_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRestoreExitSave);
            Controls.Add(buttonMakeBackUp);
            Controls.Add(buttonChooseBackUpLoc);
            Controls.Add(buttonChooseSaveLoc);
            Controls.Add(label2);
            Controls.Add(textBoxBackUpLoc);
            Controls.Add(label1);
            Controls.Add(textBoxSaveLoc);
            Name = "MainApp";
            Text = "Stoneshard Save Tool";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox textBoxSaveLoc;
        private Label label1;
        private Label label2;
        private TextBox textBoxBackUpLoc;
        private Button buttonChooseSaveLoc;
        private Button buttonChooseBackUpLoc;
        private Button buttonMakeBackUp;
        private Button buttonRestoreExitSave;
    }
}
