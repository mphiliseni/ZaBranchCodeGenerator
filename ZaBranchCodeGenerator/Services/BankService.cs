using ZaBranchCodeGenerator.Models;
using System.Collections.Generic;

namespace ZaBranchCodeGenerator.Services
{
    public class BankService
    {
        public static List<Bank> GetBanks()
        {
            return new List<Bank>
            {
                new Bank { BankName ="IThala bank", BankCode = "580000", Description = "Development bank focused on economic empowerment in KwaZulu-Natal.", Location = "Durban" },
                new Bank { BankName = "Absa Bank", BankCode = "632005", Description = "One of South Africa’s largest financial services groups.", Location = "Johannesburg" },
                new Bank { BankName = "African Bank", BankCode = "430000", Description = "Retail bank specializing in loans and savings.", Location = "Midrand" },
                new Bank { BankName = "Capitec Bank", BankCode = "470010", Description = "Retail bank offering simplified, affordable banking.", Location = "Stellenbosch" },
                new Bank { BankName = "First National Bank (South Africa)", BankCode = "250655", Description = "One of the oldest banks in South Africa.", Location = "Johannesburg" },
                new Bank { BankName = "Investec Bank", BankCode = "580105", Description = "Specialist bank and asset manager.", Location = "Sandton" },
                new Bank { BankName = "Mtn Banking", BankCode = "490991", Description = "Mobile banking service by MTN and a banking partner.", Location = "Johannesburg" },
                new Bank { BankName = "Meeg Bank", BankCode = "471001", Description = "Previously a development bank, now part of Absa.", Location = "Eastern Cape" },
                new Bank { BankName = "Nedbank (South Africa)", BankCode = "198765", Description = "Major bank offering full financial services.", Location = "Sandton" },
                new Bank { BankName = "Postbank", BankCode = "460005", Description = "Government-owned bank offering basic financial services.", Location = "Pretoria" },
                new Bank { BankName = "Standard Bank (South Africa)", BankCode = "51001", Description = "One of the largest banks in Africa.", Location = "Johannesburg" },
                new Bank { BankName = "Albaraka Bank", BankCode = "800000", Description = "Islamic bank operating in South Africa.", Location = "Durban" },
                new Bank { BankName = "Bank Of Namibia", BankCode = "980172", Description = "Central bank of Namibia.", Location = "Windhoek, Namibia" },
                new Bank { BankName = "Bidvest Bank", BankCode = "462005", Description = "Specialized in foreign exchange and fleet finance.", Location = "Johannesburg" },
                new Bank { BankName = "Central Bank Of Lesotho", BankCode = "586611", Description = "Monetary authority of Lesotho.", Location = "Maseru, Lesotho" },
                new Bank { BankName = "Citi Bank", BankCode = "350005", Description = "Global bank providing commercial and investment banking.", Location = "Johannesburg" },
                new Bank { BankName = "Finbond Mutual Bank", BankCode = "589000", Description = "Focused on short-term loans and savings.", Location = "Pretoria" },
                new Bank { BankName = "First National Bank Lesotho", BankCode = "280061", Description = "Subsidiary of FNB in Lesotho.", Location = "Maseru, Lesotho" },
                new Bank { BankName = "First National Bank Namibia", BankCode = "282672", Description = "Namibian branch of FNB.", Location = "Windhoek, Namibia" },
                new Bank { BankName = "First National Bank Swaziland", BankCode = "280164", Description = "Branch of FNB in Eswatini.", Location = "Mbabane, Eswatini" },
                new Bank { BankName = "Grinrod Bank", BankCode = "584000", Description = "Specialist investment bank.", Location = "Durban" },
                new Bank { BankName = "Hsbc Bank", BankCode = "587000", Description = "Global banking and financial services.", Location = "Johannesburg" },
                new Bank { BankName = "Jp Morgan Chase Bank", BankCode = "432000", Description = "Multinational investment and commercial bank.", Location = "Johannesburg" },
                new Bank { BankName = "Standard Bank Namibia", BankCode = "87373", Description = "Subsidiary of Standard Bank Group in Namibia.", Location = "Windhoek, Namibia" },
                new Bank { BankName = "State Bank Of India", BankCode = "801000", Description = "Indian multinational banking and financial services.", Location = "Johannesburg" },
                new Bank { BankName = "Ubank", BankCode = "431010", Description = "Bank focused on mineworkers and their families.", Location = "Johannesburg" },
                new Bank { BankName = "Unibank", BankCode = "790005", Description = "Previously operating South African bank.", Location = "South Africa" },
                new Bank { BankName = "Vbs Mutual Bank", BankCode = "588000", Description = "Previously operating mutual bank.", Location = "Thohoyandou" }
            };
        }
    }
}