using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteGallery.Models {
    public class Website {
        public int Id { get; set; }
        public string ProjectTitle { get; set; }
        public Developer[] Developers { get; set; }
        public string Link { get; set; }
        public string[] Requirements { get; set; }
        public string[] Technologies { get; set; }
    }
}