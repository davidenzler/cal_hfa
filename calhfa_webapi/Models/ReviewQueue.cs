﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalhfaWebapi.Models
{
    public class ReviewCount
    {
        // Loan.LoanID, LoanType.LoanCategoryID, StatusCode, LoanStatus.StatusDate
        // public type ColumnName { get; set; }
        public int LoanID { get; set; }
        public int LoanCategoryID { get; set; }
        public int StatusCode { get; set; }
        public DateTime StatusDate { get; set; }
    }
}
