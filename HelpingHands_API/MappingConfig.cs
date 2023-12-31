﻿using AutoMapper;
using HelpingHands_API.Models;
using HelpingHands_API.Models.DTO;
using Microsoft.AspNetCore.Identity;

namespace HelpingHands_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Amenity, AmenityDTO>().ReverseMap();
            CreateMap<Amenity, AmenityCreateDTO>().ReverseMap();
            CreateMap<Amenity, AmenityUpdateDTO>().ReverseMap();



            CreateMap<City, CityDTO>().ReverseMap();            CreateMap<City, CityCreateDTO>().ReverseMap();            CreateMap<City, CityUpdateDTO>().ReverseMap();

            CreateMap<CompanyImage, CompanyImageDTO>().ReverseMap();
            CreateMap<CompanyImage, CompanyImageCreateDTO>().ReverseMap();
            CreateMap<CompanyImage, CompanyImageUpdateDTO>().ReverseMap();

            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Company, CompanyCreateDTO>().ReverseMap();
            CreateMap<Company, CompanyUpdateDTO>().ReverseMap();

            CreateMap<CompanyXAmenity, CompanyXAmenityDTO>().ReverseMap();
            CreateMap<CompanyXAmenity, CompanyXAmenityCreateDTO>().ReverseMap();
            CreateMap<CompanyXAmenity, CompanyXAmenityUpdateDTO>().ReverseMap();

            CreateMap<CompanyXPayment, CompanyXPaymentDTO>().ReverseMap();
            CreateMap<CompanyXPayment, CompanyXPaymentCreateDTO>().ReverseMap();
            CreateMap<CompanyXPayment, CompanyXPaymentUpdateDTO>().ReverseMap();

            CreateMap<CompanyXService, CompanyXServiceDTO>().ReverseMap();
            CreateMap<CompanyXService, CompanyXServiceCreateDTO>().ReverseMap();
            CreateMap<CompanyXService, CompanyXServiceUpdateDTO>().ReverseMap();

            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CountryCreateDTO>().ReverseMap();
            CreateMap<Country, CountryUpdateDTO>().ReverseMap();
            
            
            CreateMap<Enquiry, EnquiryDTO>().ReverseMap();
     

            CreateMap<FirstCategory, FirstCategoryDTO>().ReverseMap();
            CreateMap<FirstCategory, FirstCategoryCreateDTO>().ReverseMap();
            CreateMap<FirstCategory, FirstCategoryUpdateDTO>().ReverseMap();

            CreateMap<Payment, PaymentDTO>().ReverseMap();
            CreateMap<Payment, PaymentCreateDTO>().ReverseMap();
            CreateMap<Payment, PaymentUpdateDTO>().ReverseMap();

            CreateMap<Review, ReviewDTO>().ReverseMap();
            CreateMap<Review, ReviewCreateDTO>().ReverseMap();
            CreateMap<Review, ReviewUpdateDTO>().ReverseMap();

            CreateMap<SecondCategory, SecondCategoryDTO>().ReverseMap();
            CreateMap<SecondCategory, SecondCategoryCreateDTO>().ReverseMap();
            CreateMap<SecondCategory, SecondCategoryUpdateDTO>().ReverseMap();

            CreateMap<ReviewXComment, ReviewXCommentDTO>().ReverseMap();
            CreateMap<ReviewXComment, ReviewXCommentCreateDTO>().ReverseMap();
            CreateMap<ReviewXComment, ReviewXCommentUpdateDTO>().ReverseMap();

            CreateMap<Service, ServiceDTO>().ReverseMap();
            CreateMap<Service, ServiceCreateDTO>().ReverseMap();
            CreateMap<Service, ServiceUpdateDTO>().ReverseMap();

            CreateMap<State, StateDTO>().ReverseMap();
            CreateMap<State, StateCreateDTO>().ReverseMap();
            CreateMap<State, StateUpdateDTO>().ReverseMap();

            CreateMap<ThirdCategory, ThirdCategoryDTO>().ReverseMap();
            CreateMap<ThirdCategory, ThirdCategoryCreateDTO>().ReverseMap();
            CreateMap<ThirdCategory, ThirdCategoryUpdateDTO>().ReverseMap();


            CreateMap<ApplicationUser, ApplicationUserDTO>().ReverseMap();
            CreateMap<ApplicationUser, IdentityUser>().ReverseMap();
            CreateMap<ApplicationRole, ApplicationRoleDTO>().ReverseMap();
            CreateMap<ApplicationRole, IdentityRole>().ReverseMap();
            CreateMap<ApplicationUserRole, ApplicationUserRoleDTO>().ReverseMap();
            CreateMap<ApplicationUserRole, IdentityUserRole<string>>().ReverseMap();
        }
    }
}
  

