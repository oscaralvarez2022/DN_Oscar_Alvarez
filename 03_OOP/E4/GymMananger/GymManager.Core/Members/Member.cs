using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Member
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int CityId { get; set; }
        public string Email { get; set; }
        public bool AllowNewsletter { get; set; }

    }

    public static class FileLogger
    {
        private const string FilePath = "log.txt";
        public static void Log(string messsage)
        {
            using var fileStream = new FileStream(FilePath, FileMode.Append);
            using var writter = new StreamWriter(fileStream);
            writter.WriteLine(messsage);
        }
    }

}
