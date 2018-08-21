using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFTPUpload
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = new SftpInfo()
            {
                Sourcefile = @"C:\someFIle.csv",
                Destination = @"./",
                Host = "192.168.10.185",
                UserName = "username",
                Password = "password",
                Port = 22
            };
              Sftp.UploadSFTPFile(info);
        }
        public class SftpInfo
        {
            public string Sourcefile { get; set; }
            public string Destination { get; set; }
            public string Host { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public int Port { get; set; }
        }
    }
}
