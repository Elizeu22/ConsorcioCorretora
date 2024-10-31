using Corretora_Consorcio.DB;
using Corretora_Consorcio.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Corretora_Consorcio.Controllers
{
    public class CorretoraCadastroController:ControllerBase
    {
        private readonly CorretoraContext _context;

        public CorretoraCadastroController(CorretoraContext context)
        {

            _context = context;

        }


       [Authorize]
        [HttpGet("CorretoraCadastro")]
        public async Task<ActionResult<IEnumerable<CorretoraCadastro>>>
            GetTodos()
        {

            return await _context.Corretoras.ToListAsync();

        }

        [Authorize]
        [HttpGet("cnpj")]

        public async Task<ActionResult<CorretoraCadastro>>
           GetCorretora(long cnpj)
        {
            var cnpjCorretora = await _context.Corretoras.FirstOrDefaultAsync(c => c.IdCnpj == cnpj);

            if (cnpjCorretora == null)
            {
                return NotFound();
            }

            return cnpjCorretora;
        }


        //[Authorize]
        [HttpPost("CorretoraCadastro")]
        public async Task<ActionResult<CorretoraCadastro>>
            PostCorretora(CorretoraCadastro cadastro)
        {
            _context.Corretoras.Add(cadastro);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCorretora), new { cnpj = cadastro.IdCnpj }, cadastro);
        }

        [Authorize]
        [HttpPut("cnpj")]
        public async Task<IActionResult>
            PutCorretora(long cnpj, CorretoraCadastro atualizaCorretora)
        {
            if (cnpj != atualizaCorretora.IdCnpj)
            {
                return BadRequest();
            }

            _context.Entry(atualizaCorretora).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }




        [Authorize]
        [HttpDelete("cnpj")]
        public async Task<ActionResult<CorretoraCadastro>>
         DeleteCorretora(long cnpj)
        {
            var cnpjCorretora = await _context.Corretoras.FirstOrDefaultAsync(c => c.IdCnpj == cnpj);

            if (cnpjCorretora.ToString() == null)
            {
                return NotFound();
            }

            _context.Corretoras.Remove(cnpjCorretora);

            await _context.SaveChangesAsync();

            return cnpjCorretora;
        }
    }
}
