﻿using AutoMapper;
using HelpingHands_Web.Models.VM;
using HelpingHands_Web.Service.IService;
	[Area("Admin")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class StateController : Controller
        private readonly ICountryService _countryService;
        {
            _countryService = countryService;
            _stateService = stateService;
            _mapper = mapper;
        }
        {
            ViewData["CurrentFilter"] = term;
            //term = string.IsNullOrEmpty(term) ? "" : term.ToLower();

            StateIndexVM StateIndexVM = new StateIndexVM();
            var response = await _stateService.StateByPagination<APIResponse>(term, orderBy, currentPage, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                StateIndexVM = JsonConvert.DeserializeObject<StateIndexVM>(Convert.ToString(response.Result));
            }
            return View(StateIndexVM);
        }






        //public async Task<IActionResult> IndexState()
        //{
        //    List<StateDTO> list = new();

        //    var response = await _stateService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
        //    if (response != null && response.IsSuccess)
        //    {
        //        list = JsonConvert.DeserializeObject<List<StateDTO>>(Convert.ToString(response.Result));
        //    }
        //    return View(list);
        //}

        public async Task<IActionResult> CreateState()




        [HttpPost]
                //var claimsIdentity = (ClaimsIdentity)User.Identity;
                //var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
                //string ApplicationUserId = userId;

                var response = await _stateService.CreateAsync<APIResponse>(model.State, HttpContext.Session.GetString(SD.SessionToken));
                else
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        TempData["error"] = response.ErrorMessages.FirstOrDefault();
                    }
                }

        public async Task<IActionResult> UpdateState(int id)

                return View(stateVM);
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        TempData["error"] = response.ErrorMessages.FirstOrDefault();

                    }
                }

        //public async Task<IActionResult> DeleteState(int id)
        //{
        //    StateDeleteVM stateVM = new();
        //    var response = await _stateService.GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
        //    if (response != null && response.IsSuccess)
        //    {
        //        StateDTO model = JsonConvert.DeserializeObject<StateDTO>(Convert.ToString(response.Result));
        //        stateVM.State = model;
        //    }

        //    response = await _countryService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
        //    if (response != null && response.IsSuccess)
        //    {
        //        stateVM.CountryList = JsonConvert.DeserializeObject<List<CountryDTO>>
        //            (Convert.ToString(response.Result)).Select(i => new SelectListItem
        //            {
        //                Text = i.CountryName,
        //                Value = i.Id.ToString()
        //            });
        //        return View(stateVM);
        //    }

        //    return NotFound();
        //}


        //////[HttpPost]
        //////[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteState(int id)
            TempData["error"] = response.ErrorMessages.FirstOrDefault();
            return RedirectToAction(nameof(IndexState));