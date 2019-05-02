﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabManager.Models.ViewModels
{
    public class LabThingCreateViewModel
    {
        public LabThing LabThing { get; set; }

        public List<SelectListItem> Category { get; set; }
        public List<SelectListItem> Manufacturer { get; set; }
        public List<SelectListItem> Employee { get; set; }
    }
}
