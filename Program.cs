using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;

namespace CloudinaryMediaUpload
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("cloud_name", "api_key", "api_secret");
            Cloudinary cloud = new Cloudinary(account);
            var uploadParams = new VideoUploadParams()
            {
                File = new FileDescription(@"video path"),
                
            };
            var uploadParam = new ImageUploadParams()
            {
                File = new FileDescription(@"image path"),

            };
            var uploadResult = cloud.Upload(uploadParams);
            var upload = cloud.Upload(uploadParam);
            Console.Read();
        }
    }
}
