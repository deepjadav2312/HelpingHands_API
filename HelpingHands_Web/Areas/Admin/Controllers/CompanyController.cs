﻿using AutoMapper;
using HelpingHands_Web.Models.VM;
using System.Security.Claims;
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class CompanyController : Controller
        {
            ViewData["CurrentFilter"] = term;
            //term = string.IsNullOrEmpty(term) ? "" : term.ToLower();

            CompanyIndexVM companyIndexVM = new CompanyIndexVM();
            var response = await _companyService.CompanyByPagination<APIResponse>(term, orderBy, currentPage, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                companyIndexVM = JsonConvert.DeserializeObject<CompanyIndexVM>(Convert.ToString(response.Result));
            }
            return View(companyIndexVM);
        }
        // public async Task<IActionResult> IndexCompany()
        //{
        //    List<CompanyDTO> list = new();

        //    var response = await _companyService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
        //    if (response != null && response.IsSuccess)
        //    {
        //        list = JsonConvert.DeserializeObject<List<CompanyDTO>>(Convert.ToString(response.Result));
        //    }
        //    return View(list);
        //}


        public async Task<IActionResult> CreateCompany()
            if (response4 != null && response4.IsSuccess)
                {
                    Text = i.StateName,
                    Value = i.Id.ToString()
                });
                {
                    Text = i.CityName,
                    Value = i.Id.ToString()
                });
                //var claimsIdentity = (ClaimsIdentity)User.Identity;
                //var userId = claimsIdentity.FindSecond(ClaimTypes.NameIdentifier).Value;
                //string ApplicationUserId = userId;

                var response = await _companyService.CreateAsync<APIResponse>(companyCategoryVM.Company, HttpContext.Session.GetString(SD.SessionToken));
                else
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        TempData["error"] = response.ErrorMessages.FirstOrDefault();
                    }
                }
                else
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        TempData["error"] = response.ErrorMessages.FirstOrDefault();
                    }
                }
            {
                TempData["error"] = "Data Already used Can not be Delated sucessfully.";
            }

        #region Contry, state, city, firstcategory , second category and third category dropdown list
                var Model = JsonConvert.DeserializeObject<List<StateDTO>>(Convert.ToString(response.Result));
        #endregion


// this method are used when company can be delete and all the company image are delete in the data base to pperticular company.

//var productToBeDeleted = await _companyImageService.GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
//if (productToBeDeleted == null)
//{
//    TempData["success"] = "Data Delated sucessfully.";
//    return Json(new { success = false, message = "Error while deleting" });
//}

//string productPath = @"images\companies\company-" + companyId;
//string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, productPath);

//if (Directory.Exists(finalPath))
//{
//    string[] filePaths = Directory.GetFiles(finalPath);
//    foreach (string filePath in filePaths)
//    {
//        System.IO.File.Delete(filePath);
//    }

//    Directory.Delete(finalPath);
//}

//var response = await _companyImageService.DeleteAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
//if (response != null && response.IsSuccess)
//{
//    TempData["success"] = "Data Delated sucessfully.";
//    // return RedirectToAction(nameof(IndexCompanyXAmenity));
//    return RedirectToAction("IndexCompany", "Company");
//}

//return View();