﻿using HelpingHands_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpingHands_Web.Models.VM
{
    public class StateUpdateVM
    {
        public StateUpdateVM()
        {
            State = new StateUpdateDTO();
        }
        public StateUpdateDTO State { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CountryList { get; set; }
    }
}
