using Form.Business;
using Form.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : BaseController
    {
        readonly QuestionProcess process;
        public QuestionController([FromServices] QuestionProcess process ){ this.process = process; }
        [HttpGet] public async Task<IActionResult> Get() => SendResponse(await process.Get(), true);
        [HttpPut] public async Task<IActionResult> Put(Question question) => SendResponse(await process.Update(question), true);
        [HttpDelete] public async Task<IActionResult> Delete(int id) => SendResponse(await process.Delete(id), true);
    }
}
