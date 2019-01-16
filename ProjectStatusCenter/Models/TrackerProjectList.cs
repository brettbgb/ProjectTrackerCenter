using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectStatusCenter.Models
{
    public class TrackerProjectList
    {
        public List<TBL> tBLs;

        [Display(Name = "Start Year")]
        public int SelectedStartYear { get; set; }

        [Display(Name = "End Year")]
        public int SelectedEndYear { get; set; }

        public IEnumerable<SelectListItem> StartYear { get; set; }
        public IEnumerable<SelectListItem> EndYear { get; set; }
    }
}