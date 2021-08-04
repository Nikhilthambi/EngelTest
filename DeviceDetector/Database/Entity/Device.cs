using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceDetector.Database.Entity
{
    [Table("Device")]
    public class Device
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeviceId { get; set; }
        [Required]
        [StringLength(200)]
        public string UserAgent { get; set; }
        [Required]
        [StringLength(25)]
        public string OperatingSystem { get; set; }
        [Required]
        [StringLength(25)]
        public string Browser { get; set; }
        [Required]
        [StringLength(25)]
        public string DeviceName { get; set; }
        [Required]
        [StringLength(25)]
        public string OsVersion { get; set; }
        [Required]
        [StringLength(25)]
        public string BrowserVersion { get; set; }
        [Required]
        [StringLength(25)]
        public string DeviceType { get; set; }
        [Required]
        [StringLength(25)]
        public string Orientation { get; set; }
    }
}
