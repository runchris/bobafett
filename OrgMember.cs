﻿using Octokit;
namespace GitHubApp
{
    class OrgMember
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Membership{ get; set; }
    }
}
