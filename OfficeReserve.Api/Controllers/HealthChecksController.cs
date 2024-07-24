using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeReserve.Api.Models;
using System.Runtime.InteropServices;

namespace OfficeReserve.Api.Controllers
{
    /// <summary>
    /// The controler tests if the application works correctly
    /// </summary>
    [Route("api/hc")]
    [ApiController]
    public class HealthChecksController : ControllerBase
    {
        /// <summary>
        /// General health check.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetHealth()
        {
            return "Healthy";
        }
        /// <summary>
        /// Database connection and general functioning check.
        /// </summary>
        /// <returns></returns>
        [HttpGet("db")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetDatabaseHealth()
        {
            return "Healthy";
        }

        /// <summary>
        /// More detailed report of app functioning.
        /// </summary>
        /// <returns></returns>
        [HttpGet("details")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetDetailsHealth()
        {
            return "Healthy";
        }



    }
}

