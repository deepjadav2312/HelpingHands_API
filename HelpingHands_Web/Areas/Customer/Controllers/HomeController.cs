﻿using AutoMapper;
        private readonly ICompanyXAmenityService _companyXAmenityService;



            var ReviewXcommentList = await _reviewXCommentService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (ReviewXcommentList != null && ReviewXcommentList.IsSuccess)
            {
                var reviewList = JsonConvert.DeserializeObject<List<ReviewXCommentDTO>>(Convert.ToString(ReviewXcommentList.Result));
                homeVM.ReviewXCommentList = reviewList.OrderByDescending(p => p.Id).ToList(); 

            }


      
    // Search bar
    [HttpPost]
            // Perform search and populate the view model
            var viewModel = await GetSearchResults(searchText);

            }

        // search bar with loazy loading
        [HttpPost]
            //pageNum = pageNum ?? 0;
            //ViewBag.IsEndOfRecords = false;
            //if (Request.IsAjaxRequest())
            if (pageNum == null)
                    TempData["searchText"] = searchText;
                    TempData["error"] = "Search Data DoesNot Exists.";


        public IActionResult Privacy()

}