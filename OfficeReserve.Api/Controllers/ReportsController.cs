using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeReserve.Api.Models;

namespace OfficeReserve.Api.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        /// <summary>
        /// Gets a report of room.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetReport(int bookingId)
        {
            return "Report";
        }

        /// <summary>
        /// Get a report on office utilization.
        /// </summary>
        [HttpGet("utilization")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetUtilizationReport(int bookingId)
        {
            return "Utilization Report";
        }

        /// <summary>
        /// Get a summary report.
        /// </summary>
        [HttpGet("summary")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetSummaryReport(int bookingId)
        {
            return "Summary Report";
        }

        /// <summary>
        /// Get booking trends over a specified period.
        /// </summary>
        [HttpGet("trends")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetBookingTrends()
        {
            return "Booking Trends Report";
        }

        /// <summary>
        /// Get a report of all bookings made by a specific user.
        /// </summary>
        [HttpGet("user/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetBookingsByUser(int userId)
        {
            return "User Bookings Report";
        }

        /// <summary>
        /// Get the occupancy rate report for all rooms.
        /// </summary>
        [HttpGet("occupancy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetRoomOccupancyReport()
        {
            return "Room Occupancy Report";
        }

        /// <summary>
        /// Get a report of all cancelled bookings.
        /// </summary>
        [HttpGet("cancellations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetCancellationReport()
        {
            return "Cancellation Report";
        }

        /// <summary>
        /// Get a report of peak usage times for rooms.
        /// </summary>
        [HttpGet("peak-usage")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetPeakUsageTimes()
        {
            return "Peak Usage Times Report";
        }

        /// <summary>
        /// Get a report on no-shows for bookings.
        /// </summary>
        [HttpGet("no-shows")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetNoShowReport()
        {
            return "No-Show Report";
        }

        /// <summary>
        /// Get a report on the average duration of bookings.
        /// </summary>
        [HttpGet("booking-duration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetBookingDurationReport()
        {
            return "Booking Duration Report";
        }

        /// <summary>
        /// Get a report for a specific date range.
        /// </summary>
        [HttpGet("date-range")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetReportByDateRange(DateTime startDate, DateTime endDate)
        {
            return "Date Range Report";
        }

        /// <summary>
        /// Get a report on the most booked rooms.
        /// </summary>
        [HttpGet("most-booked")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetMostBookedRoomsReport()
        {
            return "Most Booked Rooms Report";
        }

    }
}
