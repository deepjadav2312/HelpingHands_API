﻿using HelpingHands_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpingHands_Web.Models.VM
{
    public class StateDeleteVM
    {
        public StateDeleteVM()
        {
            State = new StateDTO();
        }
        public StateDTO State { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CountryList { get; set; }
    }
}
