using Form.Business;
using Form.Model;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : BaseController
    {
        readonly FormProcess process;
        public FormController(FormProcess process) { this.process = process; }
        [HttpGet] public async Task<IActionResult> Get() => SendResponse(await process.Get(), true);
        [HttpGet(nameof(GetSelectedAnswer))] public async Task<IActionResult> GetSelectedAnswer() => SendResponse(await process.GetSelectedAnswer(), true);
        [HttpPost(nameof(CalculateScore))] public async Task<IActionResult> CalculateScore([FromBody]QuizResponse response) => SendResponse(await process.CalculateScore(response), true);
        [HttpPost] public async Task<IActionResult> Post([FromBody]Forms form) => SendResponse(await process.Create(form), true);
        [HttpPut] public async Task<IActionResult> Put([FromBody]Forms form) => SendResponse(await process.Update(form), true);
        [HttpDelete] public async Task<IActionResult> Delete(int id) => SendResponse(await process.Delete(id), true);
    }
}
    