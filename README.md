GitHubApp will:
1. Get the public and private members from an organization utilizing the GitHub API.
2. Get the names and emails of each member.
3. Determine which members do not have names on their GitHub profiles.
4. Members without names that have emails listed can be sent an email with instructions for adding a name to their profile.
5. The list of members without names can be posted to an AWS S3 bucket in a text file.

Assumptions:
1. The requestor of information must be an organization member to have access to the private members.
2. If the requestor is not a member of the organization, only the public members will be visible to the application.
3. If the requestor is a member of the organization, both public and private members will be visible to the application.
4. Members without names that are also missing an email address are omitted from the list of nameless users. Members without emails cannot be contacted.

Running the app:
1. This app will only run on a PC with Windows 7 or 10.
2. Download the source code from GitHub.
3. Unzip the contents to a location of your choosing.
4. Open the project folder and navigate to \..\bin\Debug.
5. Under the bin\Debug folder, find GitHubApp.exe.
6. Launch the application by double-clicking GitHubApp.exe.
7. In the application UI, enter the credentials for GitHub and AWS.
8. Search for an organization.
9. If the organization exists, the application will download the user information and populate the data grids.
10. After the download is complete, click the "Upload Nameless Member List to AWS" button.
11. For email functionality, email host information will need to be entered. Caution: This will send emails to each user on the list of users without names.