using System;
using System.Collections.Generic;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace GitHubApp
{
    class AWS_Uploader
    {
        private string line = "";

        /// <summary>
        /// Uploads content to an AWS S3 bucket
        /// </summary>
        /// <param name="list">Object list of members without names</param>
        /// <param name="fileName">The filename that will be given to the .txt file</param>
        /// <param name="ACCESS_KEY">AWS Access Key</param>
        /// <param name="SECRET_KEY">AWS Secret Key</param>
        public void UploadFile(List<OrgMember> list, string fileName, string ACCESS_KEY, string SECRET_KEY)
        {
            try
            {
                line = "These members do not have a name on their GitHub accounts:\n" +
                   "Login, Email\n" +
                   "------------\n";

                foreach (OrgMember member in list)
                {
                    line += member.Login + ", " + member.Email + "\n";
                }

                var config = new AmazonS3Config();
                var s3Client = new AmazonS3Client(
                    ACCESS_KEY,
                    SECRET_KEY,
                    RegionEndpoint.USWest2);

                var request = new PutObjectRequest();
                request.BucketName = "chrisrunn";
                request.Key = fileName;
                request.ContentType = "text/plain";
                request.ContentBody = line;
                s3Client.PutObject(request);
            }

            catch (Exception)
            {
                Console.WriteLine("There was an error uploading to AWS.");
            }
        }
    }
}