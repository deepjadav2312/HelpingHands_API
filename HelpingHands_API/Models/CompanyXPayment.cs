﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HelpingHands_API.Models
{
    public class CompanyXPayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        [ValidateNever]
        public Company Company { get; set; }

        [ForeignKey("Payment")]
        public int PaymentId{ get; set; }
        [ValidateNever]
        public Payment Payment{ get; set; }
    

    }
}
