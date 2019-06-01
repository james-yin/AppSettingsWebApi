using System.Collections.Generic;

namespace AppSettingsWebApi.Models
{
    public class FileUploadSettings
    {
        public int FileSizeLimitInMB { get; set; }
        public string FileTypesAllowed { get; set; }
        public List<string> FileTypesAllowedList { get; set; }
    }
}