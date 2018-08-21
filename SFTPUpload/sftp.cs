using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SFTPUpload.Program;


class Sftp
{
    public static void UploadSFTPFile(SftpInfo info)
    {
        try
        {
            using (SftpClient client = new SftpClient(info.Host, info.Port, info.UserName, info.Password))
            {
                client.Connect();
                client.ChangeDirectory(info.Destination);
                using (FileStream fs = new FileStream(info.Sourcefile, FileMode.Open))
                {
                    client.BufferSize = 4 * 1024;
                    client.UploadFile(fs, Path.GetFileName(info.Sourcefile));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An Error has Occured: " + ex);
        }
    }
}

