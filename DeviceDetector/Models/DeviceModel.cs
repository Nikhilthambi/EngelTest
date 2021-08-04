using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceDetector.Models
{
    public class DeviceModel
    {
        public string UserAgent { get; set; }
        public string Os { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }
        public string Os_Version { get; set; }
        public string Browser_Version { get; set; }
        public string DeviceType { get; set; }
        public string Orientation { get; set; }
    }
}
