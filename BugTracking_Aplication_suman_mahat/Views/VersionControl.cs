using LibGit2Sharp;
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

namespace BugTracking_Aplication_suman_mahat.Views
{
    public partial class VersionControl : Form
    {
        private readonly string _repoSource;
        private readonly UsernamePasswordCredentials _credentials;
        private readonly DirectoryInfo _localFolder;
        private string localfolder;

        public VersionControl(string username, string password, string gitRepoUrl, string localFolder)
        {
            InitializeComponent();
            this.localfolder = localFolder;
            var folder = new DirectoryInfo(localFolder);

            if (!folder.Exists)
            {
                throw new Exception(string.Format("Source folder '{0}' does not exist.", _localFolder));
            }

            _localFolder = folder;

            _credentials = new UsernamePasswordCredentials
            {
                Username = username,
                Password = password
            };

            _repoSource = gitRepoUrl;

        }
        /// <summary>
        /// commit to diractory 
        /// </summary>
        public void PushCommits()
        {
            try {
                using (var repo = new Repository(localfolder))
                {
                    // Write content to file system
                    var content = "Commit this!";
                    File.WriteAllText(Path.Combine(repo.Info.WorkingDirectory, "fileToCommit.txt"), content);

                    // Stage the file
                    repo.Stage("fileToCommit.txt");

                    // Create the committer's signature and commit
                    Signature author = new Signature("sumanmahat", "@sumanmahat", DateTime.Now);
                    Signature committer = author;

                    // Commit to the repository
                    Commit commit = repo.Commit("BugTracking", author, committer);

                    Remote remote = repo.Network.Remotes["origin"];
                    var options = new PushOptions();
                    options.CredentialsProvider = (_url, _user, _cred) =>
                        new UsernamePasswordCredentials { Username = "sumanmahat", Password = "Suman6674" };
                    repo.Network.Push(remote, @"refs/heads/master", options);
                    Console.WriteLine("Pushed to github");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void VersionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
