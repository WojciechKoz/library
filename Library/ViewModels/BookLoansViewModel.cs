using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.ViewModels
{
    public class BookLoansViewModel
    {
        public Book Book { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
