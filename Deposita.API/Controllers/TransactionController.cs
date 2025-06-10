using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Deposita.API.Data;
using Deposita.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deposita.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionContext _context;

        public TransactionController(TransactionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transaction>>> Get()
        {
            return await _context.Transactions.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Transaction transaction)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return Ok(transaction);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Transaction transaction)
        {
            if (id != transaction.Id)
                return BadRequest();

            _context.Entry(transaction).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
                return NotFound();

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}