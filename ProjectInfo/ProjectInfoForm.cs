using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectInfo
{
    public partial class ProjectInfoForm : Form
    {
        ProjectInfoClass projectInfo;

        public ProjectInfoForm()
        {
            InitializeComponent();

            projectInfo = new ProjectInfoClass();
        }

        #region Private

        private void RenameSelectedFile(string newFileName)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = ofd.FileName;

                FileInfo selectedFileInfo = new FileInfo(fileName);
                string selectedFileExtension = selectedFileInfo.Extension;

                DirectoryInfo parentDirectoryInfo = selectedFileInfo.Directory;
                string parentDirectoryPath = parentDirectoryInfo.FullName;

                string renamePath = GenerateRenamePath(parentDirectoryPath, newFileName, selectedFileExtension);

                if (NotFileNameDuplicate(renamePath))
                {
                    try
                    {
                        // 2019-1-24
                        // https://stackoverflow.com/questions/3218910/rename-a-file-in-c-sharp
                        File.Move(fileName, renamePath);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Fail to Rename the file");
                    }
                }

                else
                {
                    MessageBox.Show("Error: File with same Name Already Exist");
                }
            }

            /*
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string fileName = ofd.FileName;

                MessageBox.Show(fileName);

                if ( File.Exists(ofd.SelectedPath) )
                {
                    DirectoryInfo parentDirectoryInfo = new FileInfo(ofd.SelectedPath).Directory;
                    string parentDirectoryPath = parentDirectoryInfo.FullName;

                    string renamePath = GenerateRenamePath(parentDirectoryPath, newFileName);

                    if ( NotFileNameDuplicate( renamePath ) )
                    {
                        File.Move(ofd.SelectedPath, renamePath);
                    }

                    else
                    {
                        MessageBox.Show("Error: File Aleady Exist");
                    }
                }

                else if ( Directory.Exists(ofd.SelectedPath) )
                {
                    // Get the directory
                    DirectoryInfo parentDirectoryInfo = new DirectoryInfo(ofd.SelectedPath).Parent;
                    string parentDirectoryPath = parentDirectoryInfo.FullName;

                    string renamePath = GenerateRenamePath(parentDirectoryPath, newFileName);

                    if ( NotDirectoryNameDuplicate( renamePath ) )
                    {
                        Directory.Move(ofd.SelectedPath, renamePath);
                    }

                    else
                    {
                        MessageBox.Show("Error Directory Already Exist");
                    }
                }

                else
                {
                    MessageBox.Show("Error: Selected File Cannot be recognized");
                }
                

            }*/

            
        }

        private Boolean NotDirectoryNameDuplicate (string directoryPath)
        {
            if ( Directory.Exists(directoryPath) )
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private Boolean NotFileNameDuplicate (string filePath)
        {
            if ( File.Exists(filePath) )
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private string GenerateRenamePath (string parentDirectoryPath, string fileName, string extension)
        {
            string renamePath = parentDirectoryPath + "/" + fileName + extension;

            return renamePath;
        }

        #endregion Private

        #region Event

        private void projNameTextBox_TextChanged(object sender, EventArgs e)
        {
            projectInfo.Name = projNameTextBox.Text;
        }

        private void projTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            projectInfo.Type = projTypeTextBox.Text;
        }

        private void projDesTextBox_TextChanged(object sender, EventArgs e)
        {
            projectInfo.Description = projDesTextBox.Text;
        }

        private void projUserTextBox_TextChanged(object sender, EventArgs e)
        {
            projectInfo.User = projUserTextBox.Text;
        }

        private void projDateTextBox_TextChanged(object sender, EventArgs e)
        {
            projectInfo.Date = projDateTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //string fileName = projectInfo.GenerateFileName();

            //MessageBox.Show(fileName);

            if ( projectInfo.FileNameValid() )
            {
                string fileName = projectInfo.GenerateFileName();

                //MessageBox.Show(fileName);

                RenameSelectedFile(fileName); 
            }

            else
            {
                string errorMessage = "Error:";

                if ( !projectInfo.NameNotEmpty() )
                {
                    errorMessage += Environment.NewLine + "Project Name Cannot Be Empty";
                }

                if ( !projectInfo.TypeNotEmpty())
                {
                    errorMessage += Environment.NewLine + "Project Type Cannot Be Empty";
                }

                MessageBox.Show(errorMessage);
            }
        }

        private void getDateButton_Click(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString("yyyy-MM-dd");

            projDateTextBox.Text = date;
        }

        #endregion Event

    }
}
