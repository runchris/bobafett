using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Octokit;

namespace GitHubApp
{
    public partial class Form1 : Form
    {
        private string organization;
        // GitHub credential
        private static string TOKEN;
        // AWS credentials
        private static string AWS_ACCESS_KEY;
        private static string AWS_SECRET_KEY;
        // Email credentials
        private static string SENDER_ADDRESS;
        private static string SMTP_HOST;
        private static string PORT;
        private static string YOUR_EMAIL_PASSWORD;

        static List<string> orgMemberLoginList = new List<string>();
        static List<OrgMember> orgMemberInfoList = new List<OrgMember>();
        static List<OrgMember> orgMemberWithoutNameList = new List<OrgMember>();

        public Form1()
        {
            InitializeComponent();
            btnSendEmail.Enabled = false;
            btnUploadAWS.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Retrieves the members of an organization via the GitHub API, then iterates through each
        /// member name and downloads the member's information from the GitHub API.
        /// </summary>
        private void GetMembers()
        {
            TOKEN = txtboxGitHubToken.Text;
            organization = txtboxInput.Text;

            try
            {
                orgMemberLoginList.Clear();
                orgMemberInfoList.Clear();
                orgMemberWithoutNameList.Clear();
                btnSendEmail.Enabled = false;
                btnUploadAWS.Enabled = false;
                lblMessage.Text = "Communicating with GitHub API, please wait...";
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;

                var client = new GitHubClient(new ProductHeaderValue("GitHubApp"));
                var tokenAuth = new Credentials(TOKEN);
                client.Credentials = tokenAuth;
                var org = client.Organization.Member.GetAll(organization);
                var memberCount = org.Result.Count;

                foreach (Octokit.User member in org.Result) // Gets the members of the Organization from the API
                {
                    orgMemberLoginList.Add(member.Login); // Stores the logins of the members
                }
                int i = 1;

                foreach (string member in orgMemberLoginList) // Takes each member and gets their info from the API
                {
                    lblMessage.Text = "Downloading " + i + " of " + memberCount + " members from " + organization;

                    var orgMemberInfo = client.User.Get(member);

                    orgMemberInfoList.Add(new OrgMember // Grabs the necessary information from the members
                    {
                        Name = orgMemberInfo.Result.Name,
                        Login = orgMemberInfo.Result.Login,
                        Email = orgMemberInfo.Result.Email,
                        Membership = client.Organization.Member.CheckMemberPublic(organization, member).Result.ToString() // Determines if member is public or private
                    });
                    i++;
                }

                foreach (OrgMember member in orgMemberInfoList) // Converts the membership booleans to strings
                {
                    if (Convert.ToBoolean(member.Membership))
                    {
                        member.Membership = "Public";
                    }
                    else
                    {
                        member.Membership = "Private";
                    }
                }

                btnSendEmail.Enabled = true;
                btnUploadAWS.Enabled = true;
                lblMessage.Text = "Download Complete.";
            }

            catch (AggregateException)
            {
                lblMessage.Text = "";
                MessageBox.Show("The organization does not exist.");
            }

            catch (Exception)
            {
                lblMessage.Text = "";
                MessageBox.Show("Enter the GitHub token.");
            }

            //int noName = orgMemberInfoList.Count(item => item.Name == null && item.Email != null); // only people that can be notified of missing name
            //int noNameOrEmail = orgMemberInfoList.Count(item => item.Name == null && item.Email == null); // people missing name but cannot be notified

            foreach (OrgMember member in orgMemberInfoList)
            {
                if (member.Name == null && member.Email != null) // Grabs the members with that have no names but have emails.
                {
                    orgMemberWithoutNameList.Add(new OrgMember
                    {
                        Name = member.Name,
                        Login = member.Login,
                        Email = member.Email
                    });
                }
            }
            dataGridView1.DataSource = orgMemberInfoList;
            dataGridView2.DataSource = orgMemberWithoutNameList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text != "")
            {
                GetMembers();
            }
            else MessageBox.Show("Enter an organization in the search field");
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            SENDER_ADDRESS = txtboxSenderAddress.Text;
            SMTP_HOST = txtboxSMTP_Host.Text;
            PORT = txtboxPort.Text;
            YOUR_EMAIL_PASSWORD = txtboxEmailPassword.Text;

            if (txtboxSenderAddress.Text == "" || txtboxSMTP_Host.Text == "" || txtboxPort.Text == "" || txtboxEmailPassword.Text == "")
            {
                MessageBox.Show("Enter Email credentials for Email functionality.");
            }
            else
            {
                lblMessageB.Text = "Sending Emails to Members...";

                var email = new EmailClient();

                foreach (OrgMember recipient in orgMemberWithoutNameList)
                {
                    email.SendEmail(SENDER_ADDRESS, recipient.Email, SMTP_HOST, PORT, YOUR_EMAIL_PASSWORD);
                }

                lblMessageB.Text = "";
                MessageBox.Show("The Emails have been sent.");
            }
        }

        private void btnUploadAWS_Click(object sender, EventArgs e)
        {
            AWS_ACCESS_KEY = txtboxAWS_AccessKey.Text;
            AWS_SECRET_KEY = txtboxAWS_SecretKey.Text;

            if (txtboxAWS_AccessKey.Text == "" || txtboxAWS_SecretKey.Text == "")
            {
                MessageBox.Show("Please enter AWS access key and secret key");
            }
            else
            {
                string fileName = organization + "_MembersNoNames.txt";
                var aws = new AWS_Uploader();
                aws.UploadFile(orgMemberWithoutNameList, fileName, AWS_ACCESS_KEY, AWS_SECRET_KEY);
                MessageBox.Show("The file '" + fileName + "' has been uploaded to the AWS S3 bucket.");
            }
        }
    }
}