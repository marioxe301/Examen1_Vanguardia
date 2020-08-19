using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancialApp.Core;
using FinancialApp.Core.DataTransferModels;
using FinancialApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinancialApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController( ITransactionService transactionService)
        {
            this._transactionService = transactionService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var transactionList = _transactionService.GetAllTransaction();
            if (transactionList.ResponseCode != ResponseCode.Success)
                return BadRequest(transactionList.Error);
            return Ok(transactionList.Result);
        }

        [HttpPost]
        public IActionResult Post(TransactionDataTransferObject transaction )
        {
            var transactionResult = _transactionService.Add(transaction);
            if (transactionResult.ResponseCode != ResponseCode.Success)
                return BadRequest(transactionResult.Error);
            return Ok(transactionResult.Result);
            
        }
    }
}
