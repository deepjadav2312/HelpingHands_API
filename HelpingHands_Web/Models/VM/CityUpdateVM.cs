﻿using HelpingHands_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpingHands_Web.Models.VM
{
    public class CityUpdateVM
    {
        public CityUpdateVM()
        {
            City = new CityUpdateDTO();
        }
        public CityUpdateDTO City { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CountryList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> StateList { get; set; }
    }
}
