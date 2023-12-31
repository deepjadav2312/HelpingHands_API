﻿using HelpingHands_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpingHands_Web.Models.VM
{
    public class ReviewXCommentCreateVM
    {
        public ReviewXCommentCreateVM()
        {
            ReviewXComment = new ReviewXCommentCreateDTO();
        }
        public ReviewXCommentCreateDTO ReviewXComment { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CompanyList { get; set; }
        [ValidateNever]
        public List<ReviewDTO> ReviewList{ get; set; }

	}
}
