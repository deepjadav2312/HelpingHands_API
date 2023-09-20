﻿using AutoMapper;
using HelpingHands_Web.Models.VM;
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class ApplicationUserController : Controller
        
        public ApplicationUserController(IApplicationUserService userService, IApplicationRoleService roleService,
            IMapper mapper, IApplicationUserRoleService userRoleService)
            _roleService = roleService;
        {
            ViewData["CurrentFilter"] = term;
            //term = string.IsNullOrEmpty(term) ? "" : term.ToLower();

            ApplicationUserIndexVM applicationUserIndexVM = new ApplicationUserIndexVM();
            var response = await _userService.ApplicationUserByPagination<APIResponse>(term, orderBy, currentPage, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                applicationUserIndexVM = JsonConvert.DeserializeObject<ApplicationUserIndexVM>(Convert.ToString(response.Result));
            }
            return View(applicationUserIndexVM);
        }

        //public async Task<IActionResult> IndexApplicationUser()
        //{
        //    List<ApplicationUserDTO> list = new();

        //    var response = await _userService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
        //    if (response != null && response.IsSuccess)
        //    {
        //        list = JsonConvert.DeserializeObject<List<ApplicationUserDTO>>(Convert.ToString(response.Result));
        //    }
        //    return View(list);
        //}

        [HttpGet]
            var response = await _userService.GetAsync<APIResponse>(ApplicationUserId, HttpContext.Session.GetString(SD.SessionToken));

            var UserRoleList = await _userRoleService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (UserRoleList != null && UserRoleList.IsSuccess)
            {
                var list = JsonConvert.DeserializeObject<List<ApplicationUserRoleDTO>>(Convert.ToString(UserRoleList.Result));
                userVM.ApplicationUserRoleList = list.Where(x => x.UserId == ApplicationUserId).ToList();
            }

                userVM.ApplicationRoleList = JsonConvert.DeserializeObject<List<ApplicationRoleDTO>>
                        (Convert.ToString(ApplicationRoleList.Result)).Select(i => new ApplicationRoleDTO
                        {
                            Name = i.Name,
                            Id = i.Id,
                            IsChecked = userVM.ApplicationUserRoleList.Where(x => x.RoleId == i.Id && x.UserId == ApplicationUserId).Any()
                        }).ToList();
            }
            return View(userVM);


        [HttpPost]
            
                else
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        TempData["error"] = response.ErrorMessages.FirstOrDefault();
                    }
                }

            var UserRoleList = await _userRoleService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (UserRoleList != null && UserRoleList.IsSuccess)
            {
                updateUser.ApplicationUserRoleList = JsonConvert.DeserializeObject<List<ApplicationUserRoleDTO>>(Convert.ToString(UserRoleList.Result));
            }

            return View(updateUser);