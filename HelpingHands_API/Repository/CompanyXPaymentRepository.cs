﻿

using HelpingHands_API.Data;
using HelpingHands_API.Models;
using HelpingHands_API.Repository;
using HelpingHands_API.Repository.IRepostiory;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HelpingHands_API.Repository
{
    public class CompanyXPaymentRepository : Repository<CompanyXPayment>, ICompanyXPaymentRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyXPaymentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

  
        public async Task<CompanyXPayment> UpdateAsync(CompanyXPayment entity)
        {
         
            _db.CompanyXPayments.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
