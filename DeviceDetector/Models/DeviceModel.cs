using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceDetector.Models
{
    public class DeviceModel
    {
        [Required]
        public string UserAgent { get; set; }
        [Required]
        public string Os { get; set; }
        [Required]
        public string Browser { get; set; }
        [Required]
        public string Device { get; set; }
        [Required]
        public string Os_Version { get; set; }
        [Required]
        public string Browser_Version { get; set; }
        [Required]
        public string DeviceType { get; set; }
        [Required]
        public string Orientation { get; set; }
    }

    public class Model
    {
        public string UserAgent { get; set; }
        public string Os { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }
        public string Os_version { get; set; }
        public string Browser_version { get; set; }
        public string DeviceType { get; set; }
        public string Orientation { get; set; }
    }
}
