using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZaBranchCodeGenerator.Models;
using ZaBranchCodeGenerator.Services;
using System.Collections.Generic;

namespace ZaBranchCodeGenerator.Pages
{
    public class IndexModel : PageModel
    {
        public List<Bank> Banks { get; set; } = new();
        [BindProperty]
        public string? SelectedBankName { get; set; }
        public string? BranchCode { get; set; }

        public void OnGet()
        {
            Banks = BankService.GetBanks();
        }

        public void OnPost()
        {
            Banks = BankService.GetBanks();
            var selected = Banks.Find(b => b.BankName == SelectedBankName);
            BranchCode = selected?.BankCode;
        }
    }
}
