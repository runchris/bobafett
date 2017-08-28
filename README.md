GitHupApp will:
1. Get the public members from an organization utilizing the GitHub API.
2. Get the names and emails of each member.
3. Determine which members do not have names on their GitHub profiles.
4. Members that have emails listed will receive an email with instructions for adding a name to their profile.
5. The list of members without names will be posted to an AWS S3 bucket in a text file.

Assumptions:
1. All members downloaded from the GitHub API are public members. The requestor of information must be an organization member to have access to the private members.
2. Members without names that are also missing an email address are omitted from the list. Members without emails cannot be contacted.

Running the app:
1. Open Visual Studio.
2. Download the source code from GitHub.
3. Unzip the contents to a location of your choosing.
4. In Visual Studio, open the app with the 'GitHubApp.sln' file.
5. Click Start.
6. In the app, enter the credentials for GitHub and AWS.
7. Search for an organization.
