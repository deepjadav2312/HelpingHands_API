﻿using AutoMapper;
using HelpingHands_API.Models;
using HelpingHands_API.Repository.IRepostiory;
using System.Net;
	[Route("api/v{version:apiVersion}/[Controller]/[Action]")]
	[ApiController]


		[HttpGet(Name = "GetStates")]
		[ResponseCache(CacheProfileName = "Default30")]


        [HttpGet(Name = "StateByPagination")]
                term = string.IsNullOrEmpty(term) ? "" : term.ToLower();

                StateIndexVM stateIndexVM = new StateIndexVM();
                IEnumerable<State> list = await _unitOfWork.State.GetAllAsync(includeProperties: "Country");

                var List = _mapper.Map<List<StateDTO>>(list);

                stateIndexVM.NameSortOrder = string.IsNullOrEmpty(orderBy) ? "countryName_desc" : "";

                if (!string.IsNullOrEmpty(term))
                {
                    List = List.Where(u => u.StateName.ToLower().Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    u.Country.CountryName.ToLower().Contains(term, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                switch (orderBy)
                {
                    case "countryName_desc":
                        List = List.OrderByDescending(a => a.StateName).ToList();
                        break;

                    default:
                        List = List.OrderBy(a => a.StateName).ToList();
                        break;
                }
                int totalRecords = List.Count();
                int pageSize = 10;
                int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
                List = List.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                // current=1, skip= (1-1=0), take=5 
                // currentPage=2, skip (2-1)*5 = 5, take=5 ,
                stateIndexVM.states = List;
                stateIndexVM.CurrentPage = currentPage;
                stateIndexVM.TotalPages = totalPages;
                stateIndexVM.Term = term;
                stateIndexVM.PageSize = pageSize;
                stateIndexVM.OrderBy = orderBy;

                _response.Result = _mapper.Map<StateIndexVM>(stateIndexVM);
        //[ProducesResponseType(200, Type =typeof(CategoryDTO))]
        //        [ResponseCache(Location =ResponseCacheLocation.None,NoStore =true)]
        public async Task<ActionResult<APIResponse>> GetState(int id)



		[HttpPost(Name = "CreateState")]
		// [Authorize(Roles = "admin")]
		[ProducesResponseType(StatusCodes.Status201Created)]
                //if (!ModelState.IsValid)
                //{
                //    return BadRequest(ModelState);
                //}
                var existingState = await _unitOfWork.State.GetAsync(u => u.StateName.ToLower() == createDTO.StateName.ToLower() && u.CountryId == createDTO.CountryId);

                if (existingState != null)
                {
                        ModelState.AddModelError("ErrorMessages", "State already Exists!");
                        return BadRequest(ModelState);
                }

                //if (await _unitOfWork.State.GetAsync(u => u.StateName.ToLower() == createDTO.StateName.ToLower() && u.CountryId == createDTO.CountryId) != null)
                //{
                //    ModelState.AddModelError("ErrorMessages", "State already Exists!");
                //    return BadRequest(ModelState);
                //}


                if (await _unitOfWork.Country.GetAsync(u => u.Id == createDTO.CountryId) == null)

        public async Task<ActionResult<APIResponse>> DeleteState(int id)