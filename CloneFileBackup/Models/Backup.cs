using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneFileBackup.Models
{
    public class Backup
    {
        public string NameBackup { get; set; }
        public string PathOrigin { get; set; }
        public string PathDestination { get; set; }
    }
}
