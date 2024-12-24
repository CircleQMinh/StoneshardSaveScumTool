namespace StoneshardSaveScum
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonChooseBackUpLoc.Focus();
        }

        private void buttonChooseSaveLoc_Click(object sender, EventArgs e)
        {
            // Create an instance of FolderBrowserDialog
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Optional: Set the description for the dialog
                folderDialog.Description = "Select a folder";

                // Show the dialog and check if the user clicked OK
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected folder path
                    string selectedPath = folderDialog.SelectedPath;

                    // Display the folder path in the TextBox
                    textBoxSaveLoc.Text = selectedPath;
                }
            }
        }

        private void buttonChooseBackUpLoc_Click(object sender, EventArgs e)
        {
            // Create an instance of FolderBrowserDialog
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Optional: Set the description for the dialog
                folderDialog.Description = "Select a folder";

                // Show the dialog and check if the user clicked OK
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected folder path
                    string selectedPath = folderDialog.SelectedPath;

                    // Display the folder path in the TextBox
                    textBoxBackUpLoc.Text = selectedPath;
                }
            }
        }

        private void buttonMakeBackUp_Click(object sender, EventArgs e)
        {
            var savePath = textBoxSaveLoc.Text;
            var backUpPath = textBoxBackUpLoc.Text;
            if (string.IsNullOrEmpty(savePath) || string.IsNullOrEmpty(backUpPath))
            {
                MessageBox.Show("Please select save file location and back up location!");
                return;
            }

            if (!QuickAction.IsValidFolderPath(savePath))
            {
                MessageBox.Show("Save file location is not valid!");
                return;
            }
            var slot1 = Path.Combine(backUpPath, QuickAction.SaveSlotOne);
            var slot2 = Path.Combine(backUpPath, QuickAction.SaveSlotTwo);
            var slot3 = Path.Combine(backUpPath, QuickAction.SaveSlotThree);
            var slot4 = Path.Combine(backUpPath, QuickAction.SaveSlotFour);
            var slot5 = Path.Combine(backUpPath, QuickAction.SaveSlotFive);

            QuickAction.CopyAllFileFromAToB(slot4, slot5);
            QuickAction.CopyAllFileFromAToB(slot3, slot4);
            QuickAction.CopyAllFileFromAToB(slot2, slot3);
            QuickAction.CopyAllFileFromAToB(slot1, slot2);
            QuickAction.CopyAllFileFromAToB(savePath, slot1);

            MessageBox.Show("Save current exit save to slot 1!");
        }

        private void buttonRestoreExitSave_Click(object sender, EventArgs e)
        {
            var savePath = textBoxSaveLoc.Text;
            var backUpPath = textBoxBackUpLoc.Text;
            if (string.IsNullOrEmpty(savePath) || string.IsNullOrEmpty(backUpPath))
            {
                MessageBox.Show("Please select save file location and back up location!");
                return;
            }
            var slot1 = Path.Combine(backUpPath, QuickAction.SaveSlotOne);

            if (!QuickAction.IsValidFolderPath(slot1))
            {
                MessageBox.Show("Save file location is not valid!");
                return;
            }

            QuickAction.CopyAllFileFromAToB(slot1 , savePath);
            MessageBox.Show("Create a exit save using BackUp1!");
        }
    }
}
