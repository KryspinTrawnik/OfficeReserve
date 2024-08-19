using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OfficeReserve.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Get the profile of the currently logged-in user.
        /// </summary>
        [HttpGet("profile")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<string>> GetUserProfile()
        {
            return "User Profile";
        }

        /// <summary>
        /// Update the user's profile information.
        /// </summary>
        [HttpPut("profile")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<string>> UpdateUserProfile()
        {
            return "User Profile Updated";
        }

        /// <summary>
        /// Change the user's account password.
        /// </summary>
        [HttpPost("change-password")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<string>> ChangePassword()
        {
            return "Password Changed";
        }

        /// <summary>
        /// Get a list of all bookings made by the user.
        /// </summary>
        [HttpGet("bookings")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<string>> GetUserBookings()
        {
            return "List of User Bookings";
        }

        /// <summary>
        /// Cancel a booking made by the user.
        /// </summary>
        [HttpDelete("bookings/{bookingId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> CancelBooking(int bookingId)
        {
            return "Booking Cancelled";
        }

        /// <summary>
        /// Get the user's notification preferences.
        /// </summary>
        [HttpGet("notifications/preferences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<string>> GetNotificationPreferences()
        {
            return "Notification Preferences";
        }

        /// <summary>
        /// Update the user's notification preferences.
        /// </summary>
        [HttpPut("notifications/preferences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<string>> UpdateNotificationPreferences()
        {
            return "Notification Preferences Updated";
        }

        /// <summary>
        /// Get a log of the user's activity within the system.
        /// </summary>
        [HttpGet("activity-log")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<string>> GetUserActivityLog()
        {
            return "User Activity Log";
        }

        /// <summary>
        /// Deactivate the user's account.
        /// </summary>
        [HttpPost("deactivate-account")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<string>> DeactivateAccount()
        {
            return "Account Deactivated";
        }

        /// <summary>
        /// Reactivate the user's account.
        /// </summary>
        [HttpPost("reactivate-account")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<string>> ReactivateAccount()
        {
            return "Account Reactivated";
        }

    }
}
