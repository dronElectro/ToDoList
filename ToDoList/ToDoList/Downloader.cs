using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Downloader
    {
        WebClient client = new WebClient();
        string _url;
        string _path;

        public Downloader(string Url, string Path)
        {
            _url = Url;
            _path = Path;
        }

        public bool downloadFile()
        {
            try
            {
                client.DownloadData(_url);

                    string fileName = client.ResponseHeaders["Content-Disposition"]
                        .Substring(client.ResponseHeaders["Content-Disposition"]
                        .IndexOf("filename=") + 9).Replace("\"", "");
                    Console.WriteLine(fileName);
                    client.DownloadFileAsync(new Uri(_url), _path + "\\"+fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //client.DownloadFile(url, folderBrowser.SelectedPath + "\\" + "1.txt");
    }
}
