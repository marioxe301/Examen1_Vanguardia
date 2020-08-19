using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancialApp.Core;
using FinancialApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinancialApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            this._accountService= accountService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var accounts = _accountService.GetAllAccounts();
            if (accounts.ResponseCode != ResponseCode.Success)
                return BadRequest(accounts.Error);
            return Ok(accounts.Result);
        }
    }
}
