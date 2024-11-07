using Form.Business;
using Form.Model;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : BaseController
    {
        readonly OptionProcess process;
        public OptionController(OptionProcess process) { this.process = process; }
        [HttpGet] public async Task<IActionResult> Get() => SendResponse(await process.Get(), true);
        [HttpPut] public async Task<IActionResult> Put([FromBody] Option option) => SendResponse(await process.Update(option), true);
        [HttpDelete] public async Task<IActionResult> Delete(int id) => SendResponse(await process.Delete(id), true);
    }
}