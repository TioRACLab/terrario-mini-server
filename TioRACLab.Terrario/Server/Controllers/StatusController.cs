using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TioRACLab.Terrario.Server.Data;
using TioRACLab.Terrario.Shared;

namespace TioRACLab.Terrario.Server.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly ILogger<StatusController> _logger;
        private readonly ContextoTerrario _contextoTerrario;

        public StatusController(ILogger<StatusController> logger, ContextoTerrario contextoTerrario)
        {
            _logger = logger;
            _contextoTerrario = contextoTerrario;
        }

        [HttpGet("current")]
        public async Task<ActionResult<StatusTerrario>> Get()
        {
            return await _contextoTerrario.StatusTerrario.OrderByDescending(status => status.Timestamp) .FirstOrDefaultAsync();
        }

        [HttpGet("{timestamp}")]
        public async Task<ActionResult<StatusTerrario>> Get(int timestamp)
        {
            return await _contextoTerrario.StatusTerrario.FirstOrDefaultAsync(s => s.Timestamp == timestamp);
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusTerrario>>> GetAll()
        {
            return await _contextoTerrario.StatusTerrario.OrderByDescending(s => s.Timestamp).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(StatusTerrario statusTerrario)
        {
            if (_contextoTerrario.StatusTerrario.Any(status => status.Timestamp == statusTerrario.Timestamp))
                return Conflict();

            _contextoTerrario.StatusTerrario.Add(statusTerrario);
            await _contextoTerrario.SaveChangesAsync();

            return Ok();
        }
    }
}